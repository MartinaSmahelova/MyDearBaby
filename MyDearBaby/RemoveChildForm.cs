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

            listOfChildren = Json.DeserializeJsonFile(listOfChildren, Json.FilePathinAppDataFolder(Json._child));

            if (listOfChildren != null)
            {
                foreach (var child in listOfChildren)
                {
                    checkedListBoxChildren.Items.Add(child);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveChild();
        }

        private void RemoveChild()
        {
            listOfChildren.Clear();

            //for (int i = 0; i <= (checkedListBoxChildren.CheckedItems.Count - 1); i++)
            //{
            //    checkedListBoxChildren.Items.RemoveAt(checkedListBoxChildren.CheckedIndices[i]);
            //}

            //foreach (var item in checkedListBoxChildren.Items)
            //{
            //    listOfChildren.Add((Child)item);
            //}

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
            Json.SerializeJsonFile(listOfChildren, Json.FilePathinAppDataFolder(Json._child));
        }
    }
}
