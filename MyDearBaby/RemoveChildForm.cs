using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class RemoveChildForm : Form
    {
        public RemoveChildForm()
        {
            InitializeComponent();

            var ListOfChildren = new List<Child>();
            ListOfChildren = Json.DeserializeJsonFile(ListOfChildren, Json.FilePathinAppDataFolder(Json._child));

            if (ListOfChildren != null)
            {
                foreach (var child in ListOfChildren)
                {
                    checkedListBoxChildren.Items.Add(child);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
        private void RemoveChild()
        {
            for (int i = 0; i <= (checkedListBoxChildren.CheckedItems.Count - 1); i++)
            {
                checkedListBoxChildren.CheckedItems[i].ToString();
            }
        }
    }
}
