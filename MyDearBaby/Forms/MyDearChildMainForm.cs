using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class MyDearChildMainForm : Form
    {
        public List<Child> ListOfChildren { get; private set; }
        public List<string> ListOfEnjoymentCategories { get; private set; }
        public List<Enjoyment> ListOfEnjoyments { get; private set; }

        public MyDearChildMainForm()
        {
            InitializeComponent();
            ListOfChildren = Json.DeserializeJsonFileToList(ListOfChildren, Json.FilePathToAppDataFolder(FilesNames.childJson));
            ListOfEnjoymentCategories = Json.DeserializeJsonFileToList(ListOfEnjoymentCategories, Json.FilePathToAppDataFolder(FilesNames.enjoymentsCategoriesJson));
            ListOfEnjoyments = Json.DeserializeJsonFileToList(ListOfEnjoyments, Json.FilePathToAppDataFolder(FilesNames.enjoymentsJson));

            if (ListOfEnjoymentCategories.Count == 0)
            {
                ListOfEnjoymentCategories.Add("Vtipný");
                ListOfEnjoymentCategories.Add("Sny");
                ListOfEnjoymentCategories.Add("Pohyb");
            }
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            using (var addChildForm = new AddChildForm(ListOfChildren))
            {
                addChildForm.ShowDialog();
                ListOfChildren = addChildForm.ListOfChildren;
            }
        }


        private void btnRemoveChild_Click(object sender, EventArgs e)
        {
            if (ListOfChildren.Count == 0)
            {
                MessageBox.Show("Nemáte uložený žádný profil dítěte. Vložte nejdřív profil dítěte.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (var removeChildForm = new RemoveChildForm(ListOfChildren))
                {
                    removeChildForm.ShowDialog();
                    ListOfChildren = removeChildForm.listOfChildren;
                }
            }
        }

        private void btnAddEnjoymentCategory_Click(object sender, EventArgs e)
        {
            using (var addCategoryForm = new AddEnjoymentCategoryForm(ListOfEnjoymentCategories))
            {
                addCategoryForm.ShowDialog();
                ListOfEnjoymentCategories = addCategoryForm.ListOfEnjoymentCategories;
            }
        }

        private void btnRemoveEnjoymentCategory_Click(object sender, EventArgs e)
        {
            using (var removeCategoryForm = new RemoveEnjoymentCategoryForm(ListOfEnjoymentCategories))
            {
                removeCategoryForm.ShowDialog();
                ListOfEnjoymentCategories = removeCategoryForm.listOfEnjoymentsCategories;
            }
        }

        private void btnAddEnjoyment_Click(object sender, EventArgs e)
        {
            using (var AddEnjoymentForm = new AddEnjoymentForm(ListOfChildren, ListOfEnjoymentCategories, ListOfEnjoyments))
            {
                AddEnjoymentForm.ShowDialog();
                ListOfEnjoyments = AddEnjoymentForm.ListOfEnjoyments;
                ListOfEnjoymentCategories = AddEnjoymentForm.ListOfEnjoymentCategories;
                ListOfChildren = AddEnjoymentForm.ListOfChildren;
            }
        }

        private void btnEnjoyments_Click(object sender, EventArgs e)
        {
            using (var enjoymentsForm = new EnjoymentsForm(ListOfChildren, ListOfEnjoymentCategories, ListOfEnjoyments))
            {
                enjoymentsForm.ShowDialog();
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Json.SerializeListToJsonFile(ListOfChildren, Json.FilePathToAppDataFolder(FilesNames.childJson));
            Json.SerializeListToJsonFile(ListOfEnjoymentCategories, Json.FilePathToAppDataFolder(FilesNames.enjoymentsCategoriesJson));
            Json.SerializeListToJsonFile(ListOfEnjoyments, Json.FilePathToAppDataFolder(FilesNames.enjoymentsJson));
            Environment.Exit(0);
        }

        private void MyDearChildMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Json.SerializeListToJsonFile(ListOfChildren, Json.FilePathToAppDataFolder(FilesNames.childJson));
            Json.SerializeListToJsonFile(ListOfEnjoymentCategories, Json.FilePathToAppDataFolder(FilesNames.enjoymentsCategoriesJson));
            Json.SerializeListToJsonFile(ListOfEnjoyments, Json.FilePathToAppDataFolder(FilesNames.enjoymentsJson));
        }
    }
}
