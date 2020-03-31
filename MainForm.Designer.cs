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
            this.BTNCreateClasses = new System.Windows.Forms.Button();
            this.BTNPrint = new System.Windows.Forms.Button();
            this.BTNAddRoles = new System.Windows.Forms.Button();
            this.BTNPrintRoles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNListAntiPatterns
            // 
            this.BTNListAntiPatterns.Location = new System.Drawing.Point(27, 200);
            this.BTNListAntiPatterns.Name = "BTNListAntiPatterns";
            this.BTNListAntiPatterns.Size = new System.Drawing.Size(180, 64);
            this.BTNListAntiPatterns.TabIndex = 0;
            this.BTNListAntiPatterns.Text = "Add Antipatterns to Classes";
            this.BTNListAntiPatterns.UseVisualStyleBackColor = true;
            this.BTNListAntiPatterns.Click += new System.EventHandler(this.BTNListAntiPatterns_Click);
            // 
            // BTNSelectDir
            // 
            this.BTNSelectDir.Location = new System.Drawing.Point(27, 27);
            this.BTNSelectDir.Name = "BTNSelectDir";
            this.BTNSelectDir.Size = new System.Drawing.Size(180, 32);
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
            this.BTNTotals.Location = new System.Drawing.Point(27, 65);
            this.BTNTotals.Name = "BTNTotals";
            this.BTNTotals.Size = new System.Drawing.Size(180, 64);
            this.BTNTotals.TabIndex = 5;
            this.BTNTotals.Text = "Calculate Total Antipatterns";
            this.BTNTotals.UseVisualStyleBackColor = true;
            this.BTNTotals.Click += new System.EventHandler(this.BTNTotals_Click);
            // 
            // BTNCreateClasses
            // 
            this.BTNCreateClasses.Location = new System.Drawing.Point(27, 159);
            this.BTNCreateClasses.Name = "BTNCreateClasses";
            this.BTNCreateClasses.Size = new System.Drawing.Size(180, 35);
            this.BTNCreateClasses.TabIndex = 8;
            this.BTNCreateClasses.Text = "Create Classes";
            this.BTNCreateClasses.UseVisualStyleBackColor = true;
            this.BTNCreateClasses.Click += new System.EventHandler(this.BTNCreateClasses_Click);
            // 
            // BTNPrint
            // 
            this.BTNPrint.Location = new System.Drawing.Point(27, 351);
            this.BTNPrint.Name = "BTNPrint";
            this.BTNPrint.Size = new System.Drawing.Size(180, 38);
            this.BTNPrint.TabIndex = 9;
            this.BTNPrint.Text = "Print Classes";
            this.BTNPrint.UseVisualStyleBackColor = true;
            this.BTNPrint.Click += new System.EventHandler(this.BTNPrint_Click);
            // 
            // BTNAddRoles
            // 
            this.BTNAddRoles.Location = new System.Drawing.Point(27, 270);
            this.BTNAddRoles.Name = "BTNAddRoles";
            this.BTNAddRoles.Size = new System.Drawing.Size(180, 35);
            this.BTNAddRoles.TabIndex = 10;
            this.BTNAddRoles.Text = "Add Role to Classes";
            this.BTNAddRoles.UseVisualStyleBackColor = true;
            this.BTNAddRoles.Click += new System.EventHandler(this.BTNAddRoles_Click);
            // 
            // BTNPrintRoles
            // 
            this.BTNPrintRoles.Location = new System.Drawing.Point(27, 395);
            this.BTNPrintRoles.Name = "BTNPrintRoles";
            this.BTNPrintRoles.Size = new System.Drawing.Size(180, 35);
            this.BTNPrintRoles.TabIndex = 11;
            this.BTNPrintRoles.Text = "Print Roles";
            this.BTNPrintRoles.UseVisualStyleBackColor = true;
            this.BTNPrintRoles.Click += new System.EventHandler(this.BTNPrintRoles_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1105, 498);
            this.Controls.Add(this.BTNPrintRoles);
            this.Controls.Add(this.BTNAddRoles);
            this.Controls.Add(this.BTNPrint);
            this.Controls.Add(this.BTNCreateClasses);
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
        private System.Windows.Forms.Button BTNCreateClasses;
        private System.Windows.Forms.Button BTNPrint;
        private System.Windows.Forms.Button BTNAddRoles;
        private System.Windows.Forms.Button BTNPrintRoles;
    }
}

