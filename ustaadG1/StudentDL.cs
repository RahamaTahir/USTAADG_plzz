using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ustaadG1
{
    class StudentDL
    {
        private static List<Student> students;

        internal static List<Student> Students { get => students; set => students = value; }

        public Boolean Verify(string Area);
        public Teacher SelectTutor(Teacher T);
        public void DeleteStudent(Student S);
        public void ShowStudentDetails(Student S);
        public void PayFee(int Fee);
        public void EditDetails(string name, int age, string cntctNo, string area, string range);
        public void AddStudent()string username,string age,string secret_Question, string answer, string contact_no,string password, string cPassword);
    }
}
