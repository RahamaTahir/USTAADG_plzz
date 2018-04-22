using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ustaad_G_Service1
{
    public class StudentDL
    {
        public static List<Student> Students = new List<Student>();

        public void AddStudent(string username, string age, string secret_Question, string answer, string contact_no, string password, string cPassword)
        {
            Student st = new Student();
            st.Username = username;
            st.Password = password;
            st.Secret_Question = secret_Question;
            st.Age = age;
            st.Answer = answer;
            st.CPassword = cPassword;
            Students.Add(st);
        }

    }
}