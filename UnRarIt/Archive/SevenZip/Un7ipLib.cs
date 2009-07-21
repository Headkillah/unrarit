﻿using System;
using System.Collections.Generic;
using System.IO;

namespace UnRarIt.Archive.SevenZip
{
    public class SevenZipException : Exception
    {
        internal SevenZipException(string msg) : base(msg) { }
    }

    public class SevenZipMissingPasswordException : SevenZipException
    {
        internal SevenZipMissingPasswordException() : base("No password available") { }
    }

    public class SevenZipArchiveFile : IArchiveFile, IArchiveOpenCallback, IProgress, IGetPassword
    {
        Dictionary<string, IArchiveEntry> items = new Dictionary<string, IArchiveEntry>();
        string password = string.Empty;
        IEnumerator<string> passwords;
        FileInfo archive;
        public SevenZipArchiveFile(string aArchive)
        {
            archive = new FileInfo(aArchive);
            if (!archive.Exists)
            {
                throw new FileNotFoundException("SevenZip file not found!", aArchive);
            }
        }

        public FileInfo Archive
        {
            get { return archive; }
        }

        class ExtractCallback : IArchiveExtractCallback, IGetPassword, IDisposable, IProgress
        {
            private SevenZipArchiveFile owner;
            private Dictionary<uint, IArchiveEntry> files;
            private SevenZipStream stream;
            uint current = 0;
            ExtractMode mode = ExtractMode.Skip;

            internal ExtractCallback(SevenZipArchiveFile aOwner, Dictionary<uint, IArchiveEntry> aFiles)
            {
                owner = aOwner;
                files = aFiles;
            }

            public void SetTotal(ulong total)
            {
            }

            public void SetCompleted(ref ulong completeValue)
            {
            }

            public void GetStream(uint index, out ISequentialOutStream outStream, ExtractMode extractMode)
            {
                if (!files.ContainsKey(index))
                {
                    outStream = null;
                    mode = ExtractMode.Skip;
                    return;
                }
                if (extractMode == ExtractMode.Extract)
                {
                    if (stream != null)
                    {
                        stream.Dispose();
                    }
                    current = index;
                    stream = new SevenZipFileStream(files[index].Destination, FileMode.Create, FileAccess.Write);
                }
                else
                {
                    if (stream != null)
                    {
                        stream.Dispose();
                    }
                    stream = new SevenZipNullStream();
                }
                current = index;
                outStream = stream;
                mode = extractMode;
            }

            public void PrepareOperation(ExtractMode askExtractMode)
            {

            }

            public void SetOperationResult(OperationResult resultEOperationResult)
            {
                if (mode != ExtractMode.Skip && resultEOperationResult != OperationResult.OK)
                {
                    throw new IOException(resultEOperationResult.ToString());
                }
                if (mode == ExtractMode.Extract && owner.ExtractFile != null)
                {
                    ExtractFileEventArgs args = new ExtractFileEventArgs(owner.archive, files[current], files[current].Destination.FullName);
                    owner.ExtractFile(owner, args);
                    if (!args.ContinueOperation)
                    {
                        throw new IOException("User aborted!");
                    }
                }
            }
            public void CryptoGetTextPassword(out string aPassword)
            {
                owner.CryptoGetTextPassword(out aPassword);
            }

            public void Dispose()
            {
                if (stream != null)
                {
                    stream.Dispose();
                    stream = null;
                }
            }
        }

        public void Extract()
        {
            using (SevenZipArchive ar = new SevenZipArchive(archive, this))
            {
                List<uint> indices = new List<uint>();
                Dictionary<uint, IArchiveEntry> files = new Dictionary<uint, IArchiveEntry>();
                uint e = ar.GetNumberOfItems();
                for (uint i = 0; i < e; ++i)
                {
                    string name = ar.GetProperty(i, ItemPropId.Path).GetString();
                    if (!items.ContainsKey(name))
                    {
                        continue;
                    }

                    IArchiveEntry entry = items[name];
                    if (entry.Destination == null)
                    {
                        continue;
                    }
                    indices.Add(i);
                    files[i] = entry;
                }
                using (ExtractCallback callback = new ExtractCallback(this, files))
                {
                    ar.Extract(indices.ToArray(), (uint)indices.Count, ExtractMode.Extract, callback);
                }

            }
        }

