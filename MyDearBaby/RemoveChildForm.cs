using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class RemoveChildForm : Form
    {
        List<Child> listOfChildren = new List<Child>();

        public RemoveChildForm()
        {
            InitializeComponent();

            listOfChildren = Json.DeserializeJsonFileToList(listOfChildren, Json.FilePathToAppDataFolder(FilesNames.childJson));

            FormToolsExtensions.ShowListInCheckedListBox(listOfChildren, checkedListBoxChildren);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                FormToolsExtensions.RemoveCheckedListBoxCheckedItemsFromList(listOfChildren, checkedListBoxChildren);
            }
        }

        private void RemoveChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Json.SerializeListToJsonFile(listOfChildren, Json.FilePathToAppDataFolder(FilesNames.childJson));
        }

        private void checkedListBoxChildren_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
