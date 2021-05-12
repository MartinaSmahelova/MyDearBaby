using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class AddEnjoymentCategoryForm : Form
    {
        private string enjoymentCategory;
        public List<string> ListOfEnjoymentCategories { get; set; }

        public AddEnjoymentCategoryForm(List<string> listCategories)
        {
            InitializeComponent();

            ListOfEnjoymentCategories = listCategories;
            FormToolsHelpers.ShowListInListView(ListOfEnjoymentCategories, listViewEnjoymentsCategories);
        }
        private void TbCategoryname_TextChanged(object sender, EventArgs e)
        {
            enjoymentCategory = tbCategoryName.Text;
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                ListOfEnjoymentCategories.Add(enjoymentCategory);
            }
        }

        private void TbCategoryName_Validating(object sender, CancelEventArgs e)
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
