using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ustaadG1
{
    class TeacherDL
    {
        private List<Teacher> teachers;

        internal List<Teacher> Teachers { get => teachers; set => teachers = value; }

        public Boolean ReportStudent(Student S);
        public void DeleteTeacher(Teacher T);
        public List<Teacher> SearchTeacher(string area);
        public void ShowTeacherDetails(Teacher T);
        public int RecieveHalfTransaction(int fee);
        public void EditDetails(string name, int age, string cntctNo, string area, string range);
        public void AddTeacher(string username, string age, string secret_Question, string answer, string contact_no, string password, string cPassword, string subject, string level, string timing, string area, string range);
    }
}
