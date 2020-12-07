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
            if (StudentList.Find(x => x.IDNum == s.IDNum && x.Category == s.Category) == null)
            {
                StudentList.Add(s);
            }
            else
            {
                MessageBox.Show(s.Name + "A tanuló szerepel a rendszerben");
            }
        }
        public Student getStudent (string id, Categories cat) 
            {
            return StudentList.Find(x => x.IDNum == id && x.Category == cat);
            }
           
        
        public int studentsNumber() { return StudentList.Count; }
    }
}
