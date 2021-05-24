using System;
using System.Collections.Generic;
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

        private void BtnAddEnjoyment_Click(object sender, EventArgs e)
        {
            checkedChildList = FormToolsHelpers.AddCheckedItemsToList(checkedChildList, checkedListBoxChildren);
            checkedCategoriesList = FormToolsHelpers.AddCheckedItemsToList(checkedCategoriesList, checkedListBoxEnjoymentsCategories);

            enjoyment = new Enjoyment(checkedChildList, checkedCategoriesList, richTextBoxEnjoyment.Text);

            if (enjoyment != null && !String.IsNullOrEmpty(richTextBoxEnjoyment.Text))
            {
                ListOfEnjoyments.Add(enjoyment);
            }
            else
            {
                MessageBox.Show("Nezadali jste žádný zážitek, okno se uzavře.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      
    }
}
