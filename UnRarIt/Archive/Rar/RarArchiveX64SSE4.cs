﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace UnRarIt.Archive.Rar
{
    internal class RarArchiveX64SSE4 : RarArchive
    {
        [DllImportAttribute("unrar_x64_SSE4.dll", EntryPoint = "RARCloseArchive", CallingConvention = CallingConvention.StdCall)]
        private static extern RarStatus CloseArchiveImpl(IntPtr hArcData);

        [DllImportAttribute("unrar_x64_SSE4.dll", EntryPoint = "RAROpenArchiveEx", CallingConvention = CallingConvention.StdCall)]
        protected static extern IntPtr OpenArchiveImpl(ref RAROpenArchiveDataEx ArchiveData);

        [DllImportAttribute("unrar_x64_SSE4.dll", EntryPoint = "RARReadHeaderEx", CallingConvention = CallingConvention.StdCall)]
        protected static extern RarStatus GetHeaderImpl(IntPtr hArcData, ref Header HeaderData);

        [DllImportAttribute("unrar_x64_SSE4.dll", EntryPoint = "RARProcessFileW", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        protected static extern RarStatus ProcessFileImpl(IntPtr hArcData, RarOperation Operation, string DestPath, string DestName);

        [DllImportAttribute("unrar_x64_SSE4.dll", EntryPoint = "RARGetDllVersion", CallingConvention = CallingConvention.StdCall)]
        public static extern RarStatus GetVersionImpl();

        [DllImportAttribute("unrar_x64_SSE4.dll", EntryPoint = "RARSetPassword", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        protected static extern RarStatus SetPasswordImpl(IntPtr hArcData, string Password);

        [DllImportAttribute("unrar_x64_SSE4.dll", EntryPoint = "RARSetCallback", CallingConvention = CallingConvention.StdCall)]
        protected static extern void SetCallbackImpl(IntPtr hArcData, UnRarCallback callback, IntPtr UserData);


        protected override RarStatus CloseArchive()
        {
            return CloseArchiveImpl(handle);
        }

        protected override IntPtr OpenArchive(ref RarArchive.RAROpenArchiveDataEx ArchiveData)
        {
            return OpenArchiveImpl(ref ArchiveData);
        }

        public override RarStatus GetHeader(ref RarArchive.Header HeaderData)
        {
            return GetHeaderImpl(handle, ref HeaderData);
        }

        public override RarStatus ProcessFile(RarOperation Operation, string DestPath, string DestName)
        {
            return ProcessFileImpl(handle, Operation, DestPath, DestName);
        }

        public override RarStatus GetVersion()
        {
            return GetVersionImpl();
        }

        public override RarStatus SetPassword(string Password)
        {
            return SetPasswordImpl(handle, Password);
        }

        protected override void SetCallback(UnRarCallback callback, IntPtr UserData)
        {
            SetCallbackImpl(handle, callback, UserData);
        }

        public RarArchiveX64SSE4(string FileName, RarOpenMode Mode, UnRarCallback callback) : base(FileName, Mode, callback) { }
    }
}
