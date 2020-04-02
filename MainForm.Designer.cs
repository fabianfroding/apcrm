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
            this.BTNTotals = new System.Windows.Forms.Button();
            this.BTNCreateClasses = new System.Windows.Forms.Button();
            this.BTNPrint = new System.Windows.Forms.Button();
            this.BTNAddRoles = new System.Windows.Forms.Button();
            this.BTNPrintRoles = new System.Windows.Forms.Button();
            this.LabelCalcTotalAntipattern = new System.Windows.Forms.Label();
            this.LabelCreateClasses = new System.Windows.Forms.Label();
            this.LabelTip1 = new System.Windows.Forms.Label();
            this.LabelAddAntipatterns = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNListAntiPatterns
            // 
            this.BTNListAntiPatterns.Location = new System.Drawing.Point(27, 249);
            this.BTNListAntiPatterns.Name = "BTNListAntiPatterns";
            this.BTNListAntiPatterns.Size = new System.Drawing.Size(180, 64);
            this.BTNListAntiPatterns.TabIndex = 0;
            this.BTNListAntiPatterns.Text = "Add Antipatterns to Classes";
            this.BTNListAntiPatterns.UseVisualStyleBackColor = true;
            this.BTNListAntiPatterns.Click += new System.EventHandler(this.BTNListAntiPatterns_Click);
            // 
            // BTNSelectDir
            // 
            this.BTNSelectDir.Location = new System.Drawing.Point(27, 24);
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
            this.TBSelectedDir.Size = new System.Drawing.Size(813, 26);
            this.TBSelectedDir.TabIndex = 3;
            // 
            // BTNTotals
            // 
            this.BTNTotals.Location = new System.Drawing.Point(27, 62);
            this.BTNTotals.Name = "BTNTotals";
            this.BTNTotals.Size = new System.Drawing.Size(180, 64);
            this.BTNTotals.TabIndex = 5;
            this.BTNTotals.Text = "Calculate Total Antipatterns";
            this.BTNTotals.UseVisualStyleBackColor = true;
            this.BTNTotals.Click += new System.EventHandler(this.BTNTotals_Click);
            // 
            // BTNCreateClasses
            // 
            this.BTNCreateClasses.Location = new System.Drawing.Point(27, 175);
            this.BTNCreateClasses.Name = "BTNCreateClasses";
            this.BTNCreateClasses.Size = new System.Drawing.Size(180, 35);
            this.BTNCreateClasses.TabIndex = 8;
            this.BTNCreateClasses.Text = "Create Classes";
            this.BTNCreateClasses.UseVisualStyleBackColor = true;
            this.BTNCreateClasses.Click += new System.EventHandler(this.BTNCreateClasses_Click);
            // 
            // BTNPrint
            // 
            this.BTNPrint.Location = new System.Drawing.Point(27, 337);
            this.BTNPrint.Name = "BTNPrint";
            this.BTNPrint.Size = new System.Drawing.Size(180, 38);
            this.BTNPrint.TabIndex = 9;
            this.BTNPrint.Text = "Print Classes";
            this.BTNPrint.UseVisualStyleBackColor = true;
            this.BTNPrint.Click += new System.EventHandler(this.BTNPrint_Click);
            // 
            // BTNAddRoles
            // 
            this.BTNAddRoles.Location = new System.Drawing.Point(27, 488);
            this.BTNAddRoles.Name = "BTNAddRoles";
            this.BTNAddRoles.Size = new System.Drawing.Size(180, 35);
            this.BTNAddRoles.TabIndex = 10;
            this.BTNAddRoles.Text = "Add Role to Classes";
            this.BTNAddRoles.UseVisualStyleBackColor = true;
            this.BTNAddRoles.Click += new System.EventHandler(this.BTNAddRoles_Click);
            // 
            // BTNPrintRoles
            // 
            this.BTNPrintRoles.Location = new System.Drawing.Point(27, 566);
            this.BTNPrintRoles.Name = "BTNPrintRoles";
            this.BTNPrintRoles.Size = new System.Drawing.Size(180, 35);
            this.BTNPrintRoles.TabIndex = 11;
            this.BTNPrintRoles.Text = "Print Roles";
            this.BTNPrintRoles.UseVisualStyleBackColor = true;
            this.BTNPrintRoles.Click += new System.EventHandler(this.BTNPrintRoles_Click);
            // 
            // LabelCalcTotalAntipattern
            // 
            this.LabelCalcTotalAntipattern.Location = new System.Drawing.Point(213, 72);
            this.LabelCalcTotalAntipattern.Name = "LabelCalcTotalAntipattern";
            this.LabelCalcTotalAntipattern.Size = new System.Drawing.Size(266, 42);
            this.LabelCalcTotalAntipattern.TabIndex = 12;
            this.LabelCalcTotalAntipattern.Text = "Selected directory should contain .ini files or subfolders with .ini files.";
            // 
            // LabelCreateClasses
            // 
            this.LabelCreateClasses.Location = new System.Drawing.Point(213, 162);
            this.LabelCreateClasses.Name = "LabelCreateClasses";
            this.LabelCreateClasses.Size = new System.Drawing.Size(266, 64);
            this.LabelCreateClasses.TabIndex = 13;
            this.LabelCreateClasses.Text = "Selected directory should be the project folder. It will iterate through all subf" +
    "olders and look for .java files.";
            // 
            // LabelTip1
            // 
            this.LabelTip1.Location = new System.Drawing.Point(831, 56);
            this.LabelTip1.Name = "LabelTip1";
            this.LabelTip1.Size = new System.Drawing.Size(195, 48);
            this.LabelTip1.TabIndex = 14;
            this.LabelTip1.Text = "Check the output terminal for results.";
            // 
            // LabelAddAntipatterns
            // 
            this.LabelAddAntipatterns.Location = new System.Drawing.Point(213, 249);
            this.LabelAddAntipatterns.Name = "LabelAddAntipatterns";
            this.LabelAddAntipatterns.Size = new System.Drawing.Size(303, 64);
            this.LabelAddAntipatterns.TabIndex = 15;
            this.LabelAddAntipatterns.Text = "Classes need to be created first. Select the directory for a specific project ver" +
    "sion containing .ini files.";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(522, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 64);
            this.label1.TabIndex = 16;
            this.label1.Text = "Click to add antipatterns to each class for a specific project version. (Do this " +
    "for all versions of each project).";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(213, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 64);
            this.label2.TabIndex = 17;
            this.label2.Text = "Insert data printed to terminal into a sheet/excel file.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1063, 667);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelAddAntipatterns);
            this.Controls.Add(this.LabelTip1);
            this.Controls.Add(this.LabelCreateClasses);
            this.Controls.Add(this.LabelCalcTotalAntipattern);
            this.Controls.Add(this.BTNPrintRoles);
            this.Controls.Add(this.BTNAddRoles);
            this.Controls.Add(this.BTNPrint);
            this.Controls.Add(this.BTNCreateClasses);
            this.Controls.Add(this.BTNTotals);
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
        private System.Windows.Forms.Button BTNTotals;
        private System.Windows.Forms.Button BTNCreateClasses;
        private System.Windows.Forms.Button BTNPrint;
        private System.Windows.Forms.Button BTNAddRoles;
        private System.Windows.Forms.Button BTNPrintRoles;
        private System.Windows.Forms.Label LabelCalcTotalAntipattern;
        private System.Windows.Forms.Label LabelCreateClasses;
        private System.Windows.Forms.Label LabelTip1;
        private System.Windows.Forms.Label LabelAddAntipatterns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

