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

        public static bool Classify(string[] inputFilePaths)
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = new DirectoryInfo(@"..\..\Resources\cri").FullName,
                    CreateNoWindow = true,
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    UseShellExecute = false
                }
            };

            for (int i = 0; i < inputFilePaths.Length; i++)
            {
                process.Start();
                StreamWriter sw = process.StandardInput;
                sw.WriteLine("conda activate base");

                string inputFileName = new FileInfo(inputFilePaths[i]).Name;
                File.Copy(new FileInfo(inputFilePaths[i]).FullName, @"..\..\Resources\cri\sample\" + inputFileName, true);
                sw.WriteLine(@"python classifier.py models\rf-smote-three-cases-model-0202.sav sample\" + inputFileName + @" sample\" + inputFileName + "-classified.csv");
                
                sw.Close();
                process.WaitForExit();
                File.Delete(@"..\..\Resources\cri\sample\" + inputFileName);
            }

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
