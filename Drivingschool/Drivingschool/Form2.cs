using DrivingSchool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DrivingSchool.Student;

namespace Drivingschool
{
    
    public partial class Form2 : Form
    {
        private Student student;
       
        public Form2(Student s)
        {
            student = s;
            InitializeComponent();
           

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = student.Name;
            textBox2.Text = student.BirthPlace;
            dateTimePicker1.Value = student.BirthDate;
            textBox4.Text = student.MotherName;
            textBox5.Text = student.Country;
            textBox6.Text = student.PostalCode;
            textBox7.Text = student.City;
            textBox8.Text = student.Address;
            textBox9.Text = student.Phone;
            textBox10.Text = student.Email;
            comboBox1.DataSource = Enum.GetValues(typeof(Categories));
            comboBox1.SelectedItem = student.Category;
            textBox11.Text = student.IDNum;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            student.Name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            student.BirthPlace = textBox2.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            student.MotherName = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            student.Country = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            student.PostalCode = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            student.City = textBox7.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            student.Address = textBox8.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            student.Phone = textBox9.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            student.Email = textBox10.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            student.IDNum = textBox11.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            student.BirthDate = dateTimePicker1.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            student.Category = new Student().stringToEnum(comboBox1.SelectedItem.ToString());
        }
    }
}
