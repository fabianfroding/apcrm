using APCRM.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;

namespace APCRM
{
    public partial class MainForm : Form
    {
        private static readonly string[] ANTIPATTERNS = new string[18]
        {
            "AntiSingleton",
            "BaseClassKnowsDerivedClass",
            "BaseClassShouldBeAbstract",
            "Blob",
            "ClassDataShouldBePrivate",
            "ComplexClass",
            "FunctionalDecomposition",
            "LargeClass",
            "LazyClass",
            "LongMethod",
            "LongParameterList",
            "ManyFieldAttributesButNotComplex",
            "MessageChains",
            "RefusedParentBequest",
            "SpaghettiCode",
            "SpeculativeGenerality",
            "SwissArmyKnife",
            "TraditionBreaker"
        };
        private static readonly string[] ROLES = new string[6]
        {
            "Information Holder",
            "Structurer",
            "Service Provider",
            "Controller",
            "Coordinator",
            "Interfacer"
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void BTNSelectIniDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TBSelectedIniDir.Text = fbd.SelectedPath;
            }
        }

        private void BTNSelectClassifiedCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "CSV Files(*.csv)| *.csv";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                TBSelectedClassifiedCSV.Text = fd.FileName;
            }
        }

        private void BTNFindTotalAPs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("//===== In respective order =====//");
            foreach (string ap in ANTIPATTERNS)
            {
                System.Diagnostics.Debug.WriteLine(ap);
            }

            DirectoryInfo di = new DirectoryInfo(TBSelectedIniDir.Text);
            FileInfo[] files = di.GetFiles("*.ini");
            for (int i = 0; i < files.Length; i++)
            {
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
        }

        // Link this method to Find Total Antipatterns button if you want to find .ini in sub directories
        // instead. Useful to get all data from the entire history of a project instead of doing it
        // manually for each version.
        private void BTNFindTotalAPsInSubDirs_Click(object sender, EventArgs e)
        {
            DirectoryInfo selectedDir = new DirectoryInfo(TBSelectedIniDir.Text);
            DirectoryInfo[] subDirs = selectedDir.GetDirectories();

            System.Diagnostics.Debug.WriteLine("//===== In respective order =====//");
            foreach (string ap in ANTIPATTERNS)
            {
                System.Diagnostics.Debug.WriteLine(ap);
            }

            for (int i = 0; i < subDirs.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine(subDirs[i].Name);
                FileInfo[] files = subDirs[i].GetFiles("*.ini");
                for (int j = 0; j < files.Length; j++)
                {
                    StreamReader sr = files[j].OpenText();
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

        private void BTNFindRoles_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("//===== In respective order =====//");
            foreach (string r in ROLES)
            {
                System.Diagnostics.Debug.WriteLine(r);
            }

            List<string> classes = new List<string>();
            List<string> roles = new List<string>();
            using (var sr = new StreamReader(TBSelectedClassifiedCSV.Text))
            {
                // For some reason it seems to skip the header line automatically. :)
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(',');

                    classes.Add(values[2]);
                    roles.Add(values[27]);
                }
            }

            int[] numRoles = new int[6];
            // 0=InformationHolder, 1=Structurer, 2=ServiceProvider,
            // 3=Controller, 4=Coordinator, 5=Interfacer
            int index = 0;

            foreach (string s in ROLES)
            {
                foreach (string role in roles)
                {
                    
                    if (s == role)
                    {
                        numRoles[index]++;
                    }
                }
                index++;
            }

            for (int i = 0; i < numRoles.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine(numRoles[i]);
            }
        }

        private void BTNFindAPsInRoles_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Mapping roles to antipatterns...");

            List<JavaClass> javaClasses = new List<JavaClass>();

            //===== Attach a role to each class =====//
            using (var sr = new StreamReader(TBSelectedClassifiedCSV.Text))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(',');

                    JavaClass jc = new JavaClass(values[2]);
                    jc.classRole = values[27];
                    javaClasses.Add(jc);
                }
            }

            //===== Attach antipatterns to each class =====//
            DirectoryInfo di = new DirectoryInfo(TBSelectedIniDir.Text);
            FileInfo[] files = di.GetFiles("*.ini");
            foreach (JavaClass jc in javaClasses)
            {
                foreach (FileInfo fi in files)
                {
                    StreamReader sr = fi.OpenText();
                    List<string> textLines = new List<string>();
                    using (sr)
                    {
                        while (!sr.EndOfStream)
                        {
                            textLines.Add(sr.ReadLine());
                        }
                    }
                    sr.Close();
                    string lastSubString = "";

                    foreach (string line in textLines.Where(l => l.Contains(jc.name) && l.Contains("-0")))
                    {
                        lastSubString = line.Split('.').Last();
                    }

                    if (lastSubString.Equals(jc.name))
                    {
                        foreach (string s in ANTIPATTERNS)
                        {
                            if (fi.Name.Contains(s))
                            {
                                jc.aps.Add(s);
                            }
                        }
                    }
                }
            }

            // For each role, find classes that has that role, add each antipattern to a counter...

            foreach (string role in ROLES)
            {
                System.Diagnostics.Debug.WriteLine("//========== " + role + " ==========//");

                int[] numAntipatterns = new int[18];
                // 0=AntiSingleton, 1=BaseClassKnowsDerivedClass, 2=BaseClassShouldBeAbstract,
                // 3=Blob, 4=ClassDataShouldBePrivate, 5=ComplexClass,
                // 6=FunctionalDecomposition, 7=LargeClass, 8=LazyClass,
                // 9=LongMethod, 10=LongParameterList, 11=ManyFieldAttributesButNotComplex,
                // 12=MessageChains, 13=RefusedParentBequest, 14=SpaghettiCode,
                // 15=SpeculativeGenerality, 16=SwissArmyKnife, 17=TraditionBreaker
                int index = 0;

                foreach (string ap in ANTIPATTERNS)
                {
                    foreach (JavaClass jc in javaClasses)
                    {
                        if (jc.classRole == role && jc.aps.Contains(ap))
                        {
                            //System.Diagnostics.Debug.WriteLine(jc.name + " contains " + ap);
                            //System.Diagnostics.Debug.WriteLine("Adding 1 to " + ANTIPATTERNS[index]);
                            numAntipatterns[index]++;
                        }
                    }
                    index++;
                }

                System.Diagnostics.Debug.WriteLine("//---------- In respective order ----------//");
                for (int i = 0; i < numAntipatterns.Length; i++)
                {
                    System.Diagnostics.Debug.WriteLine(numAntipatterns[i]);
                }
            }
            System.Diagnostics.Debug.WriteLine("Done.\n");

        }

        private void BTNClassify_Click(object sender, EventArgs e)
        {
            string[] commands = new string[2]
            {
                "conda activate base",
                @"python classifier.py models\rf-smote-k9-model-0202.sav sample\sample.csv sample\sample-classified.csv"
            };

            Process process = new Process();
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                WorkingDirectory = new DirectoryInfo(@"..\..\Resources\cri").FullName,
                WindowStyle = ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                UseShellExecute = false
            };

            process.StartInfo = processStartInfo;
            process.Start();
            StreamWriter sw = process.StandardInput;

            sw.WriteLine(commands[0]);
            sw.WriteLine(commands[1]);

            process.WaitForExit();
            sw.Close();

        }

    }

}
