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
            ListOfChildren = FilesHelper.DeserializeJsonFileToList(ListOfChildren, FilesHelper.FilePathToAppDataFolder(FilesNames.childJson));
            ListOfEnjoymentCategories = FilesHelper.DeserializeJsonFileToList(ListOfEnjoymentCategories, FilesHelper.FilePathToAppDataFolder(FilesNames.enjoymentsCategoriesJson));
            ListOfEnjoyments = FilesHelper.DeserializeJsonFileToList(ListOfEnjoyments, FilesHelper.FilePathToAppDataFolder(FilesNames.enjoymentsJson));

            if (ListOfEnjoymentCategories.Count == 0)
            {
                ListOfEnjoymentCategories.Add("Vtipný");
                ListOfEnjoymentCategories.Add("Sny");
                ListOfEnjoymentCategories.Add("Pohyb");
            }
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            using (var addChildForm = new AddChildForm(ListOfChildren))
            {
                addChildForm.ShowDialog();
                ListOfChildren = addChildForm.ListOfChildren;
            }
        }


        private void BtnRemoveChild_Click(object sender, EventArgs e)
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
                    ListOfChildren = removeChildForm.ListOfChildren;
                }
            }
        }

        private void BtnAddEnjoymentCategory_Click(object sender, EventArgs e)
        {
            using (var addCategoryForm = new AddEnjoymentCategoryForm(ListOfEnjoymentCategories))
            {
                addCategoryForm.ShowDialog();
                ListOfEnjoymentCategories = addCategoryForm.ListOfEnjoymentCategories;
            }
        }

        private void BtnRemoveEnjoymentCategory_Click(object sender, EventArgs e)
        {
            using (var removeCategoryForm = new RemoveEnjoymentCategoryForm(ListOfEnjoymentCategories))
            {
                removeCategoryForm.ShowDialog();
                ListOfEnjoymentCategories = removeCategoryForm.ListOfEnjoymentsCategories;
            }
        }

        private void BtnAddEnjoyment_Click(object sender, EventArgs e)
        {
            using (var AddEnjoymentForm = new AddEnjoymentForm(ListOfChildren, ListOfEnjoymentCategories, ListOfEnjoyments))
            {
                AddEnjoymentForm.ShowDialog();
                ListOfEnjoyments = AddEnjoymentForm.ListOfEnjoyments;
                ListOfEnjoymentCategories = AddEnjoymentForm.ListOfEnjoymentCategories;
                ListOfChildren = AddEnjoymentForm.ListOfChildren;
            }
        }

        private void BtnEnjoyments_Click(object sender, EventArgs e)
        {
            using (var enjoymentsForm = new EnjoymentsForm(ListOfChildren, ListOfEnjoymentCategories, ListOfEnjoyments))
            {
                enjoymentsForm.ShowDialog();
            }
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            FilesHelper.SerializeListToJsonFile(ListOfChildren, FilesHelper.FilePathToAppDataFolder(FilesNames.childJson));
            FilesHelper.SerializeListToJsonFile(ListOfEnjoymentCategories, FilesHelper.FilePathToAppDataFolder(FilesNames.enjoymentsCategoriesJson));
            FilesHelper.SerializeListToJsonFile(ListOfEnjoyments, FilesHelper.FilePathToAppDataFolder(FilesNames.enjoymentsJson));
            Environment.Exit(0);
        }

        private void MyDearChildMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FilesHelper.SerializeListToJsonFile(ListOfChildren, FilesHelper.FilePathToAppDataFolder(FilesNames.childJson));
            FilesHelper.SerializeListToJsonFile(ListOfEnjoymentCategories, FilesHelper.FilePathToAppDataFolder(FilesNames.enjoymentsCategoriesJson));
            FilesHelper.SerializeListToJsonFile(ListOfEnjoyments, FilesHelper.FilePathToAppDataFolder(FilesNames.enjoymentsJson));
        }
    }
}
