using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class RemoveEnjoymentCategoryForm : Form
    {
        public List<string> ListOfEnjoymentsCategories { get; set; }

        public RemoveEnjoymentCategoryForm(List<string> listCategories)
        {
            InitializeComponent();

            ListOfEnjoymentsCategories = listCategories;
            FormToolsHelpers.ShowListInCheckedListBox(ListOfEnjoymentsCategories, checkedListBoxCategories);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                FormToolsHelpers.RemoveCheckedListBoxCheckedItemsFromList(ListOfEnjoymentsCategories, checkedListBoxCategories);
            }
        }

        private void CheckedListBoxCategories_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void BtnX_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
