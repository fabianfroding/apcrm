using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace APCRM
{
    public partial class MainForm : Form
    {
        private string selectedDir;
        private List<FileInfo> files;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BTNSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                selectedDir = fbd.SelectedPath;
                TBSelectedDir.Text = selectedDir;
                DirectoryInfo di = new DirectoryInfo(selectedDir);
                files = di.GetFiles("*.ini").ToList<FileInfo>();
                LBFiles.Items.Clear();
                LBFiles.BeginUpdate();
                foreach (FileInfo fi in files)
                {
                    LBFiles.Items.Add(fi);
                }
                LBFiles.EndUpdate();
            }
        }

        private void BTNTotals_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(selectedDir);
            foreach (FileInfo fi in files)
            {
                StreamReader sr = fi.OpenText();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("#----> Total:")) {
                        System.Diagnostics.Debug.WriteLine(line.Substring(13));
                    }
                }
                sr.Close();
            }
        }
    }
}
