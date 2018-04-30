using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ustaad_G_Service1
{
    public class StudentDL
    {
        public static List<Student> Students = new List<Student>();

        public void AddStudent(string username, string age, string secret_Question, string answer, string contact_no, string password, string cPassword , string gender, string range, string area, string timing)
        {
            Student st = new Student();
            st.Username = username;
            st.Password = password;
            st.Secret_Question = secret_Question;
            st.Age = age;
            st.Area = area;
            st.Range = range;
            st.Timing = timing;
            st.Gender = gender;
            st.Answer = answer;
            st.CPassword = cPassword;
            Students.Add(st);
        }

        public static void NewPasswordS(string username, string newPassword)
        {
            foreach (Student s in Students)
            {
                if (s.Username == username)
                {
                    s.Password = newPassword;
                }
            }
        }

        public static bool verify(string username, string password)
        {
            foreach (Student st in Students)
            {
                if (st.Username == username && st.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isfoundS(string username)
        {

            foreach (Student s in StudentDL.Students)
            {
                if (s.Username == username)
                { 
                    return true;
                }
            }
            return false;
        }


        public bool ResetPasswordS(string username,string secret_Question, string secret_answer)
        {
            foreach (Student s in StudentDL.Students)
            {
                if (s.Username == username)
                {
                    if (secret_Question == s.Secret_Question && secret_answer == s.Answer)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Boolean VerifyByAdmin(string username, string password)
        {
            foreach (Student st in Students)
            {
                if (st.Username == username && st.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Student> ShowAllStudents()
        {
            List<Student> All_Students = new List<Student>();
            foreach (Student s in StudentDL.Students)
            {
                All_Students.Add(s);
            }
            return All_Students;
        }


    }
}