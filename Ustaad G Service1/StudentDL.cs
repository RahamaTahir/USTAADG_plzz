using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Ustaad_G_Service1
{
    public class StudentDL
    {
        public static List<Student> Students = new List<Student>();

        [DataMember]
        public static List<Teacher> selectedteachers = new List<Teacher>();


        public void AddStudent(string username, string age, string secret_Question, string answer, string contact_no, string password, string cPassword, string gender, string range, string area, string timing)
        {
            Student st = new Student();
            st.Username = username;
            st.Password = password;
            st.Area = area;
            st.Range = range;
            st.Timing = timing;
            st.Gender = gender;
            st.Secret_Question = secret_Question;
            st.Age = age;
            st.Answer = answer;
            st.CPassword = cPassword;
            st.Contact_no = contact_no;
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

        public static Student verify(string username, string password)
        {
            foreach (Student st in Students)
            {
                if (st.Username == username && st.Password == password)
                {
                    return st;
                }
            }
            return null;
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

        public Boolean isUniqueS (string username)
        {
            foreach (Student s in StudentDL.Students)
            {
                if (s.Username == username)
                { return false; }
            }
            return true;

        }

        public void EditStudentDetails(string password, string username, string age, string contactno)
        {
            foreach (Student s in Students)
            {
                if (s.Password == password)
                {
                    s.Username = username;
                    s.Age = age;
                    s.Contact_no = contactno;
                }
            }
        }

        public bool isfoundStudent(string password)
        {

            foreach (Student s in StudentDL.Students)
            {
                if (s.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public string pay(string ID, string account)
        {

            foreach (Teacher T in StudentDL.selectedteachers)
            {
                if (T.Id.ToString() == ID)
                {
                    if (T.receive == false)
                    {
                        int m;
                        m = int.Parse(account) - int.Parse(T.Range);
                        T.Paid = true;
                        account = m.ToString();
                        T.receive = true;
                    }

                }
            }
            return account;
        }

        public void reportStudent(Student s)
        {
            int R;
 
            foreach(Student x in StudentDL.Students)
            {
                if(s.Username == x.Username)
                {
                    R =int.Parse(x.Report);
                    R++;
                    x.Report = R.ToString();
                }
            }
            
        }



    }
}