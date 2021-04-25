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
            //listOfChildren = DeserializeChildFileJsonToListOfChildren(ChildFilePath());
        }

        private void btn_addChild_Click(object sender, EventArgs e)
        {
            using (var childForm = new AddChild())
            {
                childForm.ShowDialog();

                //if (childForm.Child != null)
                //{
                //    listOfChildren.Add(childForm.Child);
                //}
            }
        }

        private void btn_addEnjoyment_Click(object sender, EventArgs e)
        {
            //SerializeListOfChildrenToChildFileJonson(listOfChildren, ChildFilePath());

            using (var enjoymentForm = new AddEnjoyment())
            {
                enjoymentForm.ShowDialog();    
            }
        }

        //private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    SerializeListOfChildrenToChildFileJonson(listOfChildren, ChildFilePath());
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
