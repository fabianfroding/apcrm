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
            this.BTNVisualize = new System.Windows.Forms.Button();
            this.BTNFeatExtract = new System.Windows.Forms.Button();
            this.BTNSelectFeatExtractDir = new System.Windows.Forms.Button();
            this.TextBoxFeatExtractDir = new System.Windows.Forms.TextBox();
            this.ComboBoxClassifier = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelTip00
            // 
            this.LabelTip00.Location = new System.Drawing.Point(23, 611);
            this.LabelTip00.Name = "LabelTip00";
            this.LabelTip00.Size = new System.Drawing.Size(195, 48);
            this.LabelTip00.TabIndex = 14;
            this.LabelTip00.Text = "Check the output terminal for results.";
            // 
            // TBSelectedClassifiedCSV
            // 
            this.TBSelectedClassifiedCSV.Location = new System.Drawing.Point(235, 454);
            this.TBSelectedClassifiedCSV.Name = "TBSelectedClassifiedCSV";
            this.TBSelectedClassifiedCSV.ReadOnly = true;
            this.TBSelectedClassifiedCSV.Size = new System.Drawing.Size(879, 26);
            this.TBSelectedClassifiedCSV.TabIndex = 20;
            // 
            // TBSelectedIniDir
            // 
            this.TBSelectedIniDir.Location = new System.Drawing.Point(235, 422);
            this.TBSelectedIniDir.Name = "TBSelectedIniDir";
            this.TBSelectedIniDir.ReadOnly = true;
            this.TBSelectedIniDir.Size = new System.Drawing.Size(879, 26);
            this.TBSelectedIniDir.TabIndex = 21;
            // 
            // BTNSelectIniDir
            // 
            this.BTNSelectIniDir.Location = new System.Drawing.Point(10, 419);
            this.BTNSelectIniDir.Name = "BTNSelectIniDir";
            this.BTNSelectIniDir.Size = new System.Drawing.Size(219, 32);
            this.BTNSelectIniDir.TabIndex = 22;
            this.BTNSelectIniDir.Text = "Select .ini Dir";
            this.BTNSelectIniDir.UseVisualStyleBackColor = true;
            this.BTNSelectIniDir.Click += new System.EventHandler(this.BTNSelectIniDir_Click);
            // 
            // BTNSelectClassifiedCSV
            // 
            this.BTNSelectClassifiedCSV.Location = new System.Drawing.Point(10, 454);
            this.BTNSelectClassifiedCSV.Name = "BTNSelectClassifiedCSV";
            this.BTNSelectClassifiedCSV.Size = new System.Drawing.Size(219, 32);
            this.BTNSelectClassifiedCSV.TabIndex = 23;
            this.BTNSelectClassifiedCSV.Text = "Select Classified CSV";
            this.BTNSelectClassifiedCSV.UseVisualStyleBackColor = true;
            this.BTNSelectClassifiedCSV.Click += new System.EventHandler(this.BTNSelectClassifiedCSV_Click);
            // 
            // BTNFindAPsInRoles
            // 
            this.BTNFindAPsInRoles.Location = new System.Drawing.Point(10, 566);
            this.BTNFindAPsInRoles.Name = "BTNFindAPsInRoles";
            this.BTNFindAPsInRoles.Size = new System.Drawing.Size(219, 32);
            this.BTNFindAPsInRoles.TabIndex = 24;
            this.BTNFindAPsInRoles.Text = "Find Antipatterns in Roles";
            this.BTNFindAPsInRoles.UseVisualStyleBackColor = true;
            this.BTNFindAPsInRoles.Click += new System.EventHandler(this.BTNFindAPsInRoles_Click);
            // 
            // BTNFindRoles
            // 
            this.BTNFindRoles.Location = new System.Drawing.Point(10, 528);
            this.BTNFindRoles.Name = "BTNFindRoles";
            this.BTNFindRoles.Size = new System.Drawing.Size(219, 32);
            this.BTNFindRoles.TabIndex = 25;
            this.BTNFindRoles.Text = "Find Roles";
            this.BTNFindRoles.UseVisualStyleBackColor = true;
            this.BTNFindRoles.Click += new System.EventHandler(this.BTNFindRoles_Click);
            // 
            // LabelTip02
            // 
            this.LabelTip02.Location = new System.Drawing.Point(235, 534);
            this.LabelTip02.Name = "LabelTip02";
            this.LabelTip02.Size = new System.Drawing.Size(304, 23);
            this.LabelTip02.TabIndex = 26;
            this.LabelTip02.Text = "Requires selected csv file.";
            // 
            // LabelTip03
            // 
            this.LabelTip03.Location = new System.Drawing.Point(231, 572);
            this.LabelTip03.Name = "LabelTip03";
            this.LabelTip03.Size = new System.Drawing.Size(304, 23);
            this.LabelTip03.TabIndex = 27;
            this.LabelTip03.Text = "Requires selected .ini dir and csv file.";
            // 
            // BTNFindTotalAPs
            // 
            this.BTNFindTotalAPs.Location = new System.Drawing.Point(10, 492);
            this.BTNFindTotalAPs.Name = "BTNFindTotalAPs";
            this.BTNFindTotalAPs.Size = new System.Drawing.Size(219, 32);
            this.BTNFindTotalAPs.TabIndex = 28;
            this.BTNFindTotalAPs.Text = "Find Total Antipatterns";
            this.BTNFindTotalAPs.UseVisualStyleBackColor = true;
            this.BTNFindTotalAPs.Click += new System.EventHandler(this.BTNFindTotalAPs_Click);
            // 
            // LabelTip01
            // 
            this.LabelTip01.Location = new System.Drawing.Point(235, 496);
            this.LabelTip01.Name = "LabelTip01";
            this.LabelTip01.Size = new System.Drawing.Size(304, 23);
            this.LabelTip01.TabIndex = 29;
            this.LabelTip01.Text = "Requires selected .ini dir.";
            // 
            // BTNClassify
            // 
            this.BTNClassify.Location = new System.Drawing.Point(8, 12);
            this.BTNClassify.Name = "BTNClassify";
            this.BTNClassify.Size = new System.Drawing.Size(125, 31);
            this.BTNClassify.TabIndex = 30;
            this.BTNClassify.Text = "Classify";
            this.BTNClassify.UseVisualStyleBackColor = true;
            this.BTNClassify.Click += new System.EventHandler(this.BTNClassify_Click);
            // 
            // BTNVisualize
            // 
            this.BTNVisualize.Location = new System.Drawing.Point(8, 49);
            this.BTNVisualize.Name = "BTNVisualize";
            this.BTNVisualize.Size = new System.Drawing.Size(125, 32);
            this.BTNVisualize.TabIndex = 33;
            this.BTNVisualize.Text = "Visualize";
            this.BTNVisualize.UseVisualStyleBackColor = true;
            this.BTNVisualize.Click += new System.EventHandler(this.BTNVisualize_Click);
            // 
            // BTNFeatExtract
            // 
            this.BTNFeatExtract.Enabled = false;
            this.BTNFeatExtract.Location = new System.Drawing.Point(574, 49);
            this.BTNFeatExtract.Name = "BTNFeatExtract";
            this.BTNFeatExtract.Size = new System.Drawing.Size(203, 31);
            this.BTNFeatExtract.TabIndex = 34;
            this.BTNFeatExtract.Text = "Test Feature Extraction";
            this.BTNFeatExtract.UseVisualStyleBackColor = true;
            this.BTNFeatExtract.Click += new System.EventHandler(this.BTNFeatExtract_Click);
            // 
            // BTNSelectFeatExtractDir
            // 
            this.BTNSelectFeatExtractDir.Location = new System.Drawing.Point(573, 17);
            this.BTNSelectFeatExtractDir.Name = "BTNSelectFeatExtractDir";
            this.BTNSelectFeatExtractDir.Size = new System.Drawing.Size(41, 29);
            this.BTNSelectFeatExtractDir.TabIndex = 36;
            this.BTNSelectFeatExtractDir.Text = "...";
            this.BTNSelectFeatExtractDir.UseVisualStyleBackColor = true;
            this.BTNSelectFeatExtractDir.Click += new System.EventHandler(this.BTNSelectFeatExtractDir_Click);
            // 
            // TextBoxFeatExtractDir
            // 
            this.TextBoxFeatExtractDir.Location = new System.Drawing.Point(620, 17);
            this.TextBoxFeatExtractDir.Name = "TextBoxFeatExtractDir";
            this.TextBoxFeatExtractDir.ReadOnly = true;
            this.TextBoxFeatExtractDir.Size = new System.Drawing.Size(540, 26);
            this.TextBoxFeatExtractDir.TabIndex = 35;
            // 
            // ComboBoxClassifier
            // 
            this.ComboBoxClassifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxClassifier.FormattingEnabled = true;
            this.ComboBoxClassifier.Location = new System.Drawing.Point(139, 14);
            this.ComboBoxClassifier.Name = "ComboBoxClassifier";
            this.ComboBoxClassifier.Size = new System.Drawing.Size(330, 28);
            this.ComboBoxClassifier.TabIndex = 37;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1198, 677);
            this.Controls.Add(this.ComboBoxClassifier);
            this.Controls.Add(this.BTNSelectFeatExtractDir);
            this.Controls.Add(this.TextBoxFeatExtractDir);
            this.Controls.Add(this.BTNFeatExtract);
            this.Controls.Add(this.BTNVisualize);
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
        private System.Windows.Forms.Button BTNVisualize;
        private System.Windows.Forms.Button BTNFeatExtract;
        private System.Windows.Forms.Button BTNSelectFeatExtractDir;
        private System.Windows.Forms.TextBox TextBoxFeatExtractDir;
        private System.Windows.Forms.ComboBox ComboBoxClassifier;
    }
}

