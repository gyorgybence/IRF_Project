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
                    var student = new Student();
                    using (var reader = new StreamReader(ofd.FileName)) {
                        reader.ReadLine(); // Első sor (fejlécek)
                        while (!reader.EndOfStream) {

                            var line = reader.ReadLine();
                            var adatok = line.Split(';');
                            Student s = new Student();

                            s.Name = adatok[0];
                            s.BirthPlace = adatok[1];
                            s.BirthDate = DateTime.Parse(adatok[2]);
                            s.MotherName = adatok[3];
                            s.Country = adatok[4];
                            s.PostalCode = adatok[5];
                            s.City = adatok[6];
                            s.Address = adatok[7];
                            s.Phone = adatok[8];
                            s.Email = adatok[9];
                            s.IDNum = adatok[10];
                            s.Category = s.stringToEnum(adatok[11]);

                            students.addStudent(s);
                            
                        }
                    }
                }
                MessageBox.Show(students.studentsNumber().ToString());
            }
        }
    }
}
