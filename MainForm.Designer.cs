﻿namespace APCRM
{
    partial class MainForm
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
            this.BTNRun = new System.Windows.Forms.Button();
            this.RTBFiles = new System.Windows.Forms.RichTextBox();
            this.BTNSelectDir = new System.Windows.Forms.Button();
            this.TBSelectedDir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNRun
            // 
            this.BTNRun.Location = new System.Drawing.Point(27, 152);
            this.BTNRun.Name = "BTNRun";
            this.BTNRun.Size = new System.Drawing.Size(115, 64);
            this.BTNRun.TabIndex = 0;
            this.BTNRun.Text = "Run";
            this.BTNRun.UseVisualStyleBackColor = true;
            // 
            // RTBFiles
            // 
            this.RTBFiles.Location = new System.Drawing.Point(414, 36);
            this.RTBFiles.Name = "RTBFiles";
            this.RTBFiles.ReadOnly = true;
            this.RTBFiles.Size = new System.Drawing.Size(134, 202);
            this.RTBFiles.TabIndex = 1;
            this.RTBFiles.Text = "";
            // 
            // BTNSelectDir
            // 
            this.BTNSelectDir.Location = new System.Drawing.Point(27, 27);
            this.BTNSelectDir.Name = "BTNSelectDir";
            this.BTNSelectDir.Size = new System.Drawing.Size(180, 64);
            this.BTNSelectDir.TabIndex = 2;
            this.BTNSelectDir.Text = "Select Directory";
            this.BTNSelectDir.UseVisualStyleBackColor = true;
            this.BTNSelectDir.Click += new System.EventHandler(this.BTNSelectDir_Click);
            // 
            // TBSelectedDir
            // 
            this.TBSelectedDir.Location = new System.Drawing.Point(27, 106);
            this.TBSelectedDir.Name = "TBSelectedDir";
            this.TBSelectedDir.ReadOnly = true;
            this.TBSelectedDir.Size = new System.Drawing.Size(365, 26);
            this.TBSelectedDir.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(581, 310);
            this.Controls.Add(this.TBSelectedDir);
            this.Controls.Add(this.BTNSelectDir);
            this.Controls.Add(this.RTBFiles);
            this.Controls.Add(this.BTNRun);
            this.Name = "MainForm";
            this.Text = "APCRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNRun;
        private System.Windows.Forms.RichTextBox RTBFiles;
        private System.Windows.Forms.Button BTNSelectDir;
        private System.Windows.Forms.TextBox TBSelectedDir;
    }
}

