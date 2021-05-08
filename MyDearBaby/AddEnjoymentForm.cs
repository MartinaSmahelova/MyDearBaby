using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace MyDearBaby
{
    public partial class AddEnjoymentForm : Form
    {
        private List<Child> listOfChildren = new List<Child>();
        private List<string> listOfEnjoymentCategories = new List<string>();
        private List<Enjoyment> listOfEnjoyments = new List<Enjoyment>();
        private Enjoyment enjoyment;
        private string actualDateAndTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm");

        public AddEnjoymentForm()
        {
            InitializeComponent();

            lblActualDate.Text = actualDateAndTime;

            listOfChildren = Json.DeserializeJsonFileToList(listOfChildren, Json.FilePathinAppDataFolder(FilesNames.childJson));
            FormToolsExtensions.ShowListInCheckedListBox(listOfChildren, checkedListBoxChildren);

            listOfEnjoymentCategories = Json.DeserializeJsonFileToList(listOfEnjoymentCategories, Json.FilePathinAppDataFolder(FilesNames.enjoymentsCategoriesJson));
            FormToolsExtensions.ShowListInCheckedListBox(listOfEnjoymentCategories, checkedListBoxEnjoymentsCategories);

            listOfEnjoyments = Json.DeserializeJsonFileToList(listOfEnjoyments, Json.FilePathinAppDataFolder(FilesNames.enjoymentsJson));
        }

        private void btnAddEnjoyment_Click(object sender, EventArgs e)
        {
            listOfChildren = AddCheckedItemsToList(listOfChildren, checkedListBoxChildren);
            listOfEnjoymentCategories = AddCheckedItemsToList(listOfEnjoymentCategories, checkedListBoxEnjoymentsCategories);

            enjoyment = new Enjoyment(listOfChildren, listOfEnjoymentCategories, richTextBoxEnjoyment.Text);

            if (enjoyment != null)
            {
                listOfEnjoyments.Add(enjoyment);
            }

            SaveEnjoyment(enjoyment);
        }

        private void AddEnjoyment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Json.SerializeListToJsonFile(listOfEnjoyments, Json.FilePathinAppDataFolder(FilesNames.enjoymentsJson));
        }

        private void SaveEnjoyment(Enjoyment enjoyment)
        {
            if (!Directory.Exists(Path.GetDirectoryName(Json.FilePathInMyDocFolder(FilesNames.enjoymentsTxt))))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Json.FilePathInMyDocFolder(FilesNames.enjoymentsTxt)));
            }

            if (!File.Exists(Json.FilePathInMyDocFolder(FilesNames.enjoymentsTxt)))
            {
                File.WriteAllText(Json.FilePathInMyDocFolder(FilesNames.enjoymentsTxt), "ZÁŽITKY <3 \n******************************************\n");
            }

            else
            {
                if (!string.IsNullOrEmpty(richTextBoxEnjoyment.Text))
                {
                    using (StreamWriter writer = new StreamWriter(Json.FilePathInMyDocFolder(FilesNames.enjoymentsTxt), append: true))
                    {
                        writer.WriteLine(enjoyment);
                    }
                }
            }
        }

        private List<T> AddCheckedItemsToList<T>(List<T> list, CheckedListBox checkedListBox) 
        {
            list.Clear();

            IEnumerable<object> checkedItems = (from object item in checkedListBox.Items
                                                where checkedListBox.CheckedItems.Contains(item)
                                                select item);

            foreach (object item in checkedItems)
            {
                list.Add((T) item);
            }

            return list;
        }
    }
}
