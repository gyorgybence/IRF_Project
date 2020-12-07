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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void csvImportálásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV fájlok | *csv" })
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    //MessageBox.Show(ofd.FileName);
                    
                    using (var reader = new StreamReader(ofd.FileName)) {
                        reader.ReadLine(); // Első sor (fejlécek)
                        while (!reader.EndOfStream) {

                            var line = reader.ReadLine();
                            var adatok = line.Split(';');
                            Student s = new Student(adatok);
                            students.addStudent(s);
                            
                            
                        }
                    }
                }
                // MessageBox.Show(students.studentsNumber().ToString());
            }
            listView1.Items.Clear();
            foreach ( var s in students.StudentList)
            {
                listView1.Items.Add(new ListViewItem(s.getArray()));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count ==1)
            {
                var id = listView1.SelectedItems[0].SubItems[10].Text;
                var category = new Student().stringToEnum(listView1.SelectedItems[0].SubItems[11].Text);
                Student selectedStudent = students.getStudent(id, category);
                //MessageBox.Show(selectedStudent.Name);
                var f2 = new Form2(selectedStudent);
                f2.Show();
            }
        }
    }
}
