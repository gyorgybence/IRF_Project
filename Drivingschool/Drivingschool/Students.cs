using DrivingSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DrivingSchool.Student;

namespace Drivingschool
{
    public class Students
    {
     
        public List<Student> StudentList { get; private set; }
        public Students() {
            StudentList = new List<Student>();
        }

        public void addStudent(Student s) {
            if (StudentList.Find(x => x.Azonosito==s.Azonosito) == null)
            {
                StudentList.Add(s);
            }
            else
            {
                MessageBox.Show(s.Name + "A tanuló szerepel a rendszerben");
            }
        }
        public Student getStudent (string azonosito) 
            {
            return StudentList.Find(x => x.Azonosito == azonosito);
            }
           
        
        

        
    }
}
