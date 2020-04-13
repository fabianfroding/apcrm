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
            this.LabelTip00 = new System.Windows.Forms.Label();
            this.TBSelectedClassifiedCSV = new System.Windows.Forms.TextBox();
            this.TBSelectedIniDir = new System.Windows.Forms.TextBox();
            this.BTNSelectIniDir = new System.Windows.Forms.Button();
            this.BTNSelectClassifiedCSV = new System.Windows.Forms.Button();
            this.BTNFindAPsInRoles = new System.Windows.Forms.Button();
            this.BTNFindRoles = new System.Windows.Forms.Button();
            this.LabelTip02 = new System.Windows.Forms.Label();
            this.LabelTip03 = new System.Windows.Forms.Label();
            this.BTNFindTotalAPs = new System.Windows.Forms.Button();
            this.LabelTip01 = new System.Windows.Forms.Label();
            this.BTNSelectCSVDir = new System.Windows.Forms.Button();
            this.TBSelectedCSVDir = new System.Windows.Forms.TextBox();
            this.BTNFindChangesInRole = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelTip00
            // 
            this.LabelTip00.Location = new System.Drawing.Point(5, 188);
            this.LabelTip00.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTip00.Name = "LabelTip00";
            this.LabelTip00.Size = new System.Drawing.Size(130, 31);
            this.LabelTip00.TabIndex = 14;
            this.LabelTip00.Text = "Check the output terminal for results.";
            // 
            // TBSelectedClassifiedCSV
            // 
            this.TBSelectedClassifiedCSV.Location = new System.Drawing.Point(158, 34);
            this.TBSelectedClassifiedCSV.Margin = new System.Windows.Forms.Padding(2);
            this.TBSelectedClassifiedCSV.Name = "TBSelectedClassifiedCSV";
            this.TBSelectedClassifiedCSV.ReadOnly = true;
            this.TBSelectedClassifiedCSV.Size = new System.Drawing.Size(587, 20);
            this.TBSelectedClassifiedCSV.TabIndex = 20;
            // 
            // TBSelectedIniDir
            // 
            this.TBSelectedIniDir.Location = new System.Drawing.Point(158, 10);
            this.TBSelectedIniDir.Margin = new System.Windows.Forms.Padding(2);
            this.TBSelectedIniDir.Name = "TBSelectedIniDir";
            this.TBSelectedIniDir.ReadOnly = true;
            this.TBSelectedIniDir.Size = new System.Drawing.Size(587, 20);
            this.TBSelectedIniDir.TabIndex = 21;
            // 
            // BTNSelectIniDir
            // 
            this.BTNSelectIniDir.Location = new System.Drawing.Point(8, 8);
            this.BTNSelectIniDir.Margin = new System.Windows.Forms.Padding(2);
            this.BTNSelectIniDir.Name = "BTNSelectIniDir";
            this.BTNSelectIniDir.Size = new System.Drawing.Size(146, 21);
            this.BTNSelectIniDir.TabIndex = 22;
            this.BTNSelectIniDir.Text = "Select .ini Dir";
            this.BTNSelectIniDir.UseVisualStyleBackColor = true;
            this.BTNSelectIniDir.Click += new System.EventHandler(this.BTNSelectIniDir_Click);
            // 
            // BTNSelectClassifiedCSV
            // 
            this.BTNSelectClassifiedCSV.Location = new System.Drawing.Point(8, 31);
            this.BTNSelectClassifiedCSV.Margin = new System.Windows.Forms.Padding(2);
            this.BTNSelectClassifiedCSV.Name = "BTNSelectClassifiedCSV";
            this.BTNSelectClassifiedCSV.Size = new System.Drawing.Size(146, 21);
            this.BTNSelectClassifiedCSV.TabIndex = 23;
            this.BTNSelectClassifiedCSV.Text = "Select Classified CSV";
            this.BTNSelectClassifiedCSV.UseVisualStyleBackColor = true;
            this.BTNSelectClassifiedCSV.Click += new System.EventHandler(this.BTNSelectClassifiedCSV_Click);
            // 
            // BTNFindAPsInRoles
            // 
            this.BTNFindAPsInRoles.Location = new System.Drawing.Point(8, 131);
            this.BTNFindAPsInRoles.Margin = new System.Windows.Forms.Padding(2);
            this.BTNFindAPsInRoles.Name = "BTNFindAPsInRoles";
            this.BTNFindAPsInRoles.Size = new System.Drawing.Size(146, 21);
            this.BTNFindAPsInRoles.TabIndex = 24;
            this.BTNFindAPsInRoles.Text = "Find Antipatterns in Roles";
            this.BTNFindAPsInRoles.UseVisualStyleBackColor = true;
            this.BTNFindAPsInRoles.Click += new System.EventHandler(this.BTNFindAPsInRoles_Click);
            // 
            // BTNFindRoles
            // 
            this.BTNFindRoles.Location = new System.Drawing.Point(8, 106);
            this.BTNFindRoles.Margin = new System.Windows.Forms.Padding(2);
            this.BTNFindRoles.Name = "BTNFindRoles";
            this.BTNFindRoles.Size = new System.Drawing.Size(146, 21);
            this.BTNFindRoles.TabIndex = 25;
            this.BTNFindRoles.Text = "Find Roles";
            this.BTNFindRoles.UseVisualStyleBackColor = true;
            this.BTNFindRoles.Click += new System.EventHandler(this.BTNFindRoles_Click);
            // 
            // LabelTip02
            // 
            this.LabelTip02.Location = new System.Drawing.Point(158, 110);
            this.LabelTip02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTip02.Name = "LabelTip02";
            this.LabelTip02.Size = new System.Drawing.Size(203, 15);
            this.LabelTip02.TabIndex = 26;
            this.LabelTip02.Text = "Requires selected csv file.";
            // 
            // LabelTip03
            // 
            this.LabelTip03.Location = new System.Drawing.Point(158, 135);
            this.LabelTip03.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTip03.Name = "LabelTip03";
            this.LabelTip03.Size = new System.Drawing.Size(203, 15);
            this.LabelTip03.TabIndex = 27;
            this.LabelTip03.Text = "Requires selected .ini dir and csv file.";
            // 
            // BTNFindTotalAPs
            // 
            this.BTNFindTotalAPs.Location = new System.Drawing.Point(8, 81);
            this.BTNFindTotalAPs.Margin = new System.Windows.Forms.Padding(2);
            this.BTNFindTotalAPs.Name = "BTNFindTotalAPs";
            this.BTNFindTotalAPs.Size = new System.Drawing.Size(146, 21);
            this.BTNFindTotalAPs.TabIndex = 28;
            this.BTNFindTotalAPs.Text = "Find Total Antipatterns";
            this.BTNFindTotalAPs.UseVisualStyleBackColor = true;
            this.BTNFindTotalAPs.Click += new System.EventHandler(this.BTNFindTotalAPs_Click);
            // 
            // LabelTip01
            // 
            this.LabelTip01.Location = new System.Drawing.Point(158, 85);
            this.LabelTip01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTip01.Name = "LabelTip01";
            this.LabelTip01.Size = new System.Drawing.Size(203, 15);
            this.LabelTip01.TabIndex = 29;
            this.LabelTip01.Text = "Requires selected .ini dir.";
            // 
            // BTNSelectCSVDir
            // 
            this.BTNSelectCSVDir.Location = new System.Drawing.Point(8, 56);
            this.BTNSelectCSVDir.Margin = new System.Windows.Forms.Padding(2);
            this.BTNSelectCSVDir.Name = "BTNSelectCSVDir";
            this.BTNSelectCSVDir.Size = new System.Drawing.Size(146, 21);
            this.BTNSelectCSVDir.TabIndex = 30;
            this.BTNSelectCSVDir.Text = "Select .csv Dir";
            this.BTNSelectCSVDir.UseVisualStyleBackColor = true;
            this.BTNSelectCSVDir.Click += new System.EventHandler(this.BTNSelectCSVDir_Click);
            // 
            // TBSelectedCSVDir
            // 
            this.TBSelectedCSVDir.Location = new System.Drawing.Point(158, 57);
            this.TBSelectedCSVDir.Margin = new System.Windows.Forms.Padding(2);
            this.TBSelectedCSVDir.Name = "TBSelectedCSVDir";
            this.TBSelectedCSVDir.ReadOnly = true;
            this.TBSelectedCSVDir.Size = new System.Drawing.Size(587, 20);
            this.TBSelectedCSVDir.TabIndex = 31;
            // 
            // BTNFindChangesInRole
            // 
            this.BTNFindChangesInRole.Location = new System.Drawing.Point(8, 156);
            this.BTNFindChangesInRole.Margin = new System.Windows.Forms.Padding(2);
            this.BTNFindChangesInRole.Name = "BTNFindChangesInRole";
            this.BTNFindChangesInRole.Size = new System.Drawing.Size(146, 21);
            this.BTNFindChangesInRole.TabIndex = 32;
            this.BTNFindChangesInRole.Text = "Find Role Changes";
            this.BTNFindChangesInRole.UseVisualStyleBackColor = true;
            this.BTNFindChangesInRole.Click += new System.EventHandler(this.BTNFindChangesInRole_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(158, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Requires selected .csv dir.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(802, 228);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNFindChangesInRole);
            this.Controls.Add(this.TBSelectedCSVDir);
            this.Controls.Add(this.BTNSelectCSVDir);
            this.Controls.Add(this.LabelTip01);
            this.Controls.Add(this.BTNFindTotalAPs);
            this.Controls.Add(this.LabelTip03);
            this.Controls.Add(this.LabelTip02);
            this.Controls.Add(this.BTNFindRoles);
            this.Controls.Add(this.BTNFindAPsInRoles);
            this.Controls.Add(this.BTNSelectClassifiedCSV);
            this.Controls.Add(this.BTNSelectIniDir);
            this.Controls.Add(this.TBSelectedIniDir);
            this.Controls.Add(this.TBSelectedClassifiedCSV);
            this.Controls.Add(this.LabelTip00);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "APCRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelTip00;
        private System.Windows.Forms.TextBox TBSelectedClassifiedCSV;
        private System.Windows.Forms.TextBox TBSelectedIniDir;
        private System.Windows.Forms.Button BTNSelectIniDir;
        private System.Windows.Forms.Button BTNSelectClassifiedCSV;
        private System.Windows.Forms.Button BTNFindAPsInRoles;
        private System.Windows.Forms.Button BTNFindRoles;
        private System.Windows.Forms.Label LabelTip02;
        private System.Windows.Forms.Label LabelTip03;
        private System.Windows.Forms.Button BTNFindTotalAPs;
        private System.Windows.Forms.Label LabelTip01;
        private System.Windows.Forms.Button BTNSelectCSVDir;
        private System.Windows.Forms.TextBox TBSelectedCSVDir;
        private System.Windows.Forms.Button BTNFindChangesInRole;
        private System.Windows.Forms.Label label1;
    }
}

