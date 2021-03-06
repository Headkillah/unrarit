﻿namespace UnRarIt
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RenameDirectory = new System.Windows.Forms.RadioButton();
            this.Rename = new System.Windows.Forms.RadioButton();
            this.Ask = new System.Windows.Forms.RadioButton();
            this.Overwrite = new System.Windows.Forms.RadioButton();
            this.Skip = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Nesting = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OwnDirectoryLimit = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SuccessRemove = new System.Windows.Forms.RadioButton();
            this.SuccessRename = new System.Windows.Forms.RadioButton();
            this.SuccesNothing = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RemoveAll = new System.Windows.Forms.RadioButton();
            this.RemoveDone = new System.Windows.Forms.RadioButton();
            this.RemoveNone = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LowPriority = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Threads = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OwnDirectoryLimit)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Threads)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(343, 305);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(262, 305);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RenameDirectory);
            this.groupBox1.Controls.Add(this.Rename);
            this.groupBox1.Controls.Add(this.Ask);
            this.groupBox1.Controls.Add(this.Overwrite);
            this.groupBox1.Controls.Add(this.Skip);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "When a file exists...";
            // 
            // RenameDirectory
            // 
            this.RenameDirectory.AutoSize = true;
            this.RenameDirectory.Location = new System.Drawing.Point(88, 65);
            this.RenameDirectory.Name = "RenameDirectory";
            this.RenameDirectory.Size = new System.Drawing.Size(67, 17);
            this.RenameDirectory.TabIndex = 5;
            this.RenameDirectory.TabStop = true;
            this.RenameDirectory.Text = "Directory";
            this.RenameDirectory.UseVisualStyleBackColor = true;
            // 
            // Rename
            // 
            this.Rename.AutoSize = true;
            this.Rename.Location = new System.Drawing.Point(17, 65);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(65, 17);
            this.Rename.TabIndex = 4;
            this.Rename.TabStop = true;
            this.Rename.Text = "Rename";
            this.Rename.UseVisualStyleBackColor = true;
            // 
            // Ask
            // 
            this.Ask.AutoSize = true;
            this.Ask.Location = new System.Drawing.Point(17, 88);
            this.Ask.Name = "Ask";
            this.Ask.Size = new System.Drawing.Size(43, 17);
            this.Ask.TabIndex = 3;
            this.Ask.TabStop = true;
            this.Ask.Text = "Ask";
            this.Ask.UseVisualStyleBackColor = true;
            // 
            // Overwrite
            // 
            this.Overwrite.AutoSize = true;
            this.Overwrite.Location = new System.Drawing.Point(17, 42);
            this.Overwrite.Name = "Overwrite";
            this.Overwrite.Size = new System.Drawing.Size(70, 17);
            this.Overwrite.TabIndex = 2;
            this.Overwrite.TabStop = true;
            this.Overwrite.Text = "Overwrite";
            this.Overwrite.UseVisualStyleBackColor = true;
            // 
            // Skip
            // 
            this.Skip.AutoSize = true;
            this.Skip.Location = new System.Drawing.Point(17, 19);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(46, 17);
            this.Skip.TabIndex = 1;
            this.Skip.TabStop = true;
            this.Skip.Text = "Skip";
            this.Skip.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Nesting);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.OwnDirectoryLimit);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 110);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Directories and archives...";
            // 
            // Nesting
            // 
            this.Nesting.AutoSize = true;
            this.Nesting.Location = new System.Drawing.Point(17, 83);
            this.Nesting.Name = "Nesting";
            this.Nesting.Size = new System.Drawing.Size(137, 17);
            this.Nesting.TabIndex = 7;
            this.Nesting.Text = "Extract nested archives";
            this.Nesting.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create a directory when more than this files aren\'t contained within a directory";
            // 
            // OwnDirectoryLimit
            // 
            this.OwnDirectoryLimit.Location = new System.Drawing.Point(155, 23);
            this.OwnDirectoryLimit.Name = "OwnDirectoryLimit";
            this.OwnDirectoryLimit.Size = new System.Drawing.Size(39, 20);
            this.OwnDirectoryLimit.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SuccessRemove);
            this.groupBox3.Controls.Add(this.SuccessRename);
            this.groupBox3.Controls.Add(this.SuccesNothing);
            this.groupBox3.Location = new System.Drawing.Point(218, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 119);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Processed archives will be...";
            // 
            // SuccessRemove
            // 
            this.SuccessRemove.AutoSize = true;
            this.SuccessRemove.Location = new System.Drawing.Point(17, 65);
            this.SuccessRemove.Name = "SuccessRemove";
            this.SuccessRemove.Size = new System.Drawing.Size(60, 17);
            this.SuccessRemove.TabIndex = 3;
            this.SuccessRemove.TabStop = true;
            this.SuccessRemove.Text = "deleted";
            this.SuccessRemove.UseVisualStyleBackColor = true;
            // 
            // SuccessRename
            // 
            this.SuccessRename.AutoSize = true;
            this.SuccessRename.Location = new System.Drawing.Point(17, 42);
            this.SuccessRename.Name = "SuccessRename";
            this.SuccessRename.Size = new System.Drawing.Size(66, 17);
            this.SuccessRename.TabIndex = 2;
            this.SuccessRename.TabStop = true;
            this.SuccessRename.Text = "renamed";
            this.SuccessRename.UseVisualStyleBackColor = true;
            // 
            // SuccesNothing
            // 
            this.SuccesNothing.AutoSize = true;
            this.SuccesNothing.Location = new System.Drawing.Point(17, 19);
            this.SuccesNothing.Name = "SuccesNothing";
            this.SuccesNothing.Size = new System.Drawing.Size(68, 17);
            this.SuccesNothing.TabIndex = 1;
            this.SuccesNothing.TabStop = true;
            this.SuccesNothing.Text = "left alone";
            this.SuccesNothing.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RemoveAll);
            this.groupBox4.Controls.Add(this.RemoveDone);
            this.groupBox4.Controls.Add(this.RemoveNone);
            this.groupBox4.Location = new System.Drawing.Point(218, 137);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Remove on completion...";
            // 
            // RemoveAll
            // 
            this.RemoveAll.AutoSize = true;
            this.RemoveAll.Location = new System.Drawing.Point(17, 65);
            this.RemoveAll.Name = "RemoveAll";
            this.RemoveAll.Size = new System.Drawing.Size(64, 17);
            this.RemoveAll.TabIndex = 6;
            this.RemoveAll.TabStop = true;
            this.RemoveAll.Text = "Clear list";
            this.RemoveAll.UseVisualStyleBackColor = true;
            // 
            // RemoveDone
            // 
            this.RemoveDone.AutoSize = true;
            this.RemoveDone.Location = new System.Drawing.Point(17, 42);
            this.RemoveDone.Name = "RemoveDone";
            this.RemoveDone.Size = new System.Drawing.Size(113, 17);
            this.RemoveDone.TabIndex = 5;
            this.RemoveDone.TabStop = true;
            this.RemoveDone.Text = "Extracted archives";
            this.RemoveDone.UseVisualStyleBackColor = true;
            // 
            // RemoveNone
            // 
            this.RemoveNone.AutoSize = true;
            this.RemoveNone.Location = new System.Drawing.Point(17, 19);
            this.RemoveNone.Name = "RemoveNone";
            this.RemoveNone.Size = new System.Drawing.Size(91, 17);
            this.RemoveNone.TabIndex = 4;
            this.RemoveNone.TabStop = true;
            this.RemoveNone.Text = "No items at all";
            this.RemoveNone.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LowPriority);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.Threads);
            this.groupBox5.Location = new System.Drawing.Point(12, 253);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(199, 76);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Performance";
            // 
            // LowPriority
            // 
            this.LowPriority.AutoSize = true;
            this.LowPriority.Location = new System.Drawing.Point(17, 46);
            this.LowPriority.Name = "LowPriority";
            this.LowPriority.Size = new System.Drawing.Size(99, 17);
            this.LowPriority.TabIndex = 12;
            this.LowPriority.Text = "Low I/O Priority";
            this.LowPriority.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Number of Threads";
            // 
            // Threads
            // 
            this.Threads.Location = new System.Drawing.Point(154, 19);
            this.Threads.Name = "Threads";
            this.Threads.Size = new System.Drawing.Size(39, 20);
            this.Threads.TabIndex = 9;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(430, 336);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OwnDirectoryLimit)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Threads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Ask;
        private System.Windows.Forms.RadioButton Overwrite;
        private System.Windows.Forms.RadioButton Skip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown OwnDirectoryLimit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton SuccessRemove;
        private System.Windows.Forms.RadioButton SuccessRename;
        private System.Windows.Forms.RadioButton SuccesNothing;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RemoveAll;
        private System.Windows.Forms.RadioButton RemoveDone;
        private System.Windows.Forms.RadioButton RemoveNone;
        private System.Windows.Forms.RadioButton Rename;
        private System.Windows.Forms.RadioButton RenameDirectory;
        private System.Windows.Forms.CheckBox Nesting;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Threads;
        private System.Windows.Forms.CheckBox LowPriority;
    }
}