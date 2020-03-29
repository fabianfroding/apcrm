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
            string selectedDir;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                selectedDir = fbd.SelectedPath;
                TBSelectedDir.Text = selectedDir;

                DirectoryInfo di = new DirectoryInfo(selectedDir);

                List<FileInfo> files = di.GetFiles("*.ini").ToList<FileInfo>();

                

                LBFiles.Items.Clear();
                LBFiles.BeginUpdate();
                foreach (FileInfo fi in files)
                {
                    LBFiles.Items.Add(fi);
                }
                LBFiles.EndUpdate();

                

                StreamReader sr = files[1].OpenText();

                string s = sr.ReadToEnd();

                System.Diagnostics.Debug.WriteLine(s);

                sr.Close();
            }
        }
    }
}
