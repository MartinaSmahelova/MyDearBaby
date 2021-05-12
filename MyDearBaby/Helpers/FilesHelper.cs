using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MyDearBaby
{
    public static class FilesHelper
    {
        /// <summary>
        /// Validate if directory and file exist. If no create them. 
        /// If yes deserialize file to list.  
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">List to deserialize</param>
        /// <param name="filePath">Directory where is file for deserialization</param>
        /// <returns></returns>
        public static List<T> DeserializeJsonFileToList<T>(List<T> list, string filePath)
        {
            ValidateDariectoryAndFileExistance(filePath);

            string jsonString = File.ReadAllText(filePath);
            list = JsonConvert.DeserializeObject<List<T>>(jsonString);

            return list;
        }

        /// <summary>
        /// Validate if directory and file exist. If no create them. 
        /// If yes serialize list to file. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">List to serialize</param>
        /// <param name="filePath">Directory where to put serialized file</param>
        public static void SerializeListToJsonFile<T>(List<T> list, string filePath)
        {
            ValidateDariectoryAndFileExistance(filePath);

            string serializedList = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(filePath, serializedList);
        }

        /// <summary>
        /// File path to App Data folder, to storage application information which are not directly for user. 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string FilePathToAppDataFolder(string fileName)
        {
            string folderApplicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string programName = "MyDearChild";
            string childFilePath = Path.Combine(folderApplicationDataPath, programName, fileName);

            return childFilePath;
        }

        /// <summary>
        /// File path to Desktop to storage information for user. 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static string FilePathTonMyDesktop(string filename)
        {
            string myDocumentsFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
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

        public static void SaveEnjoymentsFromRichTextBoxToTXTFile(RichTextBox richTextBox)
        {
            if (!Directory.Exists(Path.GetDirectoryName(FilesHelper.FilePathTonMyDesktop(FilesNames.enjoymentsTxt))))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(FilesHelper.FilePathTonMyDesktop(FilesNames.enjoymentsTxt)));
            }

            if (!File.Exists(FilesHelper.FilePathTonMyDesktop(FilesNames.enjoymentsTxt)))
            {
                string originalFieName = DateTime.Now.ToString("dd.MM.yyyy.HH.mm.ss") + FilesNames.enjoymentsTxt;
                using (StreamWriter writer = new StreamWriter(FilesHelper.FilePathTonMyDesktop(originalFieName)))
                {
                    writer.Write($"ZÁŽITKY <3 \nUložené {DateTime.Now.ToString("dd.MM.yyyy HH:mm")} \n");
                    writer.Write(richTextBox.Text);
                }
            }
        }
    }
}
