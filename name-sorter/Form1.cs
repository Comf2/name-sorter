using System.Drawing.Text;
using System.Diagnostics;
using System.Text;
using System;

namespace name_sorter
{
    public partial class Form1 : Form
    {
        public List<string> names = new();
        public List<string> Alphnames = new();
        public List<string> rvrsAlphNames = new();
        public List<string> lastNames = new();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnSort_Click(object sender, EventArgs e)
        {
            getNames();
            Debug.WriteLine(names);
            //adds all of them to first list
            for (int i = 0; i < names.Count; i++)
            {
                lstName.Items.Add(names[i]);
                Alphnames.Add(names[i]);
                
            }
            sortAlph();
            sortRvrsAlph();
            sortLastName();
            
        }
        //gets all names from file and pushes them to list 
        private void getNames()
        {
            string absPath = Environment.CurrentDirectory;
            string relPath = absPath + "/data";
            string[] nameFiles = Directory.GetFiles(relPath, "*.txt");

            for (int i = 0; i < nameFiles.Length; i++)
            {
                string[] fileNames = File.ReadAllLines(nameFiles[i]);
                for (int x = 0; x < fileNames.Length; x++)
                {
                    
                    names.Add(fileNames[x]);
                }
            }

        }
        private void sortAlph()
        {
            Alphnames.Sort();
            for (int i = 0; i < Alphnames.Count; i++)
            {
                rvrsAlphNames.Add(Alphnames[i]);
                lstAlph.Items.Add(Alphnames[i]);
            }
        }
        private void sortRvrsAlph()
        {
            rvrsAlphNames.Reverse();
            for (int i = 0; i < rvrsAlphNames.Count; i++)
            {
                lstRvrsAlph.Items.Add(rvrsAlphNames[i]);

            }
        }
        private void sortLastName()
        {
            for (int i = 0; i < names.Count; i++)
            {
                string name = names[i];
                string[] lastName = name.Split(' ');
                lastNames.Add(lastName[1]);

                lstLastName.Items.Add(lastNames[i]);
            }
        }
  
    }
}