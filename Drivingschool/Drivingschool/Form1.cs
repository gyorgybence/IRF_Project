using DrivingSchool;
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

namespace Drivingschool
{
    
    public partial class Form1 : Form
    {
        public Students students; 


        public Form1()
        {
            InitializeComponent();
            students = new Students(); 
        }

       

        private void csvImportálásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV fájlok | *csv" })
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    
                    
                    using (var reader = new StreamReader(ofd.FileName)) {
                        try
                        {
                            reader.ReadLine(); 
                            while (!reader.EndOfStream)
                            {

                                var line = reader.ReadLine();
                                var adatok = line.Split(';');
                                Student s = new Student(adatok); 
                                students.addStudent(s);


                            }
                        }
                        catch(Exception ex) 
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    refreshlistview(); 
                }
                
            }
            
        }
        public void refreshlistview()
        {
            listView1.Items.Clear(); 
            foreach (var s in students.StudentList)
            {
                listView1.Items.Add(new ListViewItem(s.getArray()));
            }
        }



        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count ==1)
            {
                var azon = listView1.SelectedItems[0].SubItems[12].Text;
                Student selectedStudent = students.getStudent(azon); 
                var f2 = new Form2(selectedStudent); 
                f2.ShowDialog();
                refreshlistview(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Student> selected = new List<Student>(); 
            foreach (ListViewItem item in listView1.SelectedItems) 
            {
                var azon = item.SubItems[12].Text; 
                selected.Add(students.getStudent(azon)); 
            }
            var exp = new Excelexport();
            exp.Export(selected); 

           

        }
        
    }
}
