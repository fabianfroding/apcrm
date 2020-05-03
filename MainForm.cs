using APCRM.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace APCRM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BTNClassify_Click(object sender, EventArgs e)
        {
            if (ClassRoleIdentifier.Classify(TextBoxClassifyFile.Text))
            {
                MessageBox.Show("Classification successful.");
                BTNVisualize.Enabled = true;
            }
            else
            {
                MessageBox.Show("There was a problem running the class role identification.");
            }
        }

        private void BTNSelectClassifyFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files(*.csv)| *.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBoxClassifyFile.Text = ofd.FileName;
                BTNClassify.Enabled = true;
            }
        }

        private void BTNVisualize_Click(object sender, EventArgs e)
        {
            new GraphForm(ClassRoleIdentifier.GetNumberOfRoles(@"..\..\Resources\cri\sample\temp-classified.csv")).Show();
        }





        //=============== Old Stuff ===============//
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
            AntiPatternDetector.FindTotalAntipatterns(TBSelectedIniDir.Text);
        }

        // Link this method to Find Total Antipatterns button if you want to find .ini in sub directories
        // instead. Useful to get all data from the entire history of a project instead of doing it
        // manually for each version.
        private void BTNFindTotalAPsInSubDirs_Click(object sender, EventArgs e)
        {
            AntiPatternDetector.FindTotalAntipatternsInSubDirectories(TBSelectedIniDir.Text);
        }

        private void BTNFindRoles_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("//===== In respective order =====//");
            foreach (string r in ClassRoleIdentifier.ROLES)
            {
                Debug.WriteLine(r);
            }
            int[] numRoles = ClassRoleIdentifier.GetNumberOfRoles(TBSelectedClassifiedCSV.Text);
            for (int i = 0; i < numRoles.Length; i++)
            {
                Debug.WriteLine(numRoles[i]);
            }
        }

        private void BTNFindAPsInRoles_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Mapping roles to antipatterns...");

            List<JavaClass> javaClasses = ClassRoleIdentifier.AttachRolesToJavaClasses(TBSelectedClassifiedCSV.Text);
            javaClasses = AntiPatternDetector.AttachAntipatternsToJavaClasses(TBSelectedIniDir.Text, javaClasses);

            // For each role, find classes that has that role, add each antipattern to a counter...
            foreach (string role in ClassRoleIdentifier.ROLES)
            {
                Debug.WriteLine("//========== " + role + " ==========//");

                int[] numAntipatterns = new int[18];
                // 0=AntiSingleton, 1=BaseClassKnowsDerivedClass, 2=BaseClassShouldBeAbstract,
                // 3=Blob, 4=ClassDataShouldBePrivate, 5=ComplexClass,
                // 6=FunctionalDecomposition, 7=LargeClass, 8=LazyClass,
                // 9=LongMethod, 10=LongParameterList, 11=ManyFieldAttributesButNotComplex,
                // 12=MessageChains, 13=RefusedParentBequest, 14=SpaghettiCode,
                // 15=SpeculativeGenerality, 16=SwissArmyKnife, 17=TraditionBreaker
                int index = 0;

                foreach (string ap in AntiPatternDetector.ANTIPATTERNS)
                {
                    foreach (JavaClass jc in javaClasses)
                    {
                        if (jc.classRole == role && jc.aps.Contains(ap))
                        {
                            //Debug.WriteLine(jc.name + " contains " + ap);
                            //Debug.WriteLine("Adding 1 to " + AntiPatternDetector.ANTIPATTERNS[index]);
                            numAntipatterns[index]++;
                        }
                    }
                    index++;
                }

                Debug.WriteLine("//---------- In respective order ----------//");
                for (int i = 0; i < numAntipatterns.Length; i++)
                {
                    Debug.WriteLine(numAntipatterns[i]);
                }
            }
            Debug.WriteLine("Done.\n");

        }



        //=============== Temp Test Feature Extraction ===============//
        private void BTNSelectFeatExtractDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TextBoxFeatExtractDir.Text = fbd.SelectedPath;
                BTNFeatExtract.Enabled = true;
            }
        }

        private void BTNFeatExtract_Click(object sender, EventArgs e)
        {
            if (FeatureExtractor.FilterJavaFiles(TextBoxFeatExtractDir.Text))
            {
                if (FeatureExtractor.CreateSrcMLRepresentationOfJavaFiles())
                {
                    MessageBox.Show("Feature Extraction done.");
                }
                else
                {
                    MessageBox.Show("There was a problem creating a srcML-representation of the copied java files.");
                }
            }
            else
            {
                MessageBox.Show("There was a problem filtering the java files during the feature extraction process.");
            }
        }
    }

}
