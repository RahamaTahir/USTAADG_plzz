using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ustaad_G_Service1
{
    public class Student
    {
        private string username;
        private static string idNo;
        private string verify;
        private string age;
        private string gender;
        private string secret_Question;
        private string answer;
        private string contact_no;
        private string credit_card_no;
        private string password;
        private string cPassword;
        private string timing;
        private string area;
        private string range;
        private bool select;


        public string Username { get => username; set => username = value; }
        public static string IdNo { get => idNo; set => idNo = value; }
        public string Verify { get => verify; set => verify = value; }
        public string Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Secret_Question { get => secret_Question; set => secret_Question = value; }
        public string Answer { get => answer; set => answer = value; }
        public string Contact_no { get => contact_no; set => contact_no = value; }
        public string Credit_card_no { get => credit_card_no; set => credit_card_no = value; }
        public string Password { get => password; set => password = value; }
        public string CPassword { get => cPassword; set => cPassword = value; }
        public string Timing { get => timing; set => timing = value; }
        public string Area { get => area; set => area = value; }
        public string Range { get => range; set => range = value; }
        public bool Select { get => select; set => select = value; }
    }
}