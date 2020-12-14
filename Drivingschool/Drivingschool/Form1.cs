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
        public Students students; // a lista egy példánya


        public Form1()
        {
            InitializeComponent();
            students = new Students(); // üres lista lesz belőle a null helyett
        }

       

        private void csvImportálásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV fájlok | *csv" })
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    //MessageBox.Show(ofd.FileName);
                    
                    using (var reader = new StreamReader(ofd.FileName)) {
                        try
                        {
                            reader.ReadLine(); // Első sor (fejlécek)
                            while (!reader.EndOfStream)
                            {

                                var line = reader.ReadLine();
                                var adatok = line.Split(';');
                                Student s = new Student(adatok); // itt hozzuk létre a tanulót 
                                students.addStudent(s);


                            }
                        }
                        catch(Exception ex) 
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    refreshlistview(); // frissiti a listview elemeit, azért mert beolvastuk a csv és hozzáadtam az adatokhpz de nem tettem bele a listviewbe
                }
                // MessageBox.Show(students.studentsNumber().ToString());
            }
            
        }
        public void refreshlistview()
        {
            listView1.Items.Clear(); // törli, mindig bent ragadna az adat
            foreach (var s in students.StudentList)
            {
                listView1.Items.Add(new ListViewItem(s.getArray()));// végig járom ha vannak adatok és hozzáadom a diákot a listview-be és mivel töbmböt kért itt jön elő a getarray függvény
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count ==1)
            {
                var azon = listView1.SelectedItems[0].SubItems[12].Text; // kiszedi annak a tanulónak az azonositóját aki kattintottam
                Student selectedStudent = students.getStudent(azon); //  lekérdezi azt a tanuló objektumot akihez az azonosito tartotik
                //MessageBox.Show(selectedStudent.Name);
                var f2 = new Form2(selectedStudent); // megjeleniti a form2-őn az előbb lekérdezett a tanulót
                f2.ShowDialog();
                refreshlistview(); // ha átírsz valamit akkor nem frissül a listview , de az objektum az igen.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Student> selected = new List<Student>(); // kiválasztott tanulók listája
            foreach (ListViewItem item in listView1.SelectedItems) // végigmegyek a kiválasztottakon
            {
                var azon = item.SubItems[12].Text; // azonositóját kiszedem a kiválasztottaknak
                selected.Add(students.getStudent(azon)); // lekérdezem az azonososító alapján a kiválasztott tanulókat és hozzáadom a selected listához.
            }
            var exp = new Excelexport();
            exp.Export(selected); // az excelexport osztályból csak a export függvény kell így példényosítom az osztályt

           

        }
        
    }
}
