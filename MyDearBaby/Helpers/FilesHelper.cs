using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace MyDearBaby
{
    public static class FilesHelper
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

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
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            ValidateDariectoryAndFileExistance(filePath);

            try
            {
                string jsonString = File.ReadAllText(filePath);
                list = JsonConvert.DeserializeObject<List<T>>(jsonString);

                return list;
            }
            catch (Exception ex)
            {
                log.Error($"There are some problems with deserialization of file on file path {filePath} ", ex);
                throw ex;
            }
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
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            try
            {
                ValidateDariectoryAndFileExistance(filePath);

                string serializedList = JsonConvert.SerializeObject(list, Formatting.Indented);
                File.WriteAllText(filePath, serializedList);
            }
            catch (Exception ex)
            {
                log.Error($"There are some problems with serialization of file on file path {filePath} ", ex);
            }
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
        public static string FilePathToMyDesktop(string filename)
        {
            string myDocumentsFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string programName = "MyDearChild";
            string enjoymentsFilePath = Path.Combine(myDocumentsFilePath, programName, filename);

            return enjoymentsFilePath;
        }

        public static void ValidateDariectoryAndFileExistance(string filePath)
        {
            try
            {
                log.Debug($"Validating if directory {filePath} exists.");
                if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                {
                    log.Debug($"Directory do not exists. Creating new directory {filePath}");
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }
            }
            catch (Exception ex)
            {
                log.Error($"There are some problems with directory creation {filePath}", ex);
            }

            try
            {
                log.Debug($"Validating if file {filePath} exists.");
                if (!File.Exists(filePath))
                {
                    log.Debug($"File do not exists. Creating new file {filePath}");
                    File.WriteAllText(filePath, "[]");
                }
            }
            catch (Exception ex)
            {

                log.Error($"There are some problems with file creation {filePath}", ex);
            }   
        }

        public static void SaveEnjoymentsFromRichTextBoxToTXTFile(RichTextBox richTextBox)
        {
            try
            {
                log.Debug($"Validating if directory {FilesHelper.FilePathToMyDesktop(FilesNames.enjoymentsTxt)} exists.");
                if (!Directory.Exists(Path.GetDirectoryName(FilesHelper.FilePathToMyDesktop(FilesNames.enjoymentsTxt))))
                {
                    log.Debug($"Directory do not exists. Creating new directory {FilesHelper.FilePathToMyDesktop(FilesNames.enjoymentsTxt)}");
                    Directory.CreateDirectory(Path.GetDirectoryName(FilesHelper.FilePathToMyDesktop(FilesNames.enjoymentsTxt)));
                }
            }
            catch (Exception ex)
            {
                log.Error($"There are some problems with directory creation {FilesHelper.FilePathToMyDesktop(FilesNames.enjoymentsTxt)}", ex);
            }

            try
            {
                log.Debug($"Validating if file {FilesHelper.FilePathToMyDesktop(FilesNames.enjoymentsTxt)} exists.");
                if (!File.Exists(FilesHelper.FilePathToMyDesktop(FilesNames.enjoymentsTxt)))
                {
                    string originalFileName = DateTime.Now.ToString("dd.MM.yyyy.HH.mm.ss") + FilesNames.enjoymentsTxt;
                    log.Debug($"File do not exists. Creating new file with original file name {FilesHelper.FilePathToMyDesktop(originalFileName)}");

                    using (StreamWriter writer = new StreamWriter(FilesHelper.FilePathToMyDesktop(originalFileName)))
                    {
                        writer.Write($"ZÁŽITKY <3 \nUložené {DateTime.Now.ToString("dd.MM.yyyy HH:mm")} \n");
                        writer.Write(richTextBox.Text);
                    }
                }
            }
            catch (Exception ex)
            {

                log.Error($"There are some problems with file creation {FilesHelper.FilePathToMyDesktop(FilesNames.enjoymentsTxt)}", ex);
            }
        }
    }
}
