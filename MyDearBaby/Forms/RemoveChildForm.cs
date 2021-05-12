using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class RemoveChildForm : Form
    {
        public List<Child> ListOfChildren { get; set; }

        public RemoveChildForm(List<Child> listChild)
        {
            InitializeComponent();

            ListOfChildren = listChild;
            FormToolsHelpers.ShowListInCheckedListBox(ListOfChildren, checkedListBoxChildren);
            
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                FormToolsHelpers.RemoveCheckedListBoxCheckedItemsFromList(ListOfChildren, checkedListBoxChildren);
            }
        }

        private void CheckedListBoxChildren_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (checkedListBoxChildren.CheckedItems.Count == 0)
            {
                var closeMsg = MessageBox.Show("Nevybrali jste žádné dítě. Chcete vybrat dítě?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                e.Cancel = true;

                if (closeMsg == DialogResult.No)
                {
                    MessageBox.Show("Strána se uzavře, nevymazali jste žádné dítě.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
