using System.Diagnostics;
using System.IO;

namespace APCRM
{
    static class ClassRoleIdentifier
    {

        public static bool Classify()
        {
            string inputFileName = "temp.csv";
            string outputFileName = "temp-classified.csv";

            string[] commands = new string[2]
            {
                "conda activate base",
                @"python classifier.py models\rf-smote-k9-model-0202.sav sample\" + inputFileName + @" sample\" + outputFileName
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

            sw.Close();
            process.WaitForExit();

            return true;
        }
    }
}
