using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ustaad_G_Service1
{
    public class TeacherDL
    {
        public static List<Teacher> Teachers = new List<Teacher>();

        public void AddTeacher(string username, string age, string secret_Question, string answer, string contact_no, string password, string cPassword, string subject, string level, string timing, string area, string range)
        {
            Teacher tc = new Teacher();
            tc.Username = username;
            tc.Password = password;
            tc.Range = range;
            tc.Secret_Question = secret_Question;
            tc.Timing = timing;
            tc.Age = age;
            tc.Area = area;
            tc.Answer = answer;
            tc.CPassword = cPassword;
            tc.Subject = subject;
            tc.Level = level;
            Teachers.Add(tc);
        }

        public static void NewPasswordT(string username, string newPassword)
        {
            foreach (Teacher t in Teachers)
            {
                if (t.Username == username)
                {
                    t.Password = newPassword;
                }
            }
        }
        public static bool verify(string username, string password)
        {
            foreach (Teacher tc in Teachers)
            {
                if (tc.Username == username && tc.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public  bool isfoundT(string username)
        {
            foreach (Teacher t in TeacherDL.Teachers)
            {
                if (t.Username == username)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ResetPasswordT(string username,string secret_Question, string secret_answer)
        {
            foreach (Teacher t in TeacherDL.Teachers)
            {
                if (t.Username == username)
                {
                    if (secret_Question == t.Secret_Question && secret_answer == t.Answer)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}