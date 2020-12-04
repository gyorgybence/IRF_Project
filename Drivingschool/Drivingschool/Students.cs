using DrivingSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivingschool
{
    public class Students
    {
     

        private List<Student> students;
        public Students() {
            students = new List<Student>();
        }

        public void addStudent(Student s) {
            students.Add(s);
        }
        public int studentsNumber() { return students.Count; }
    }
}
