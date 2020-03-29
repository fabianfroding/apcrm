namespace APCRM
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
            this.BTNSelectDir = new System.Windows.Forms.Button();
            this.TBSelectedDir = new System.Windows.Forms.TextBox();
            this.LBFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTNRun
            // 
            this.BTNRun.Location = new System.Drawing.Point(92, 97);
            this.BTNRun.Name = "BTNRun";
            this.BTNRun.Size = new System.Drawing.Size(115, 64);
            this.BTNRun.TabIndex = 0;
            this.BTNRun.Text = "Run";
            this.BTNRun.UseVisualStyleBackColor = true;
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
            this.TBSelectedDir.Location = new System.Drawing.Point(213, 27);
            this.TBSelectedDir.Name = "TBSelectedDir";
            this.TBSelectedDir.ReadOnly = true;
            this.TBSelectedDir.Size = new System.Drawing.Size(880, 26);
            this.TBSelectedDir.TabIndex = 3;
            // 
            // LBFiles
            // 
            this.LBFiles.FormattingEnabled = true;
            this.LBFiles.ItemHeight = 20;
            this.LBFiles.Location = new System.Drawing.Point(213, 59);
            this.LBFiles.Name = "LBFiles";
            this.LBFiles.Size = new System.Drawing.Size(880, 424);
            this.LBFiles.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1105, 498);
            this.Controls.Add(this.LBFiles);
            this.Controls.Add(this.TBSelectedDir);
            this.Controls.Add(this.BTNSelectDir);
            this.Controls.Add(this.BTNRun);
            this.Name = "MainForm";
            this.Text = "APCRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNRun;
        private System.Windows.Forms.Button BTNSelectDir;
        private System.Windows.Forms.TextBox TBSelectedDir;
        private System.Windows.Forms.ListBox LBFiles;
    }
}

