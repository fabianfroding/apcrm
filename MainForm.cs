using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace APCRM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BTNSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TBSelectedDir.Text = fbd.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(TBSelectedDir.Text);
                List<FileInfo> files = di.GetFiles("*.ini").ToList<FileInfo>();
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
            DirectoryInfo di = new DirectoryInfo(TBSelectedDir.Text);
            DirectoryInfo[] dirs = di.GetDirectories();
            for (int i = 0; i < dirs.Length; i++)
            {
                List<FileInfo> files = dirs[i].GetFiles("*.ini").ToList<FileInfo>();
                System.Diagnostics.Debug.WriteLine(dirs[i].Name);
                foreach (FileInfo fi in files)
                {
                    StreamReader sr = fi.OpenText();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("#----> Total:"))
                        {
                            System.Diagnostics.Debug.WriteLine(line.Substring(13));
                        }
                    }
                    sr.Close();
                }
            }


            
        }
    }
}
