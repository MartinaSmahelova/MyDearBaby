using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class AddChild : Form
    {
        public string ChildName { get; set; }
        public Gender ChildGender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Child Child { get; set; }

        //public string dayOfBirth;
        //public string monthOfBirth;
        //public string yearOfBirth;
        //public string DateOfBirth 
        //{
        //    get
        //    {
        //        return dayOfBirth + "/" + monthOfBirth + "/" + yearOfBirth;
        //    }

        //}

        public AddChild()
        {
            InitializeComponent();
        }

        private void rb_girl_CheckedChanged(object sender, EventArgs e)
        {
            ChildGender = Gender.girl;
        }

        private void rb_boy_CheckedChanged(object sender, EventArgs e)
        {
            ChildGender = Gender.boy;
        }

        private void tb_childName_TextChanged(object sender, EventArgs e)
        {
            ChildName = tb_childName.Text;
        }

        //private void tb_dayOFBirth_TextChanged(object sender, EventArgs e)
        //{
        //    dayOfBirth = tb_dayOFBirth.Text;
        //}

        //private void tb_monthOfBirth_TextChanged(object sender, EventArgs e)
        //{
        //    monthOfBirth = tb_monthOfBirth.Text;
        //}

        //private void tb_yearOfBirth_TextChanged(object sender, EventArgs e)
        //{
        //    yearOfBirth = tb_yearOfBirth.Text;
        //}

        private void dateTimePicker_dateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            DateOfBirth = Convert.ToDateTime(dateTimePicker_dateOfBirth.Value);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Child = new Child(ChildName, ChildGender, DateOfBirth);
            //if (ValidateName())
            //{
            //    btn_OK.DialogResult = DialogResult.OK;
            //}
            //if (tb_childName.Text.Length <= 2)
            //{
            //    MessageBox.Show("Jméno je příliš krátké, musí obsahovat alepsoň tři znaky");
            //}
            //else
            //{
            //    ChildName = tb_childName.Text;
            //}
        }

        //private void tb_childName_Validating(object sender, CancelEventArgs e)
        //{
        //    ValidateName();
        //}

        //private bool ValidateName()
        //{
        //    bool bStatus = true;
        //    if (tb_childName.Text == "")
        //    {
        //        errorProvider1.SetError(tb_childName, "Please enter your Name");
        //        bStatus = false;
        //    }
        //    else
        //        errorProvider1.SetError(tb_childName, "");
        //    return bStatus;
        //}

        //private void PopupFormChildInfo_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (tb_childName.Text.Length <= 2)
        //    {
        //        MessageBox.Show("Jméno je příliš krátké, musí obsahovat alepsoň tři znaky");
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        ChildName = tb_childName.Text;
        //    }
        //}
    }
}