        public int ItemCount
        {
            get { return items.Count; }
        }

        public void Open(IEnumerator<string> aPasswords)
        {
            passwords = aPasswords;
            for (; !passwordDefined; )
            {
                try
                {
                    using (SevenZipArchive ar = new SevenZipArchive(archive, this))
                    {
                        IArchiveEntry minCrypted = null;
                        uint minIndex = 0;
                        uint e = ar.GetNumberOfItems();
                        for (uint i = 0; i < e; ++i)
                        {
                            if (ar.GetProperty(i, ItemPropId.IsDir).GetBool())
                            {
                                continue;
                            }
                            string name = ar.GetProperty(i, ItemPropId.Path).GetString();
                            ulong size = ar.GetProperty(i, ItemPropId.Size).GetUlong();
                            ulong packedSize = ar.GetProperty(i, ItemPropId.PackedSize).GetUlong();
                            if (packedSize == 0)
                            {
                                packedSize = size;
                            }
                            bool isCrypted = ar.GetProperty(i, ItemPropId.Encrypted).GetBool();
                            uint crc = ar.GetProperty(i, ItemPropId.CRC).GetUint();
                            passwordDefined = true;
                            IArchiveEntry entry = new SevenZipItemInfo(name, crc, isCrypted, size, packedSize);
                            items[name] = entry;
                            if (isCrypted && (minCrypted == null || minCrypted.CompressedSize > packedSize))
                            {
                                minCrypted = entry;
                                minIndex = i;
                            }
                        }
                        if (minCrypted != null)
                        {
                            passwordDefined = false;
                            passwords.Reset();
                            Dictionary<uint, IArchiveEntry> files = new Dictionary<uint, IArchiveEntry>();
                            files[minIndex] = minCrypted;
                            for (; !passwordDefined; )
                            {
                                using (ExtractCallback callback = new ExtractCallback(this, files))
                                {
                                    try
                                    {
                                        ar.Extract(new uint[] { minIndex }, 1, ExtractMode.Test, callback);
                                        passwordDefined = true;
                                    }
                                    catch (IOException)
                                    {
                                        continue;
                                    }
                                }
                            }

                        }
                    }

                }
                catch (IndexOutOfRangeException)
                {
                    break;
                }
            }
        }

        public string Password
        {
            get { return password; }
        }

        public void Dispose()
        {

        }

        public IEnumerator<IArchiveEntry> GetEnumerator()
        {
            return items.Values.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return items.Values.GetEnumerator();
        }

        public void SetTotal(ulong total)
        {

        }

        public void SetCompleted(ref ulong completeValue)
        {

        }

        public event PasswordRequiredHandler PasswordRequired;
        public event PasswordAttemptHandler PasswordAttempt;
        public event ExtractFileHandler ExtractFile;

        public void SetTotal(IntPtr files, IntPtr bytes)
        {

        }

        public void SetCompleted(IntPtr files, IntPtr bytes)
        {

        }

        bool passwordDefined = false;
        public void CryptoGetTextPassword(out string aPassword)
        {
            if (passwordDefined)
            {
                aPassword = password;
                return;
            }
            if (passwords == null)
            {
                throw new IndexOutOfRangeException();
            }
            if (!passwords.MoveNext())
            {
                throw new IndexOutOfRangeException();
            }
            PasswordEventArgs args = new PasswordEventArgs(password);
            if (PasswordAttempt != null)
            {
                PasswordAttempt(this, args);
            }
            if (!args.ContinueOperation)
            {
                throw new IndexOutOfRangeException();
            }
            password = aPassword = passwords.Current;
        }
    }
}