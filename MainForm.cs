using APCRM.Models;
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
            CBAntipatterns.Items.Clear();
            CBAntipatterns.BeginUpdate();
            foreach (var ap in Enum.GetValues(typeof(Enums.Antipattern)))
            {
                CBAntipatterns.Items.Add(ap);
            }
            CBAntipatterns.EndUpdate();
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

        private void BTNCreateClasses_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(TBSelectedDir.Text);
            // Iterate through project and create list of JavaClass objects based on .java files.
            CheckDirectory(TBSelectedDir.Text);
        }

        private void CheckDirectory(string dir)
        {
            System.Diagnostics.Debug.WriteLine("1");
            DirectoryInfo di = new DirectoryInfo(dir);
            System.Diagnostics.Debug.WriteLine("2");
            List<DirectoryInfo> dirs = di.GetDirectories().ToList<DirectoryInfo>();
            System.Diagnostics.Debug.WriteLine("3");
            if (dirs.Count != 0)
            {
                System.Diagnostics.Debug.WriteLine("4");
                foreach (DirectoryInfo foundDir in dirs)
                {
                    CheckDirectory(foundDir.Name);
                    System.Diagnostics.Debug.WriteLine(foundDir.Name);
                }
            }
        }

        private void BTNListClassesInAntipattern(string dir, Enums.Antipattern antipattern)
        {
            // Iterate through dir to find .ini files that contains the name of the antipattern

            
            // Open the found ini file. For each class in the string list:
            // check if that class's name is in the .ini file. If it is, add that antipattern to the class's list of
            // antipatterns.
        }

    }
}
