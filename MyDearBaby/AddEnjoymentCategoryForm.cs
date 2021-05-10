using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class AddEnjoymentCategoryForm : Form
    {
        private string enjoymentCategory;
        private List<string> listOfEnjoymentCategories = new List<string>();

        public AddEnjoymentCategoryForm()
        {
            InitializeComponent();

            listOfEnjoymentCategories = Json.DeserializeJsonFileToList(listOfEnjoymentCategories, Json.FilePathToAppDataFolder(FilesNames.enjoymentsCategoriesJson));
            
            FormToolsExtensions.ShowListInListView(listOfEnjoymentCategories, listViewEnjoymentsCategories);
        }
        private void tbCategoryname_TextChanged(object sender, EventArgs e)
        {
            enjoymentCategory = tbCategoryName.Text;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                listOfEnjoymentCategories.Add(enjoymentCategory);
            }
        }

        private void AddEnjoymentCategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Json.SerializeListToJsonFile(listOfEnjoymentCategories, Json.FilePathToAppDataFolder(FilesNames.enjoymentsCategoriesJson));
        }

        private void tbCategoryName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(enjoymentCategory))
            {
                MessageBox.Show("Zadejte kategorii", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }

}
