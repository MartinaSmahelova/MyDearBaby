using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class AddChildForm : Form
    {
        private string childName;
        private Gender childGender;
        private DateTime dateOfBirth;
        private Child child;
        public List<Child> ListOfChildren { get; set; }

        public AddChildForm(List<Child> listChild)
        {
            InitializeComponent();

            //MaxDate is set to nine months from actual date, so some users could use application during pregnancy, before child is born
            dateTimePickerDateOfBirth.MaxDate = DateTime.Now.AddDays(280);
            dateTimePickerDateOfBirth.Value = DateTime.Today;
            ListOfChildren = listChild;
        }

        private void TbChildName_TextChanged(object sender, EventArgs e)
        {
            childName = tbChildName.Text;
        }

        private void RbGirl_CheckedChanged(object sender, EventArgs e)
        {
            childGender = Gender.Girl;
        }

        private void RbBoy_CheckedChanged(object sender, EventArgs e)
        {
            childGender = Gender.Boy;
        }

        private void DateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            dateOfBirth = Convert.ToDateTime(dateTimePickerDateOfBirth.Value);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                child = new Child(childName, childGender, dateOfBirth);

                if (child != null)
                {
                    ListOfChildren.Add(child);

                    btnOK.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void tbChildName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbChildName.Text))
            {
                MessageBox.Show("Vyplňte jméno", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            if (tbChildName.Text.Length > 0 && tbChildName.Text.Length <= 2)
            {
                MessageBox.Show("Jméno je příliš krátké, musí obsahovat alepsoň tři znaky", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }

        }

        private void groupBoxRadioButtons_Validating(object sender, CancelEventArgs e)
        {
            var validation = groupBoxRadioButtons.Controls
                      .OfType<RadioButton>()
                      .Any(r => r.Checked);

            if (!validation)
            {
                MessageBox.Show("Vyberte pohlaví", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void dateTimePickerDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePickerDateOfBirth.Value == DateTime.Today)
            {
                DialogResult closeMsg = MessageBox.Show("Narodilo se Vaše dítě dnes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                e.Cancel = true;

                if (closeMsg == DialogResult.No)
                {
                    MessageBox.Show("Změnte prosím datum narození.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }

                if (closeMsg == DialogResult.Yes)
                {
                    dateOfBirth = dateTimePickerDateOfBirth.Value;
                    e.Cancel = false;
                }
            }
        }
    }
}
