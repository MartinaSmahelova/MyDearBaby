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
    public partial class MainForm : Form
    {
        public List<Child> listOfChildren;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_addChild_Click(object sender, EventArgs e)
        {
            using (var addhildForm = new AddChildForm())
            {
                addhildForm.ShowDialog();
            }
        }

        private void btn_addEnjoyment_Click(object sender, EventArgs e)
        {

            using (var AddEnjoymentForm = new AddEnjoyment())
            {
                AddEnjoymentForm.ShowDialog();    
            }
        }

        private void butRemoveChild_Click(object sender, EventArgs e)
        {
            using (var removeChildForm = new RemoveChildForm())
            {
                removeChildForm.ShowDialog();
            }
        }

        private void btnAddEnjoymentCategory_Click(object sender, EventArgs e)
        {
            using (var addCategoryForm = new AddEnjoymentCategoryForm())
            {
                addCategoryForm.ShowDialog();
            }
        }
    }
}
