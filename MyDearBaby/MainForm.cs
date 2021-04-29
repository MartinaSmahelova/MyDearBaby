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
            using (var childForm = new AddChild())
            {
                childForm.ShowDialog();
            }
        }

        private void btn_addEnjoyment_Click(object sender, EventArgs e)
        {

            using (var enjoymentForm = new AddEnjoyment())
            {
                enjoymentForm.ShowDialog();    
            }
        }
    }
}
