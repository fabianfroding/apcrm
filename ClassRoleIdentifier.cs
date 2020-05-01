using APCRM.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

// Handles the execution of the CRI.
// Provides data of the classified project.

namespace APCRM
{
    static class ClassRoleIdentifier
    {
        public static readonly string[] ROLES = new string[6]
        {
            "Information Holder",
            "Structurer",
            "Service Provider",
            "Controller",
            "Coordinator",
            "Interfacer"
        };

        public static bool Classify(string inputFilePath)
        {
            File.Copy(new FileInfo(inputFilePath).FullName, @"..\..\Resources\cri\sample\temp.csv", true);
            string inputFileName = "temp.csv";
            string outputFileName = "temp-classified.csv";

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = new DirectoryInfo(@"..\..\Resources\cri").FullName,
                    WindowStyle = ProcessWindowStyle.Normal,
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    UseShellExecute = false
                }
            };
            process.Start();
            StreamWriter sw = process.StandardInput;

            sw.WriteLine("conda activate base");
            sw.WriteLine(@"python classifier.py models\rf-smote-k9-model-0202.sav sample\" + inputFileName + @" sample\" + outputFileName);

            sw.Close();
            process.WaitForExit();

            return true;
        }

        public static int[] GetNumberOfRoles(string filePath)
        {
            List<string> roles = new List<string>();
            using (var sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    roles.Add(sr.ReadLine().Split(',')[27]);
                }
            }

            int[] numRoles = new int[6];
            // 0=InformationHolder, 1=Structurer, 2=ServiceProvider,
            // 3=Controller, 4=Coordinator, 5=Interfacer
            int index = 0;

            foreach (string ROLE in ROLES)
            {
                foreach (string role in roles)
                {
                    if (ROLE == role)
                    {
                        numRoles[index]++;
                    }
                }
                index++;
            }

            return numRoles;
        }



        //=============== Old ===============//
        public static List<JavaClass> AttachRolesToJavaClasses(string filePath)
        {
            List<JavaClass> javaClasses = new List<JavaClass>();
            using (var sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    var values = sr.ReadLine().Split(',');
                    JavaClass jc = new JavaClass(values[2]);
                    jc.classRole = values[27];
                    javaClasses.Add(jc);
                }
            }
            return javaClasses;
        }
    }
}
