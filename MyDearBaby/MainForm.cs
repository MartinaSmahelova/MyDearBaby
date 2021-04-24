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
       // public Enjoyments enjoyments = new Enjoyments();

        public MainForm()
        {
            InitializeComponent();
            listOfChildren = DeserializeChildFileJsonToListOdChildren(FindChildFilePath());
        }

        private void btn_addChild_Click(object sender, EventArgs e)
        {
            using (var childForm = new AddChild())
            {
                childForm.ShowDialog();
                //DateTime dateOfBirth = Convert.ToDateTime(childForm.DateOfBirth);
               // var child = new Child(childForm.ChildName, childForm.ChildGender, childForm.DateOfBirth);
                //enjoyments.ListOfChildren.Add(child);
                listOfChildren.Add(childForm.Child);
            }
        }

        private void btn_addEnjoyment_Click(object sender, EventArgs e)
        {
            string listOfChildrenJson = JsonConvert.SerializeObject(listOfChildren, Formatting.Indented);
            File.WriteAllText(FindChildFilePath(), listOfChildrenJson);

            using (var enjoymentForm = new AddEnjoyment())
            {
                enjoymentForm.ShowDialog();    
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string listOfChildrenJson = JsonConvert.SerializeObject(listOfChildren, Formatting.Indented);
            File.WriteAllText(FindChildFilePath(), listOfChildrenJson);
        }

        public List<Child> DeserializeChildFileJsonToListOdChildren(string childFilePath)
        {  
            List<Child> childrenListJson = new List<Child>();

            if (!Directory.Exists(Path.GetDirectoryName(childFilePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(childFilePath));
            }

            if (File.Exists(childFilePath))
            {
                string jsonString = File.ReadAllText(childFilePath);
                childrenListJson = JsonConvert.DeserializeObject<List<Child>>(jsonString);
            }

            return childrenListJson;
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
