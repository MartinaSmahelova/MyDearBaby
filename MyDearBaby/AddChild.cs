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
            listOfChildren = DeserializeChildFileJsonToListOfChildren(ChildFilePath());
        }

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

        private void groupBoxRadioButtons_Validating(object sender, CancelEventArgs e)
        {
            ValidatingRadioButtons();
        }

        private bool ValidatingRadioButtons()
        {
            var validation = groupBoxRadioButtons.Controls
                          .OfType<RadioButton>()
                          .Any(r => r.Checked);

            if (!validation)
            {
                MessageBox.Show("Vyberte pohlaví");
                return false;
            }

            return true;
        }

        private void dateTimePicker_dateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            _dateOfBirth = Convert.ToDateTime(dateTimePicker_dateOfBirth.Value);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (ValidatingRadioButtons())
            {
                Child = new Child(_childName, _childGender, _dateOfBirth);

                if (Child != null)
                {
                    listOfChildren.Add(Child);
                }

                btn_OK.DialogResult = DialogResult.OK;
            }
        }

        private void AddChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeListOfChildrenToChildFileJonson(listOfChildren, ChildFilePath());
        }

        private void tb_childName_Validating(object sender, CancelEventArgs e)
        {
            //ValidateName();
        }

        //private bool ValidateName()
        //{

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
    }
}
