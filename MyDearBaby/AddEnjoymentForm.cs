using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class AddEnjoymentForm : Form
    {
        private Enjoyment enjoyment;
        private string actualDateAndTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm");

        public List<Child> listOfChildren { get; set; }
        public List<string> listOfEnjoymentCategories { get; set; }
        public List<Enjoyment> listOfEnjoyments { get; set; }

        public AddEnjoymentForm(List<Child> listChild, List<string> listCategories, List<Enjoyment> listEnjoyments)
        {
            InitializeComponent();

            lblActualDate.Text = actualDateAndTime;

            listOfChildren = listChild;
            FormToolsHelpers.ShowListInCheckedListBox(listOfChildren, checkedListBoxChildren);

            listOfEnjoymentCategories = listCategories;
            FormToolsHelpers.ShowListInCheckedListBox(listOfEnjoymentCategories, checkedListBoxEnjoymentsCategories);

            listOfEnjoyments = listEnjoyments;
        }

        private void btnAddEnjoyment_Click(object sender, EventArgs e)
        {
            listOfChildren = AddCheckedItemsToList(listOfChildren, checkedListBoxChildren);
            listOfEnjoymentCategories = AddCheckedItemsToList(listOfEnjoymentCategories, checkedListBoxEnjoymentsCategories);

            enjoyment = new Enjoyment(listOfChildren, listOfEnjoymentCategories, richTextBoxEnjoyment.Text);

            if (enjoyment != null)
            {
                listOfEnjoyments.Add(enjoyment);
            }
        }

        private List<T> AddCheckedItemsToList<T>(List<T> list, CheckedListBox checkedListBox) 
        {
            list.Clear();

            IEnumerable<object> checkedItems = (from object item in checkedListBox.Items
                                                where checkedListBox.CheckedItems.Contains(item)
                                                select item);

            foreach (object item in checkedItems)
            {
                list.Add((T) item);
            }

            return list;
        }
    }
}
