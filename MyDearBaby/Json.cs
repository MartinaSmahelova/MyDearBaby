using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyDearBaby
{
    public static class Json
    {
        public static readonly string _child = "child.json";
        public static readonly string _enjoymentsCategories = "enjoyments.json";
        public static readonly string _enjoyments = "zážitky.txt";

        public static List<T> DeserializeJsonFile<T>(List<T> list, string filePath)
        {
            ValidateDariectoryAndFileExistance(filePath);

            string jsonString = File.ReadAllText(filePath);
            list = JsonConvert.DeserializeObject<List<T>>(jsonString);

            return list;
        }

        public static void SerializeJsonFile<T>(List<T> list, string filePath)
        {
            ValidateDariectoryAndFileExistance(filePath);

            string serializedList = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(filePath, serializedList);
        }

        public static string FilePathinAppDataFolder(string fileName)
        {
            string folderApplicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string programName = "MyDearChild";
            string childFilePath = Path.Combine(folderApplicationDataPath, programName, fileName);

            return childFilePath;
        }

        public static string FilePathInMyDocFolder(string filename)
        {
            string myDocumentsFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string programName = "MyDearChild";
            string enjoymentsFilePath = Path.Combine(myDocumentsFilePath, programName, filename);

            return enjoymentsFilePath;
        }

        public static void ValidateDariectoryAndFileExistance(string filePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }
        }
    }
}
