using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class EnjoymentsForm : Form
    {
        private List<Enjoyment> listOfEnjoyments = new List<Enjoyment>();
        private List<Enjoyment> filteredEnjoyments = new List<Enjoyment>();
        private List<string> listOfEnjoymentCategories = new List<string>();
        private IEnumerable<Enjoyment> filteredEnjoymentsByCategory = new List<Enjoyment>();
      

        public EnjoymentsForm()
        {
            InitializeComponent();

            listOfEnjoyments = Json.DeserializeJsonFileToList(listOfEnjoyments, Json.FilePathToAppDataFolder(FilesNames.enjoymentsJson));
            ShowListInRichTextBox(listOfEnjoyments, richTextBoxEnjoyments);

            listOfEnjoymentCategories = Json.DeserializeJsonFileToList(listOfEnjoymentCategories, Json.FilePathToAppDataFolder(FilesNames.enjoymentsCategoriesJson));
            FormToolsExtensions.ShowListInCheckedListBox(listOfEnjoymentCategories, checkedListBoxCategories);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxKeyWord.Text))
            {
                richTextBoxEnjoyments.Clear();

                filteredEnjoyments = listOfEnjoyments.Where(x => x.EnjoymentText.Contains(textBoxKeyWord.Text)).ToList();

                if (filteredEnjoyments.Count != 0)
                {
                    ShowListInRichTextBox(filteredEnjoyments, richTextBoxEnjoyments);
                    richTextBoxEnjoyments.ReadOnly = true;
                }
                else
                {
                    richTextBoxEnjoyments.Text = "Nenašli se žádné zážitky, prosím zadejte jíné klíčové slovo";
                }
            }
            else
            {
                MessageBox.Show("Zadejte klíčové slovo", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ShowListInRichTextBox (List<Enjoyment> list, RichTextBox richTextBox)
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    richTextBox.Text += item.ToString() + " \n";
                }
            }
        }

        private void btnCategoryFilter_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (var checkeIitem in checkedListBoxCategories.CheckedItems)
            {
                list.Add((string)checkeIitem);
            }

            filteredEnjoymentsByCategory = listOfEnjoyments.Where(x => list.Any(y => x.ListOfEnjoymentsCategories.Contains(y)));
        }
    }
}
