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
            this.BTNClassify = new System.Windows.Forms.Button();
            this.BTNSelectClassifyFile = new System.Windows.Forms.Button();
            this.TextBoxClassifyFile = new System.Windows.Forms.TextBox();
            this.BTNVisualize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTip00
            // 
            this.LabelTip00.Location = new System.Drawing.Point(25, 204);
            this.LabelTip00.Name = "LabelTip00";
            this.LabelTip00.Size = new System.Drawing.Size(195, 48);
            this.LabelTip00.TabIndex = 14;
            this.LabelTip00.Text = "Check the output terminal for results.";
            // 
            // TBSelectedClassifiedCSV
            // 
            this.TBSelectedClassifiedCSV.Location = new System.Drawing.Point(237, 47);
            this.TBSelectedClassifiedCSV.Name = "TBSelectedClassifiedCSV";
            this.TBSelectedClassifiedCSV.ReadOnly = true;
            this.TBSelectedClassifiedCSV.Size = new System.Drawing.Size(879, 26);
            this.TBSelectedClassifiedCSV.TabIndex = 20;
            // 
            // TBSelectedIniDir
            // 
            this.TBSelectedIniDir.Location = new System.Drawing.Point(237, 15);
            this.TBSelectedIniDir.Name = "TBSelectedIniDir";
            this.TBSelectedIniDir.ReadOnly = true;
            this.TBSelectedIniDir.Size = new System.Drawing.Size(879, 26);
            this.TBSelectedIniDir.TabIndex = 21;
            // 
            // BTNSelectIniDir
            // 
            this.BTNSelectIniDir.Location = new System.Drawing.Point(12, 12);
            this.BTNSelectIniDir.Name = "BTNSelectIniDir";
            this.BTNSelectIniDir.Size = new System.Drawing.Size(219, 32);
            this.BTNSelectIniDir.TabIndex = 22;
            this.BTNSelectIniDir.Text = "Select .ini Dir";
            this.BTNSelectIniDir.UseVisualStyleBackColor = true;
            this.BTNSelectIniDir.Click += new System.EventHandler(this.BTNSelectIniDir_Click);
            // 
            // BTNSelectClassifiedCSV
            // 
            this.BTNSelectClassifiedCSV.Location = new System.Drawing.Point(12, 47);
            this.BTNSelectClassifiedCSV.Name = "BTNSelectClassifiedCSV";
            this.BTNSelectClassifiedCSV.Size = new System.Drawing.Size(219, 32);
            this.BTNSelectClassifiedCSV.TabIndex = 23;
            this.BTNSelectClassifiedCSV.Text = "Select Classified CSV";
            this.BTNSelectClassifiedCSV.UseVisualStyleBackColor = true;
            this.BTNSelectClassifiedCSV.Click += new System.EventHandler(this.BTNSelectClassifiedCSV_Click);
            // 
            // BTNFindAPsInRoles
            // 
            this.BTNFindAPsInRoles.Location = new System.Drawing.Point(12, 159);
            this.BTNFindAPsInRoles.Name = "BTNFindAPsInRoles";
            this.BTNFindAPsInRoles.Size = new System.Drawing.Size(219, 32);
            this.BTNFindAPsInRoles.TabIndex = 24;
            this.BTNFindAPsInRoles.Text = "Find Antipatterns in Roles";
            this.BTNFindAPsInRoles.UseVisualStyleBackColor = true;
            this.BTNFindAPsInRoles.Click += new System.EventHandler(this.BTNFindAPsInRoles_Click);
            // 
            // BTNFindRoles
            // 
            this.BTNFindRoles.Location = new System.Drawing.Point(12, 121);
            this.BTNFindRoles.Name = "BTNFindRoles";
            this.BTNFindRoles.Size = new System.Drawing.Size(219, 32);
            this.BTNFindRoles.TabIndex = 25;
            this.BTNFindRoles.Text = "Find Roles";
            this.BTNFindRoles.UseVisualStyleBackColor = true;
            this.BTNFindRoles.Click += new System.EventHandler(this.BTNFindRoles_Click);
            // 
            // LabelTip02
            // 
            this.LabelTip02.Location = new System.Drawing.Point(237, 127);
            this.LabelTip02.Name = "LabelTip02";
            this.LabelTip02.Size = new System.Drawing.Size(304, 23);
            this.LabelTip02.TabIndex = 26;
            this.LabelTip02.Text = "Requires selected csv file.";
            // 
            // LabelTip03
            // 
            this.LabelTip03.Location = new System.Drawing.Point(233, 165);
            this.LabelTip03.Name = "LabelTip03";
            this.LabelTip03.Size = new System.Drawing.Size(304, 23);
            this.LabelTip03.TabIndex = 27;
            this.LabelTip03.Text = "Requires selected .ini dir and csv file.";
            // 
            // BTNFindTotalAPs
            // 
            this.BTNFindTotalAPs.Location = new System.Drawing.Point(12, 85);
            this.BTNFindTotalAPs.Name = "BTNFindTotalAPs";
            this.BTNFindTotalAPs.Size = new System.Drawing.Size(219, 32);
            this.BTNFindTotalAPs.TabIndex = 28;
            this.BTNFindTotalAPs.Text = "Find Total Antipatterns";
            this.BTNFindTotalAPs.UseVisualStyleBackColor = true;
            this.BTNFindTotalAPs.Click += new System.EventHandler(this.BTNFindTotalAPs_Click);
            // 
            // LabelTip01
            // 
            this.LabelTip01.Location = new System.Drawing.Point(237, 89);
            this.LabelTip01.Name = "LabelTip01";
            this.LabelTip01.Size = new System.Drawing.Size(304, 23);
            this.LabelTip01.TabIndex = 29;
            this.LabelTip01.Text = "Requires selected .ini dir.";
            // 
            // BTNClassify
            // 
            this.BTNClassify.Location = new System.Drawing.Point(12, 408);
            this.BTNClassify.Name = "BTNClassify";
            this.BTNClassify.Size = new System.Drawing.Size(125, 31);
            this.BTNClassify.TabIndex = 30;
            this.BTNClassify.Text = "Classify";
            this.BTNClassify.UseVisualStyleBackColor = true;
            this.BTNClassify.Click += new System.EventHandler(this.BTNClassify_Click);
            // 
            // BTNSelectClassifyFile
            // 
            this.BTNSelectClassifyFile.Location = new System.Drawing.Point(12, 370);
            this.BTNSelectClassifyFile.Name = "BTNSelectClassifyFile";
            this.BTNSelectClassifyFile.Size = new System.Drawing.Size(41, 32);
            this.BTNSelectClassifyFile.TabIndex = 32;
            this.BTNSelectClassifyFile.Text = "...";
            this.BTNSelectClassifyFile.UseVisualStyleBackColor = true;
            this.BTNSelectClassifyFile.Click += new System.EventHandler(this.BTNSelectClassifyFile_Click);
            // 
            // TextBoxClassifyFile
            // 
            this.TextBoxClassifyFile.Location = new System.Drawing.Point(59, 373);
            this.TextBoxClassifyFile.Name = "TextBoxClassifyFile";
            this.TextBoxClassifyFile.ReadOnly = true;
            this.TextBoxClassifyFile.Size = new System.Drawing.Size(879, 26);
            this.TextBoxClassifyFile.TabIndex = 31;
            // 
            // BTNVisualize
            // 
            this.BTNVisualize.Location = new System.Drawing.Point(12, 445);
            this.BTNVisualize.Name = "BTNVisualize";
            this.BTNVisualize.Size = new System.Drawing.Size(125, 32);
            this.BTNVisualize.TabIndex = 33;
            this.BTNVisualize.Text = "Visualize";
            this.BTNVisualize.UseVisualStyleBackColor = true;
            this.BTNVisualize.Click += new System.EventHandler(this.BTNVisualize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1198, 677);
            this.Controls.Add(this.BTNVisualize);
            this.Controls.Add(this.BTNSelectClassifyFile);
            this.Controls.Add(this.TextBoxClassifyFile);
            this.Controls.Add(this.BTNClassify);
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
        private System.Windows.Forms.Button BTNClassify;
        private System.Windows.Forms.Button BTNSelectClassifyFile;
        private System.Windows.Forms.TextBox TextBoxClassifyFile;
        private System.Windows.Forms.Button BTNVisualize;
    }
}

