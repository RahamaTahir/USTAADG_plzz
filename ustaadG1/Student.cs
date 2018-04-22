using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ustaadG1
{
    class Student
    {
        private string username;
        private string idNo;
        private int verify;
        private int age;
        private string gender;
        private string secret_Question;
        private string answer;
        private string contact_no;
        private string credit_card_no;
        private string password;
        private string cPassword;
        private DateTime timing;
        private string area;
        private string range;

        public string Username { get => username; set => username = value; }
        public string IdNo { get => idNo; set => idNo = value; }
        public int Verify { get => verify; set => verify = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Answer { get => answer; set => answer = value; }
        public string Password { get => password; set => password = value; }
        public string CPassword { get => cPassword; set => cPassword = value; }
        public DateTime Timing { get => timing; set => timing = value; }
        public string Area { get => area; set => area = value; }
        public string Range { get => range; set => range = value; }
        public string Secret_Question { get => secret_Question; set => secret_Question = value; }
        public string Contact_no { get => contact_no; set => contact_no = value; }
        public string Credit_card_no { get => credit_card_no; set => credit_card_no = value; }
    }
}
