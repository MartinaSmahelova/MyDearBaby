using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyDearBaby
{
    public static class WorkWithFiles
    {
        public static List<Child> DeserializeChildrenJsonFileToListOfChildren(List<Child> children)
        {
            if (!Directory.Exists(Path.GetDirectoryName(ChildrenFilePath())))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(ChildrenFilePath()));
            }

            if (!File.Exists(ChildrenFilePath()))
            {
                File.WriteAllText(ChildrenFilePath(), "[]");
            }

            string jsonString = File.ReadAllText(ChildrenFilePath());
            children = JsonConvert.DeserializeObject<List<Child>>(jsonString);

            return children;
        }

        public static void SerializeListOfChildrenToChildrenJsonFile(List<Child> listOfChildren)
        {
            string listOfChildrenJson = JsonConvert.SerializeObject(listOfChildren, Formatting.Indented);
            File.WriteAllText(ChildrenFilePath(), listOfChildrenJson);
        }

        public static string ChildrenFilePath()
        {
            string specialFolderApplicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string programName = "MyDearChild";
            string childFile = "children.json";
            string childFilePath = Path.Combine(specialFolderApplicationDataPath, programName, childFile);

            return childFilePath;
        }
    }
}
