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
    public partial class RemoveChildForm : Form
    {
        List<Child> listOfChildren = new List<Child>();

        public RemoveChildForm()
        {
            InitializeComponent();

            listOfChildren = Json.DeserializeJsonFileToList(listOfChildren, Json.FilePathinAppDataFolder(FilesNames.childJson));

            FormToolsExtensions.ShowListInCheckedListBox(listOfChildren, checkedListBoxChildren);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveChild();
        }

        private void RemoveChild()
        {
            listOfChildren.Clear();

            IEnumerable<object> notChecked = (from object item in checkedListBoxChildren.Items
                                              where !checkedListBoxChildren.CheckedItems.Contains(item)
                                              select item);

            foreach (object item in notChecked)
            {
                listOfChildren.Add((Child)item);
            }
        }

        private void RemoveChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Json.SerializeListToJsonFile(listOfChildren, Json.FilePathinAppDataFolder(FilesNames.childJson));
        }
    }
}
