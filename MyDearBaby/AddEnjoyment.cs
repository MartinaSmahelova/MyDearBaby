﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class AddEnjoyment : Form
    {
        public List<Child> listOfChildren;

        public AddEnjoyment()
        {
            InitializeComponent();

            ShowActualDate();

            lbl_actualDate.Text = ShowActualDate();

            listOfChildren = DeserializeChildFileJsonToListOfChildren(listOfChildren, ChildFilePath());

            if (listOfChildren != null)
            {
                foreach (var child in listOfChildren)
                {
                    checkedListBox_children.Items.Add(child);
                }
            }
        }

        public string ChildFilePath()
        {
            string applicationDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string programName = "MyDearChild";
            string childFile = "child.json";
            string childFilePath = Path.Combine(applicationDataFolderPath, programName, childFile);

            return childFilePath;
        }

        public string EnjoymentFilePath()
        {
            string myDocumentsFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string programName = "MyDearChild";
            string enjoymentsFile = "zážitky.txt";
            string enjoymentsFilePath = Path.Combine(myDocumentsFilePath, programName, enjoymentsFile);

            return enjoymentsFilePath;
        }

        private List<Child> DeserializeChildFileJsonToListOfChildren(List<Child> children, string childFilePath)
        {
            string jsonString = File.ReadAllText(childFilePath);
            children = JsonConvert.DeserializeObject<List<Child>>(jsonString);

            return children;
        }

        private string ShowActualDate()
        {
            //toDO: https://docs.microsoft.com/cs-cz/dotnet/api/system.globalization.cultureinfo.invariantculture?view=net-5.0
            //      https://docs.microsoft.com/cs-cz/dotnet/api/system.globalization.cultureinfo.createspecificculture?view=net-5.0
            //lbl_actualDate.Text = DateTime.Parse(input, invC, DateTimeStyles.RoundtripKind);

            return DateTime.Now.ToString("dd/MM/yyyy hh:mm");
        }

        private void btn_addEnjoyment_Click(object sender, EventArgs e)
        {
            SaveEnjoyment(EnjoymentFilePath());
        }

        private void SaveEnjoyment(string enjoymentFilePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(enjoymentFilePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(enjoymentFilePath));
            }

            if (File.Exists(enjoymentFilePath))
            {
                using (StreamWriter writer = new StreamWriter(EnjoymentFilePath(), append: true))
                {
                    writer.WriteLine(ShowActualDate());
                    WriteCheckedChildren(writer);
                    writer.WriteLine(richTextBox_enjoyment.Text);
                    writer.WriteLine("******************************************");
                }
            }  
        }

        private void WriteCheckedChildren(StreamWriter writer)
        {
            for (int i = 0; i <= (checkedListBox_children.CheckedItems.Count - 1); i++)
            {
                writer.WriteLine(checkedListBox_children.CheckedItems[i].ToString());
            }
        }
    }
}
