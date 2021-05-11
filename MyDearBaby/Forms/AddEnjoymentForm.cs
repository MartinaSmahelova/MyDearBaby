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
        private string actualDateAndTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        private List<Child> checkedChildList;
        private List<string> checkedCategoriesList;

        public List<Child> ListOfChildren { get; set; }
        public List<string> ListOfEnjoymentCategories { get; set; }
        public List<Enjoyment> ListOfEnjoyments { get; set; }

        public AddEnjoymentForm(List<Child> listChild, List<string> listCategories, List<Enjoyment> listEnjoyments)
        {
            InitializeComponent();

            lblActualDate.Text = actualDateAndTime;
            checkedChildList = new List<Child>();
            checkedCategoriesList = new List<string>();

            ListOfChildren = listChild;
            FormToolsHelpers.ShowListInCheckedListBox(ListOfChildren, checkedListBoxChildren);

            ListOfEnjoymentCategories = listCategories;
            FormToolsHelpers.ShowListInCheckedListBox(ListOfEnjoymentCategories, checkedListBoxEnjoymentsCategories);

            ListOfEnjoyments = listEnjoyments;
        }

        private void btnAddEnjoyment_Click(object sender, EventArgs e)
        {
            checkedChildList = AddCheckedItemsToList(checkedChildList, checkedListBoxChildren);
            checkedCategoriesList = AddCheckedItemsToList(checkedCategoriesList, checkedListBoxEnjoymentsCategories);

            enjoyment = new Enjoyment(checkedChildList, checkedCategoriesList, richTextBoxEnjoyment.Text);

            if (enjoyment != null)
            {
                ListOfEnjoyments.Add(enjoyment);
            }
        }

        private List<T> AddCheckedItemsToList<T>(List<T> list, CheckedListBox checkedListBox) 
        {
            IEnumerable<object> checkedItems = (from object item in checkedListBox.Items
                                                where checkedListBox.CheckedItems.Contains(item)
                                                select item);

            foreach (object item in checkedItems)
            {
                list.Add((T) item);
            }

            return list;
        }

        private List<Child> AddCheckedChildItemsToList(List<Child> list, CheckedListBox checkedListBox)
        {
            list.Clear();

            IEnumerable<object> checkedItems = (from object item in checkedListBox.Items
                                                where checkedListBox.CheckedItems.Contains(item)
                                                select item);

            foreach (object item in checkedItems)
            {
                list.Add((Child)item);
            }

            return list;
        }

    }
}
