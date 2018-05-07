using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace Ustaad_G_Service1
{
    [DataContract]
    public class Student
    {
        private string username;
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
        private string account = "50000";
        private string report="0";
        private List<Teacher> teachers_select = new List<Teacher>();

        [DataMember]
        public string Username { get => username; set => username = value; }

        [DataMember]
        public string Age { get => age; set => age = value; }

        [DataMember]
        public string Gender { get => gender; set => gender = value; }

        [DataMember]
        public string Secret_Question { get => secret_Question; set => secret_Question = value; }

        [DataMember]
        public string Answer { get => answer; set => answer = value; }

        [DataMember]
        public string Contact_no { get => contact_no; set => contact_no = value; }

        [DataMember]
        public string Credit_card_no { get => credit_card_no; set => credit_card_no = value; }

        [DataMember]
        public string Password { get => password; set => password = value; }

        [DataMember]
        public string CPassword { get => cPassword; set => cPassword = value; }

        [DataMember]
        public string Timing { get => timing; set => timing = value; }

        [DataMember]
        public string Area { get => area; set => area = value; }

        [DataMember]
        public string Range { get => range; set => range = value; }

        [DataMember]
        public string Account { get => account; set => account = value; }

        [DataMember]
        public string Report { get => report; set => report = value; }

        [DataMember]
        public List<Teacher> Teachers_select { get => teachers_select; set => teachers_select = value; }
    }
}