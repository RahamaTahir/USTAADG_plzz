using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ustaad_G_Service1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Service1()
        {
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public void NewPasswordT(string username, string newPassword)
        {
            TeacherDL.NewPasswordT(username, newPassword);
        }

        public void NewPasswordS(string username, string newPassword)
        {

            StudentDL.NewPasswordS(username, newPassword);
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void AddStudent(string username, string age, string secret_Question, string answer, string contact_no, string password, string cPassword, string gender, string range, string area, string timing)
        {
            StudentDL st = new StudentDL();
            st.AddStudent(username, age, secret_Question, answer, contact_no, password, cPassword, gender, range, area, timing);
        }

        public void AddTeacher(string gender, string username, string age, string secret_Question, string answer, string contact_no, string password, string cPassword, string subject, string level, string timing, string area, string range)
        {
            TeacherDL tc = new TeacherDL();
            tc.AddTeacher(gender, username, age, secret_Question, answer, contact_no, password, cPassword, subject, level, timing, area, range);
        }


        public Student verifyStudent(string username, string password)
        {
            return StudentDL.verify(username, password);
        }

        public void addRating(string rating)
        {
            Admin.addRating(rating);
        }
        public Teacher verifyteacher(string username, string password)
        {

            return TeacherDL.verify(username, password);
        }

        public bool isfoundT(string username)
        {
            TeacherDL tc = new TeacherDL();
            return tc.isfoundT(username);
        }

        public bool isfoundS(string username)
        {
            StudentDL st = new StudentDL();
            return st.isfoundS(username);
        }

        public bool ResetPasswordS(string username, string secret_Question, string secret_answer)
        {
            StudentDL st = new StudentDL();
            return st.ResetPasswordS(username, secret_Question, secret_answer);
        }

        public bool ResetPasswordT(string username, string secret_Question, string secret_answer)
        {
            TeacherDL tc = new TeacherDL();
            return tc.ResetPasswordT(username, secret_Question, secret_answer);
        }

        public bool VerifyByAdmin(string username, string password)
        {
            StudentDL st = new StudentDL();
            return st.VerifyByAdmin(username, password);
        }

        public List<Teacher> Search_Teacher(string city)
        {
            TeacherDL tc = new TeacherDL();
            return tc.Search_Teacher(city);
        }

        public List<Teacher> ShowAllTeachers()
        {
            TeacherDL tc = new TeacherDL();
            return tc.ShowAllTeachers();
        }

        public List<Student> ShowAllStudents()
        {
            StudentDL st = new StudentDL();
            return st.ShowAllStudents();
        }

        public Boolean isUniqueT(string username)
        {
            TeacherDL t = new TeacherDL();
            return t.isUniqueT(username);
        }

        public Boolean isUniqueS(string username)
        {
            StudentDL s = new StudentDL();
            return s.isUniqueS(username);
        }

        public List<Teacher> selected_teachers(Teacher t)
        {
            TeacherDL T = new TeacherDL();
            return T.selected_teachers(t);
        }
        public string Calculate_rating()
        {
            Admin st = new Admin();
            return st.Calculate_rating();

        }

        public void EditStudentDetails(string password, string username, string age, string contactno)
        {
            StudentDL st = new StudentDL();
            st.EditStudentDetails(password, username, age, contactno);
        }

        public void EditTeacherDetails(string password, string username, string age, string contactno)
        {
            TeacherDL T = new TeacherDL();
            T.EditTeacherDetails(password, username, age, contactno);
        }

        public bool isfoundStudent(string password)
        {
            StudentDL s = new StudentDL();
            return s.isfoundStudent(password);
        }

        public bool isfoundTeacher(string password)
        {
            TeacherDL T = new TeacherDL();
            return T.isfoundTeacher(password);
        }

        public string pay(string ID, string account)
        {
            StudentDL s = new StudentDL();
            return s.pay(ID, account);
        }

        public string receive(string username, string account)
        {
            TeacherDL t = new TeacherDL();
            return t.receive(username, account);
        }

        public void reportStudent(Student s)
        {
            StudentDL f = new StudentDL();
            f.reportStudent(s);
        }

        public List<Teacher> get_TL(Student s)
        {
            return s.Teachers_select;
        }

        public Student selected_teachers_st(int id, Student student)
        {
            return TeacherDL.kuch_Bhi(id, student);
        }

    }
}
