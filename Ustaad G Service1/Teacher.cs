using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ustaad_G_Service1
{
    public class Teacher
    {
        private string username;
        private static string idNo;
        private string age;
        private string gender;
        private string secret_Question;
        private string answer;
        private string contact_no;
        private string password;
        private string cPassword;
        private string timing;
        private string area;
        private string range;
        private string subject;
        private string level;
        private string account_no;
        private string account;

        public string Username { get => username; set => username = value; }
        public static string IdNo { get => idNo; set => idNo = value; }
        public string Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Secret_Question { get => secret_Question; set => secret_Question = value; }
        public string Answer { get => answer; set => answer = value; }
        public string Contact_no { get => contact_no; set => contact_no = value; }
        public string Password { get => password; set => password = value; }
        public string CPassword { get => cPassword; set => cPassword = value; }
        public string Timing { get => timing; set => timing = value; }
        public string Area { get => area; set => area = value; }
        public string Range { get => range; set => range = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Level { get => level; set => level = value; }
        public string Account_no { get => account_no; set => account_no = value; }
        public string Account { get => account; set => account = value; }
    }
}