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
        public List<Child> listOfChildren;
        public Child Child { get; private set; }

        public AddChild()
        {
            InitializeComponent();
            //MaxDate is set to nine months from actual date, so some users could use app before child is born
            dateTimePickerDateOfBirth.MaxDate = DateTime.Now.AddDays(280);
            listOfChildren = DeserializeChildFileJsonToListOfChildren(ChildFilePath());
        }

        //public void AddChildTo()
        //{
        //    _childName = tb_childName.Text;
        //    _childGende = groupBoxRadioButtons.
        //    _dateOfBirth = Convert.ToDateTime(dateTimePickerDateOfBirth.Value);
        //}
        private void rb_girl_CheckedChanged(object sender, EventArgs e)
        {
            _childGender = Gender.girl;
        }

        private void rb_boy_CheckedChanged(object sender, EventArgs e)
        {
            _childGender = Gender.boy;
        }

        private void tb_childName_TextChanged(object sender, EventArgs e)
        {
            _childName = tb_childName.Text;
        }

        private void dateTimePicker_dateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            _dateOfBirth = Convert.ToDateTime(dateTimePickerDateOfBirth.Value);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            //if (ValidateName() && ValidatingRadioButtons() && ValidateDateOfBirth())
            //{
            if (_childName != null && _childGender != Gender.empty && _dateOfBirth != null)
            {
                Child = new Child(_childName, _childGender, _dateOfBirth);

            }

            if (Child != null)
            {
                listOfChildren.Add(Child);
            }

               // btn_OK.DialogResult = DialogResult.OK;
        //}
    }

        private void AddChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeListOfChildrenToChildFileJonson(listOfChildren, ChildFilePath());
        }


        private bool ValidateName(CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_childName.Text))
            {
                MessageBox.Show("Vyplňte jméno");
                e.Cancel = true;
                return false;
            }
            if (tb_childName.Text.Length <= 2)
            {
                MessageBox.Show("Jméno je příliš krátké, musí obsahovat alepsoň tři znaky");
                return false;
            }

            return true;
        }

        private bool ValidatingRadioButtons(CancelEventArgs e)
        {
            var validation = groupBoxRadioButtons.Controls
                          .OfType<RadioButton>()
                          .Any(r => r.Checked);

            if (!validation)
            {
                MessageBox.Show("Vyberte pohlaví");
                e.Cancel = true;
                return false;
            }

            return true;
        }

        private bool ValidateDateOfBirth(CancelEventArgs e)
        {
            if (dateTimePickerDateOfBirth.Value == DateTime.Today)
            {
                var closeMsg = MessageBox.Show("Narodilo se Vaše dítě dnes ? Pokud ne, změnte prosím datum narození.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                e.Cancel = true;

                if (closeMsg == DialogResult.No)
                {
                    e.Cancel = true;
                    return false;
                }
            }

            return true;
        }

        public List<Child> DeserializeChildFileJsonToListOfChildren(string childFilePath)
        {
            List<Child> childrenListJson = new List<Child>();

            if (!Directory.Exists(Path.GetDirectoryName(childFilePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(childFilePath));
            }

            if (!File.Exists(childFilePath))
            {
                File.WriteAllText(childFilePath, "[]");
            }

            string jsonString = File.ReadAllText(childFilePath);
            childrenListJson = JsonConvert.DeserializeObject<List<Child>>(jsonString);

            return childrenListJson;
        }

        private void SerializeListOfChildrenToChildFileJonson(List<Child> listOfChildren, string childFilePath)
        {
            string listOfChildrenJson = JsonConvert.SerializeObject(listOfChildren, Formatting.Indented);
            File.WriteAllText(childFilePath, listOfChildrenJson);
        }

        public string ChildFilePath()
        {
            string specialFolderApplicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string programName = "MyDearChild";
            string childFile = "child.json";
            string childFilePath = Path.Combine(specialFolderApplicationDataPath, programName, childFile);

            return childFilePath;
        }

        private void tb_childName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_childName.Text))
            {
                //MessageBox.Show("Vyplňte jméno");
                e.Cancel = true;
                tb_childName.Focus();
                errorProvider1.SetError(tb_childName, "Vyplňte jméno");

            }
            if (tb_childName.Text.Length <= 2)
            {
                //MessageBox.Show("Jméno je příliš krátké, musí obsahovat alepsoň tři znaky");
                e.Cancel = true;
                tb_childName.Focus();
                errorProvider1.SetError(tb_childName, "Jméno je příliš krátké, musí obsahovat alepsoň tři znaky");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void groupBoxRadioButtons_Validating(object sender, CancelEventArgs e)
        {
            ValidatingRadioButtons(e);
        }

        private void dateTimePickerDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            ValidateDateOfBirth(e);
        }

        //private void btn_OK_Validating(object sender, CancelEventArgs e)
        //{
        //    ValidateName(e);
        //    ValidatingRadioButtons(e);
        //    ValidateDateOfBirth(e);
        //}
    }
}
