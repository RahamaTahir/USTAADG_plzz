﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace Ustaad_G_Service1
{
    public class TeacherDL
    {
        public static List<Teacher> Teachers = new List<Teacher>();

        public static int idno = 1200;

        public void AddTeacher(string gender ,string username, string age, string secret_Question, string answer, string contact_no, string password, string cPassword, string subject, string level, string timing, string area, string range)
        {
            Teacher tc = new Teacher();
            tc.Username = username;
            tc.Password = password;
            tc.Range = range;
            tc.Gender = gender;
            tc.Secret_Question = secret_Question;
            tc.Timing = timing;
            tc.Age = age;
            tc.Area = area;
            tc.Answer = answer;
            tc.CPassword = cPassword;
            tc.Subject = subject;
            tc.Level = level;
            idno = idno + 5;
            tc.Id = idno;
            tc.Contact_no = contact_no;
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
        public static Teacher verify(string username, string password)
        {
            foreach (Teacher tc in Teachers)
            {
                if (tc.Username == username && tc.Password == password)
                {
                    return tc;
                }
            }
            return null;
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
        public List<Teacher> Search_Teacher(string city)
        {
            List<Teacher> Avail_Teachers = new List<Teacher>();
            foreach (Teacher t in TeacherDL.Teachers)
            {
                if (t.Area == city)
                {
                    Avail_Teachers.Add(t);
                }
            }
            return Avail_Teachers;
        }

        public List<Teacher> ShowAllTeachers()
        {
            List<Teacher> All_Teachers = new List<Teacher>();
            foreach (Teacher t in TeacherDL.Teachers)
            {
                All_Teachers.Add(t);
            }
            return All_Teachers;
        }

        public List<Teacher> selected_teachers(Teacher t)
        {
            StudentDL.selectedteachers.Add(t);
            return StudentDL.selectedteachers;
        }

        public Boolean isUniqueT(string username)
        {
            foreach (Teacher t in TeacherDL.Teachers)
            {
                if (t.Username == username)
                { return false; }
            }
            return true;

        }

        public void EditTeacherDetails(string password, string username, string age, string contactno)
        {
            foreach (Teacher t in Teachers)
            {
                if (t.Password == password)
                {
                    t.Username = username;
                    t.Age = age;
                    t.Contact_no = contactno;
                }
            }
        }

        public bool isfoundTeacher(string password)
        {
            foreach (Teacher t in TeacherDL.Teachers)
            {
                if (t.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public string receive(string username, string account)
        {
            foreach (Teacher T in StudentDL.selectedteachers)
            {
                if (T.Paid == true)
                {
                    int a, b;
                    T.receive = true;
                    a = int.Parse(T.Account) + int.Parse(T.Range) / 2;
                    T.Account = a.ToString();
                    b = int.Parse(Admin.Profit) + int.Parse(T.Range) / 2;
                    Admin.Profit = b.ToString();
                    account = a.ToString();
                    T.Paid = false;
                }

            }
            return account;
        }

        public static Student kuch_Bhi(int id, Student s)
        {
            foreach (Teacher t in TeacherDL.Teachers)
            {
                if (t.Id == id)
                {
                    s.Teachers_select.Add(t);
                }
            }
            return s;
        }

    }
}