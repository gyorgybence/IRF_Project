﻿using DrivingSchool;
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
                            listView1.Items.Add(new ListViewItem(s.getArray()));
                            
                        }
                    }
                }
                // MessageBox.Show(students.studentsNumber().ToString());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                MessageBox.Show(item.SubItems[1].ToString());
            }
        }
    }
}
