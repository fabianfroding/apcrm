using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace APCRM
{
    static class FeatureExtractor
    {
        private static readonly string PATH_TO_COPIED_JAVA_FILES = @"..\..\Resources\cri\sample\filter-out\";

        public static bool FilterJavaFiles(string inputPath)
        {
            List<FileInfo> javaFiles = GetAllJavaFilesInDirectory(inputPath);
            foreach (FileInfo fi in javaFiles)
            {
                File.Copy(fi.FullName, PATH_TO_COPIED_JAVA_FILES + fi.Name, true);
            }
            return true;
        }

        public static bool CreateSrcMLRepresentationOfJavaFiles()
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = new DirectoryInfo(@"..\..\Resources\srcML0.9.5\bin").FullName,
                    WindowStyle = ProcessWindowStyle.Normal,
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    UseShellExecute = false
                }
            };
            process.Start();

            StreamWriter sw = process.StandardInput;
            sw.WriteLine("srcml.exe " + new DirectoryInfo(PATH_TO_COPIED_JAVA_FILES).FullName + " -o " + new DirectoryInfo(@"..\..\Resources\cri\sample\srcml-out\").FullName + "temp.xml");
            sw.Close();

            process.WaitForExit();
            return true;
        }

        //=============== Private Methods ===============//
        private static List<FileInfo> GetAllJavaFilesInDirectory(string directoryPath)
        {
            DirectoryInfo di = new DirectoryInfo(directoryPath);
            List<FileInfo> javaFiles = new List<FileInfo>();

            foreach (FileInfo fi in di.GetFiles())
            {
                if (fi.Name.EndsWith(".java"))
                {
                    javaFiles.Add(fi);
                }
            }
            foreach (DirectoryInfo _di in di.GetDirectories())
            {
                javaFiles.AddRange(GetAllJavaFilesInDirectory(_di.FullName));
            }

            return javaFiles;
            
        }
    }

}
