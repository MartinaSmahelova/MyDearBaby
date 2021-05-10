﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class AddEnjoymentCategoryForm : Form
    {
        private string enjoymentCategory;
        public List<string> listOfEnjoymentCategories { get; set; }

        public AddEnjoymentCategoryForm(List<string> listCategories)
        {
            InitializeComponent();

            listOfEnjoymentCategories = listCategories;
            FormToolsHelpers.ShowListInListView(listOfEnjoymentCategories, listViewEnjoymentsCategories);
        }
        private void tbCategoryname_TextChanged(object sender, EventArgs e)
        {
            enjoymentCategory = tbCategoryName.Text;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                listOfEnjoymentCategories.Add(enjoymentCategory);
            }
        }

        private void tbCategoryName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(enjoymentCategory))
            {
                MessageBox.Show("Zadejte kategorii", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }

}
