using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MyDearBaby
{
    public partial class AddEnjoyment : Form
    {
        public List<Child> listOfChildren;

        public AddEnjoyment()
        {
            InitializeComponent();
            lbl_actualDate.Text = DateTime.Now.ToString("dd/MM/yyyy hh/mm");
            string jsonString = File.ReadAllText(FindChildFilePath());
            listOfChildren = JsonConvert.DeserializeObject<List<Child>>(jsonString);

            foreach (var child in listOfChildren)
            {
                checkedListBox_children.Items.Add(child);
            }
        }

        public string FindChildFilePath()
        {
            string specialFolderApplicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string programName = "MyDearChild";
            string childFile = "child.json";
            string childFilePath = Path.Combine(specialFolderApplicationDataPath, programName, childFile);

            return childFilePath;
        }
    }
}
