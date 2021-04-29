using Newtonsoft.Json;
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
        Enjoyments enjoyments = new Enjoyments();

        public AddEnjoyment()
        {
            InitializeComponent();

            lbl_actualDate.Text = enjoyments.ShowActualDate();

            enjoyments.ListOfChildren = WorkWithFiles.DeserializeChildrenJsonFileToListOfChildren(enjoyments.ListOfChildren);

            if (enjoyments.ListOfChildren != null)
            {
                foreach (var child in enjoyments.ListOfChildren)
                {
                    checkedListBox_children.Items.Add(child);
                }
            }
        }

        private void btn_addEnjoyment_Click(object sender, EventArgs e)
        {
            SaveEnjoyment();
        }

        private void SaveEnjoyment()
        {
            if (!Directory.Exists(Path.GetDirectoryName(EnjoymentFilePath())))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(EnjoymentFilePath()));
            }

            if (File.Exists(EnjoymentFilePath()))
            {
                using (StreamWriter writer = new StreamWriter(EnjoymentFilePath(), append: true))
                {
                    writer.WriteLine(enjoyments.ShowActualDate());
                    WriteCheckedChildren(writer);
                    writer.WriteLine(richTextBox_enjoyment.Text);
                    writer.WriteLine("******************************************");
                }
            }

            else
            {
                File.WriteAllText(EnjoymentFilePath(), "ZÁŽITKY <3 \n******************************************\n");
            }
        }

        private void WriteCheckedChildren(StreamWriter writer)
        {
            for (int i = 0; i <= (checkedListBox_children.CheckedItems.Count - 1); i++)
            {
                writer.WriteLine(checkedListBox_children.CheckedItems[i].ToString());
            }
        }

        public string EnjoymentFilePath()
        {
            string myDocumentsFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string programName = "MyDearChild";
            string enjoymentsFile = "zážitky.txt";
            string enjoymentsFilePath = Path.Combine(myDocumentsFilePath, programName, enjoymentsFile);

            return enjoymentsFilePath;
        }
    }
}
