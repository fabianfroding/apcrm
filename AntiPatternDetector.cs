using APCRM.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

// Handles the detection of anti-patterns.
// Consider executing Ptidej, or implement the detection algorithms in Ptidej.

namespace APCRM
{
    static class AntiPatternDetector
    {
        public static readonly string[] ANTIPATTERNS = new string[18]
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



        //=============== Old ===============//
        public static void FindTotalAntipatterns(string dir)
        {
            Debug.WriteLine("//===== In respective order =====//");
            foreach (string ap in AntiPatternDetector.ANTIPATTERNS)
            {
                Debug.WriteLine(ap);
            }

            DirectoryInfo di = new DirectoryInfo(dir);
            FileInfo[] files = di.GetFiles("*.ini");
            for (int i = 0; i < files.Length; i++)
            {
                StreamReader sr = files[i].OpenText();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("#----> Total:"))
                    {
                        Debug.WriteLine(line.Substring(13));
                    }
                }
                sr.Close();
            }
        }

        public static void FindTotalAntipatternsInSubDirectories(string dir)
        {
            DirectoryInfo selectedDir = new DirectoryInfo(dir);
            DirectoryInfo[] subDirs = selectedDir.GetDirectories();

            Debug.WriteLine("//===== In respective order =====//");
            foreach (string ap in AntiPatternDetector.ANTIPATTERNS)
            {
                Debug.WriteLine(ap);
            }

            for (int i = 0; i < subDirs.Length; i++)
            {
                Debug.WriteLine(subDirs[i].Name);
                FileInfo[] files = subDirs[i].GetFiles("*.ini");
                for (int j = 0; j < files.Length; j++)
                {
                    StreamReader sr = files[j].OpenText();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("#----> Total:"))
                        {
                            Debug.WriteLine(line.Substring(13));
                        }
                    }
                    sr.Close();
                }
            }
        }

        public static List<JavaClass> AttachAntipatternsToJavaClasses(string dir, List<JavaClass> javaClasses)
        {
            //===== Attach antipatterns to each class =====//
            DirectoryInfo di = new DirectoryInfo(dir);
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
                        foreach (string s in AntiPatternDetector.ANTIPATTERNS)
                        {
                            if (fi.Name.Contains(s))
                            {
                                jc.aps.Add(s);
                            }
                        }
                    }
                }
            }
            return javaClasses;
        }
    
        public static List<JavaClass> AttachAntipatternsToJavaClassesFullPath(string dir, List<JavaClass> javaClasses)
        {
            //===== Attach antipatterns to each class =====//
            DirectoryInfo di = new DirectoryInfo(dir);
            FileInfo[] files = di.GetFiles("*.ini");
            int counter = 0;
            foreach (JavaClass jc in javaClasses)
            {
                counter++;
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
                    List<string> lastSubStrings = new List<string>();
                    foreach (string line in textLines.Where(l => l.Contains(jc.shortName) && l.Contains("-0")))
                    {
                        if (!line.Contains("MultipleInterface-0."))
                        {
                            string foundString = line.Split('=').Last();
                            foundString = foundString.Trim();
                            lastSubStrings.Add(foundString);
                        }
                    }
                    foreach (string lastSubString in lastSubStrings.Where(s => jc.name.EndsWith(s)))
                    {
                        foreach (string s in AntiPatternDetector.ANTIPATTERNS)
                        {
                            if (fi.Name.Contains(s))
                            {
                                jc.aps.Add(s);
                            }
                        }
                    }
                }
            }
            return javaClasses;
        }
    }
}
