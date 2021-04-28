using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyDearBaby
{
    public static class WorkWithFiles
    {
        public static List<Child> DeserializeChildFileJsonToListOfChildren(string childFilePath, List<Child> children)
        {
            if (!Directory.Exists(Path.GetDirectoryName(childFilePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(childFilePath));
            }

            if (!File.Exists(childFilePath))
            {
                File.WriteAllText(childFilePath, "[]");
            }

            string jsonString = File.ReadAllText(childFilePath);
            children = JsonConvert.DeserializeObject<List<Child>>(jsonString);

            return children;
        }

        public static void SerializeListOfChildrenToChildFileJonson(List<Child> listOfChildren, string childFilePath)
        {
            string listOfChildrenJson = JsonConvert.SerializeObject(listOfChildren, Formatting.Indented);
            File.WriteAllText(childFilePath, listOfChildrenJson);
        }

        public static string ChildFilePath()
        {
            string specialFolderApplicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string programName = "MyDearChild";
            string childFile = "child.json";
            string childFilePath = Path.Combine(specialFolderApplicationDataPath, programName, childFile);

            return childFilePath;
        }
    }
}
