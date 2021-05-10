using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class RemoveEnjoymentCategoryForm : Form
    {
        List<string> listOfEnjoymentsCategories = new List<string>();

        public RemoveEnjoymentCategoryForm()
        {
            InitializeComponent();

            listOfEnjoymentsCategories = Json.DeserializeJsonFileToList(listOfEnjoymentsCategories, Json.FilePathToAppDataFolder(FilesNames.enjoymentsCategoriesJson));

            FormToolsExtensions.ShowListInCheckedListBox(listOfEnjoymentsCategories, checkedListBoxCategories);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                FormToolsExtensions.RemoveCheckedListBoxCheckedItemsFromList(listOfEnjoymentsCategories, checkedListBoxCategories);
            }
           
        }

        private void RemoveEnjoymentCategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Json.SerializeListToJsonFile(listOfEnjoymentsCategories, Json.FilePathToAppDataFolder(FilesNames.enjoymentsCategoriesJson));
        }

        private void checkedListBoxCategories_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (checkedListBoxCategories.CheckedItems.Count == 0)
            {
                var closeMsg = MessageBox.Show("Nevybrali jste žádnou kategorii. Chcete vybrat kategorii pro smazání?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                e.Cancel = true;

                if (closeMsg == DialogResult.No)
                {
                    MessageBox.Show("Strána se uzavře, nevymazali jste žádnou kategorii.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }

                if (closeMsg == DialogResult.Yes)
                {  
                    e.Cancel = false;
                }
            }
        }
    }
}
