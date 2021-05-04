using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace MyDearBaby
{
    public partial class RemoveEnjoymentCategoryForm : Form
    {
        List<string> listOfEnjoymentsCategories = new List<string>();

        public RemoveEnjoymentCategoryForm()
        {
            InitializeComponent();

            listOfEnjoymentsCategories = Json.DeserializeJsonFileToList(listOfEnjoymentsCategories, Json.FilePathinAppDataFolder(Json.enjoymentsCategories));

            FormToolsExtensions.ShowListInCheckedListBox(listOfEnjoymentsCategories, checkedListBoxCategories);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveCategory();
        }

        private void RemoveCategory()
        {
            listOfEnjoymentsCategories.Clear();

            IEnumerable<object> notChecked = (from object item in checkedListBoxCategories.Items
                                              where !checkedListBoxCategories.CheckedItems.Contains(item)
                                              select item);

            foreach (object item in notChecked)
            {
                listOfEnjoymentsCategories.Add((string)item);
            }
        }

        private void RemoveEnjoymentCategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Json.SerializeListToJsonFile(listOfEnjoymentsCategories, Json.FilePathinAppDataFolder(Json.enjoymentsCategories));
        }
    }
}
