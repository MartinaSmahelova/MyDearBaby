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

            lblActualDate.Text = enjoyments.ShowActualDate();

            enjoyments.ListOfEnjoymentsCategories = new List<string>();

            enjoyments.ListOfChildren = Json.DeserializeJsonFile(enjoyments.ListOfChildren, Json.FilePathinAppDataFolder(Json._child));
            ShowListInCheckedListBox(enjoyments.ListOfChildren, checkedListBoxChildren);

            enjoyments.ListOfEnjoymentsCategories = Json.DeserializeJsonFile(enjoyments.ListOfEnjoymentsCategories, Json.FilePathinAppDataFolder(Json._enjoymentsCategories));
            ShowListInCheckedListBox(enjoyments.ListOfEnjoymentsCategories, checkedListBoxEnjoymentsCategories);
        }

        private void btnAddEnjoyment_Click(object sender, EventArgs e)
        {
            SaveEnjoyment();
        }

        private void AddEnjoyment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Json.SerializeJsonFile(enjoyments.ListOfEnjoymentsCategories, Json.FilePathinAppDataFolder(Json._enjoyments));
        }

        private void SaveEnjoyment()
        {
            if (!Directory.Exists(Path.GetDirectoryName(Json.FilePathInMyDocFolder(Json._enjoyments))))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Json.FilePathInMyDocFolder(Json._enjoyments)));
            }

            if (!File.Exists(Json.FilePathInMyDocFolder(Json._enjoyments)))
            {
                File.WriteAllText(Json.FilePathInMyDocFolder(Json._enjoyments), "ZÁŽITKY <3 \n******************************************\n");
            }

            else
            {
                if (!string.IsNullOrEmpty(richTextBoxEnjoyment.Text))
                {
                    using (StreamWriter writer = new StreamWriter(Json.FilePathInMyDocFolder(Json._enjoyments), append: true))
                    {
                        writer.WriteLine(enjoyments.ShowActualDate());
                        WriteCheckedChildren(writer);
                        WriteCheckedCategories(writer);
                        writer.WriteLine(richTextBoxEnjoyment.Text);
                        writer.WriteLine("******************************************");
                    }
                }
            }
        }

        private void WriteCheckedChildren(StreamWriter writer)
        {
            for (int i = 0; i <= (checkedListBoxChildren.CheckedItems.Count - 1); i++)
            {
                writer.WriteLine(checkedListBoxChildren.CheckedItems[i].ToString());
            }
        }

        private void WriteCheckedCategories(StreamWriter writer)
        {
            for (int i = 0; i <= (checkedListBoxEnjoymentsCategories.CheckedItems.Count - 1); i++)
            {
                writer.WriteLine(checkedListBoxEnjoymentsCategories.CheckedItems[i].ToString());
            }
        }

        public void ShowListInCheckedListBox<T>(List<T> list, CheckedListBox checkedListBox)
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    checkedListBox.Items.Add(item);
                }
            }
        }
    }
}
