using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class AddChild : Form
    {
        private string _childName;
        private Gender _childGender;
        private DateTime _dateOfBirth;
        public List<Child> ListOfChildren { get; private set; }
        public Child Child { get; private set; }

        public AddChild()
        {
            InitializeComponent();

            //MaxDate is set to nine months from actual date, so some users could use application during pregnancy, before child is born
            dateTimePickerDateOfBirth.MaxDate = DateTime.Now.AddDays(280);

            ListOfChildren = new List<Child>();
            ListOfChildren = WorkWithFiles.DeserializeChildrenJsonFileToListOfChildren(ListOfChildren);
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            _childGender = Gender.girl;
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            _childGender = Gender.boy;
        }

        private void tbChildName_TextChanged(object sender, EventArgs e)
        {
            _childName = tbChildName.Text;
        }

        private void dateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            _dateOfBirth = Convert.ToDateTime(dateTimePickerDateOfBirth.Value);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Child = new Child(_childName, _childGender, _dateOfBirth);

                if (Child != null)
                {
                    ListOfChildren.Add(Child);

                    btnOK.DialogResult = DialogResult.OK;
                    Close();
                }  
            }
        }

        private void AddChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            WorkWithFiles.SerializeListOfChildrenToChildrenJsonFile(ListOfChildren);
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
                var closeMsg = MessageBox.Show("Narodilo se Vaše dítě dnes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                e.Cancel = true;

                if (closeMsg == DialogResult.No)
                {
                    MessageBox.Show("Změnte prosím datum narození.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }

                if (closeMsg == DialogResult.Yes)
                {
                    _dateOfBirth = dateTimePickerDateOfBirth.Value;
                    e.Cancel = false;
                }
            }
        }
    }
}
