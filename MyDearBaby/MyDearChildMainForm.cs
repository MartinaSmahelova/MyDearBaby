using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class MyDearChildMainForm : Form
    {
        public List<Child> listOfChildren { get; private set; }
        public List<string> listOfEnjoymentCategories { get; private set; }
        public List<Enjoyment> listOfEnjoyments { get; private set; }

        public MyDearChildMainForm()
        {
            InitializeComponent();
            listOfChildren = Json.DeserializeJsonFileToList(listOfChildren, Json.FilePathToAppDataFolder(FilesNames.childJson));
            listOfEnjoymentCategories = Json.DeserializeJsonFileToList(listOfEnjoymentCategories, Json.FilePathToAppDataFolder(FilesNames.enjoymentsCategoriesJson));
            listOfEnjoyments = Json.DeserializeJsonFileToList(listOfEnjoyments, Json.FilePathToAppDataFolder(FilesNames.enjoymentsJson));
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            using (var addChildForm = new AddChildForm(listOfChildren))
            {
                addChildForm.ShowDialog();
                listOfChildren = addChildForm.listOfChildren;
            }
        }


        private void btnRemoveChild_Click(object sender, EventArgs e)
        {
            using (var removeChildForm = new RemoveChildForm(listOfChildren))
            {
                removeChildForm.ShowDialog();
                listOfChildren = removeChildForm.listOfChildren;
            }
        }

        private void btnAddEnjoymentCategory_Click(object sender, EventArgs e)
        {
            using (var addCategoryForm = new AddEnjoymentCategoryForm(listOfEnjoymentCategories))
            {
                addCategoryForm.ShowDialog();
                listOfEnjoymentCategories = addCategoryForm.listOfEnjoymentCategories;
            }
        }

        private void btnRemoveEnjoymentCategory_Click(object sender, EventArgs e)
        {
            using (var removeCategoryForm = new RemoveEnjoymentCategoryForm(listOfEnjoymentCategories))
            {
                removeCategoryForm.ShowDialog();
                listOfEnjoymentCategories = removeCategoryForm.listOfEnjoymentsCategories;
            }
        }

        private void btnAddEnjoyment_Click(object sender, EventArgs e)
        {
            using (var AddEnjoymentForm = new AddEnjoymentForm(listOfChildren, listOfEnjoymentCategories, listOfEnjoyments))
            {
                AddEnjoymentForm.ShowDialog();
                listOfEnjoyments = AddEnjoymentForm.listOfEnjoyments;
            }
        }

        private void btnEnjoyments_Click(object sender, EventArgs e)
        {
            using (var enjoymentsForm = new EnjoymentsForm(listOfEnjoymentCategories, listOfEnjoyments))
            {
                enjoymentsForm.ShowDialog();
                listOfEnjoyments = enjoymentsForm.listOfEnjoyments;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Json.SerializeListToJsonFile(listOfChildren, Json.FilePathToAppDataFolder(FilesNames.childJson));
            Json.SerializeListToJsonFile(listOfEnjoymentCategories, Json.FilePathToAppDataFolder(FilesNames.enjoymentsCategoriesJson));
            Json.SerializeListToJsonFile(listOfEnjoyments, Json.FilePathToAppDataFolder(FilesNames.enjoymentsJson));
        }
    }
}
