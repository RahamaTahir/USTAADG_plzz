﻿using System;
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



    }
}