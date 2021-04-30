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
        private string _enjoymentCategory;
        Enjoyments enjoyments = new Enjoyments();

        public AddEnjoymentCategoryForm()
        {
            InitializeComponent();

            enjoyments.ListOfEnjoymentsCategories = new List<string>();

            enjoyments.ListOfEnjoymentsCategories = Json.DeserializeJsonFile(enjoyments.ListOfEnjoymentsCategories, Json.FilePathinAppDataFolder(Json._enjoymentsCategories));
            ShowListInListView(enjoyments.ListOfEnjoymentsCategories, listViewEnjoymentsCategories);
        }
        private void tbCategoryname_TextChanged(object sender, EventArgs e)
        {
            _enjoymentCategory = tbCategoryName.Text;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_enjoymentCategory))
            {
                enjoyments.ListOfEnjoymentsCategories.Add(_enjoymentCategory);
            }
        }

        private void AddEnjoymentCategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Json.SerializeJsonFile(enjoyments.ListOfEnjoymentsCategories, Json.FilePathinAppDataFolder(Json._enjoymentsCategories));
        }

        private void tbCategoryName_Validating(object sender, CancelEventArgs e)
        {

        }

        public void ShowListInListView<T>(List<T> list, ListView listView)
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    listView.Items.Add(item.ToString());
                }
            }
        }
    }

}
