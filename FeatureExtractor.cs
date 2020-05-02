using System.Collections.Generic;
using System.IO;

namespace APCRM
{
    static class FeatureExtractor
    {
        public static bool FilterJavaFiles(string inputPath)
        {
            List<FileInfo> javaFiles = GetAllJavaFilesInDirectory(inputPath);
            foreach (FileInfo fi in javaFiles)
            {
                File.Copy(fi.FullName, @"..\..\Resources\cri\sample\filter-out\" + fi.Name, true);
            }
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
