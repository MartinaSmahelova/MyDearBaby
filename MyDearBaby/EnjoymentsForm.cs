﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class EnjoymentsForm : Form
    {
        private List<Enjoyment> filteredEnjoyments = new List<Enjoyment>();
        private IEnumerable<Enjoyment> filteredEnjoymentsByCategory = new List<Enjoyment>();
        private bool wereAllEnjoymentsAlreadyDispleyd = false;
        public List<string> listOfEnjoymentCategories { get; set; }
        public List<Enjoyment> listOfEnjoyments { get; set; }

        public EnjoymentsForm(List<string> listCategories, List<Enjoyment> listEnjoyments)
        {
            InitializeComponent();

            listOfEnjoymentCategories = listCategories;
            FormToolsHelpers.ShowListInCheckedListBox(listOfEnjoymentCategories, checkedListBoxCategories);

            listOfEnjoyments = listEnjoyments;
            FormToolsHelpers.ShowListInRichTextBox(listOfEnjoyments, richTextBoxEnjoyments);
        }

        private void btnKeyWordFilter_Click(object sender, EventArgs e)
        {
            filteredEnjoyments = listOfEnjoyments.Where(x => x.EnjoymentText.Contains(textBoxKeyWord.Text)).ToList();

            if (!string.IsNullOrEmpty(textBoxKeyWord.Text))
            {
                richTextBoxEnjoyments.Clear();
                btnCategoryFilter.Enabled = false;
                wereAllEnjoymentsAlreadyDispleyd = false;

                if (filteredEnjoyments.Count != 0)
                {
                    FormToolsHelpers.ShowListInRichTextBox(filteredEnjoyments, richTextBoxEnjoyments);
                    richTextBoxEnjoyments.ReadOnly = true;
                }
                else
                {
                    richTextBoxEnjoyments.Text = "Nenašli se žádné zážitky, prosím zadejte jíné klíčové slovo";
                    richTextBoxEnjoyments.ReadOnly = true;
                }
            }
            else
            {
                MessageBox.Show("Zadejte klíčové slovo", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCategoryFilter_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (var checkeIitem in checkedListBoxCategories.CheckedItems)
            {
                list.Add((string)checkeIitem);
            }

            filteredEnjoymentsByCategory = listOfEnjoyments.Where(x => list.Any(y => x.ListOfEnjoymentsCategories.Contains(y)));

            if (checkedListBoxCategories.CheckedItems.Count != 0)
            {
                richTextBoxEnjoyments.Clear();
                btnKeyWordFilter.Enabled = false;
                wereAllEnjoymentsAlreadyDispleyd = false;

                if (filteredEnjoymentsByCategory.Count() != 0)
                {
                    FormToolsHelpers.ShowListInRichTextBox(filteredEnjoymentsByCategory.ToList(), richTextBoxEnjoyments);
                    richTextBoxEnjoyments.ReadOnly = true;
                }
                else
                {
                    richTextBoxEnjoyments.Text = "Nenašli se žádné zážitky, prosím zadejte jinou kategorii";
                    richTextBoxEnjoyments.ReadOnly = true;
                }
            }

            else
            {
                MessageBox.Show("Vyberte kategorii", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnShowAllEnjoyments_Click(object sender, EventArgs e)
        {
            if (!wereAllEnjoymentsAlreadyDispleyd)
            {
                foreach (int item in checkedListBoxCategories.CheckedIndices)
                {
                    checkedListBoxCategories.SetItemCheckState(item, CheckState.Unchecked);
                }

                FormToolsHelpers.ShowListInRichTextBox(listOfEnjoyments, richTextBoxEnjoyments);

                btnKeyWordFilter.Enabled = true;
                btnCategoryFilter.Enabled = true;

                wereAllEnjoymentsAlreadyDispleyd = true;
            }

            else
            {
                MessageBox.Show("Máte zobrazeny všchny zážitky", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void SaveEnjoyment(Enjoyment enjoyment)
        {
            if (!Directory.Exists(Path.GetDirectoryName(Json.FilePathTonMyDesktop(FilesNames.enjoymentsTxt))))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Json.FilePathTonMyDesktop(FilesNames.enjoymentsTxt)));
            }

            if (!File.Exists(Json.FilePathTonMyDesktop(FilesNames.enjoymentsTxt)))
            {
                File.WriteAllText(Json.FilePathTonMyDesktop(FilesNames.enjoymentsTxt), "ZÁŽITKY <3 \n******************************************\n");
            }

            else
            {
                using (StreamWriter writer = new StreamWriter(Json.FilePathTonMyDesktop(FilesNames.enjoymentsTxt), append: true))
                {
                    writer.WriteLine(richTextBoxEnjoyments.Text);
                }
            }
        }

    }
}
