using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class RemoveEnjoymentCategoryForm : Form
    {
        public List<string> listOfEnjoymentsCategories { get; set; }

        public RemoveEnjoymentCategoryForm(List<string> listCategories)
        {
            InitializeComponent();

            listOfEnjoymentsCategories = listCategories;
            FormToolsHelpers.ShowListInCheckedListBox(listOfEnjoymentsCategories, checkedListBoxCategories);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                FormToolsHelpers.RemoveCheckedListBoxCheckedItemsFromList(listOfEnjoymentsCategories, checkedListBoxCategories);
            }
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
