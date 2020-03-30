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
            this.BTNListAntiPatterns = new System.Windows.Forms.Button();
            this.BTNSelectDir = new System.Windows.Forms.Button();
            this.TBSelectedDir = new System.Windows.Forms.TextBox();
            this.LBFiles = new System.Windows.Forms.ListBox();
            this.BTNTotals = new System.Windows.Forms.Button();
            this.CBAntipatterns = new System.Windows.Forms.ComboBox();
            this.LabelAntipattern = new System.Windows.Forms.Label();
            this.BTNCreateClasses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNListAntiPatterns
            // 
            this.BTNListAntiPatterns.Location = new System.Drawing.Point(27, 333);
            this.BTNListAntiPatterns.Name = "BTNListAntiPatterns";
            this.BTNListAntiPatterns.Size = new System.Drawing.Size(180, 64);
            this.BTNListAntiPatterns.TabIndex = 0;
            this.BTNListAntiPatterns.Text = "List Classes In Antipattern";
            this.BTNListAntiPatterns.UseVisualStyleBackColor = true;
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
            // BTNTotals
            // 
            this.BTNTotals.Location = new System.Drawing.Point(27, 128);
            this.BTNTotals.Name = "BTNTotals";
            this.BTNTotals.Size = new System.Drawing.Size(180, 64);
            this.BTNTotals.TabIndex = 5;
            this.BTNTotals.Text = "Calculate Total Antipatterns";
            this.BTNTotals.UseVisualStyleBackColor = true;
            this.BTNTotals.Click += new System.EventHandler(this.BTNTotals_Click);
            // 
            // CBAntipatterns
            // 
            this.CBAntipatterns.FormattingEnabled = true;
            this.CBAntipatterns.Location = new System.Drawing.Point(27, 423);
            this.CBAntipatterns.Name = "CBAntipatterns";
            this.CBAntipatterns.Size = new System.Drawing.Size(180, 28);
            this.CBAntipatterns.TabIndex = 6;
            // 
            // LabelAntipattern
            // 
            this.LabelAntipattern.AutoSize = true;
            this.LabelAntipattern.Location = new System.Drawing.Point(23, 400);
            this.LabelAntipattern.Name = "LabelAntipattern";
            this.LabelAntipattern.Size = new System.Drawing.Size(92, 20);
            this.LabelAntipattern.TabIndex = 7;
            this.LabelAntipattern.Text = "Antipattern:";
            // 
            // BTNCreateClasses
            // 
            this.BTNCreateClasses.Location = new System.Drawing.Point(27, 234);
            this.BTNCreateClasses.Name = "BTNCreateClasses";
            this.BTNCreateClasses.Size = new System.Drawing.Size(180, 64);
            this.BTNCreateClasses.TabIndex = 8;
            this.BTNCreateClasses.Text = "Create Classes";
            this.BTNCreateClasses.UseVisualStyleBackColor = true;
            this.BTNCreateClasses.Click += new System.EventHandler(this.BTNCreateClasses_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1105, 498);
            this.Controls.Add(this.BTNCreateClasses);
            this.Controls.Add(this.LabelAntipattern);
            this.Controls.Add(this.CBAntipatterns);
            this.Controls.Add(this.BTNTotals);
            this.Controls.Add(this.LBFiles);
            this.Controls.Add(this.TBSelectedDir);
            this.Controls.Add(this.BTNSelectDir);
            this.Controls.Add(this.BTNListAntiPatterns);
            this.Name = "MainForm";
            this.Text = "APCRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNListAntiPatterns;
        private System.Windows.Forms.Button BTNSelectDir;
        private System.Windows.Forms.TextBox TBSelectedDir;
        private System.Windows.Forms.ListBox LBFiles;
        private System.Windows.Forms.Button BTNTotals;
        private System.Windows.Forms.ComboBox CBAntipatterns;
        private System.Windows.Forms.Label LabelAntipattern;
        private System.Windows.Forms.Button BTNCreateClasses;
    }
}

