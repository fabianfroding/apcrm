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
        private List<JavaClass> classes;

        public MainForm()
        {
            InitializeComponent();
            classes = new List<JavaClass>();
        }

        private void BTNSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TBSelectedDir.Text = fbd.SelectedPath;
            }
        }

        private void BTNTotals_Click(object sender, EventArgs e)
        {
            CheckDirectoriesForIniFiles(TBSelectedDir.Text);
        }

        private void CheckDirectoriesForIniFiles(string dir)
        {
            DirectoryInfo di = new DirectoryInfo(dir);
            System.Diagnostics.Debug.WriteLine("\n//===== " + di.Name + " =====/");

            FileInfo[] files = di.GetFiles("*.ini");
            for (int i = 0; i < files.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine(files[i].Name);
                StreamReader sr = files[i].OpenText();
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

            DirectoryInfo[] dirs = di.GetDirectories();
            for (int i = 0; i < dirs.Length; i++)
            {
                CheckDirectoriesForIniFiles(dirs[i].FullName);
            }
        }

        private void BTNCreateClasses_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(TBSelectedDir.Text);
            // Iterate through project and create list of JavaClass objects based on .java files.
            CheckDirectoryForJavaFiles(TBSelectedDir.Text);
        }

        private void CheckDirectoryForJavaFiles(string dir)
        {
            DirectoryInfo di = new DirectoryInfo(dir);
            System.Diagnostics.Debug.WriteLine("\n//===== " + di.Name + " =====/");

            FileInfo[] files = di.GetFiles("*.java");
            for (int i = 0; i < files.Length; i++)
            {
                string fileName = Path.GetFileNameWithoutExtension(files[i].FullName);
                classes.Add(new JavaClass(fileName));
                System.Diagnostics.Debug.WriteLine("Added class " + fileName);
            }

            DirectoryInfo[] dirs = di.GetDirectories();
            for (int i = 0; i < dirs.Length; i++)
            {
                CheckDirectoryForJavaFiles(dirs[i].FullName);
            }
        }

        private void BTNListAntiPatterns_Click(object sender, EventArgs e)
        {
            // Make sure selected dir is the one with the .ini files (for a specific versino).
            DirectoryInfo di = new DirectoryInfo(TBSelectedDir.Text);
            FileInfo[] files = di.GetFiles("*.ini");

            System.Diagnostics.Debug.WriteLine("Working...");
            foreach(JavaClass jc in classes)
            {
                foreach (FileInfo fi in files)
                {
                    StreamReader sr = fi.OpenText();
                    string text = sr.ReadToEnd();
                    sr.Close();
                    if(text.Contains(jc.name))
                    {
                        foreach(Enums.Antipattern ap in Enum.GetValues(typeof(Enums.Antipattern)))
                        {
                            if (fi.Name.Contains(ap.ToString()))
                            {
                                jc.antipatterns.Add(ap);
                            }
                        }
                        
                    }
                }
            }
            System.Diagnostics.Debug.WriteLine("Done.");
        }

        private void BTNPrint_Click(object sender, EventArgs e)
        {
            foreach(JavaClass jc in classes)
            {
                System.Diagnostics.Debug.WriteLine("//===== Antipatterns in " + jc.name + " =====/");
                foreach(Enums.Antipattern ap in jc.antipatterns)
                {
                    System.Diagnostics.Debug.WriteLine(ap.ToString());
                }
            }
        }

        private void BTNAddRoles_Click(object sender, EventArgs e)
        {
            // Parse role data. Insert the role to each class...

        }

        private void BTNPrintRoles_Click(object sender, EventArgs e)
        {
            foreach (JavaClass jc in classes)
            {
                jc.role = Enums.ClassRole.Controller; //Temp. Remove when we have role data.

                System.Diagnostics.Debug.WriteLine("//=====" + jc.role.ToString());
                foreach (Enums.Antipattern ap in jc.antipatterns)
                {
                    System.Diagnostics.Debug.WriteLine(ap.ToString());
                }
            }
        }
    }

}
