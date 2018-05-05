using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ustaad_G_Service1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);
        [OperationContract]
        void NewPasswordT(string username, string newPassword);
        [OperationContract]
        void NewPasswordS(string username, string newPassword);
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        void AddStudent(string username, string age, string secret_Question, string answer, string contact_no, string password, string cPassword, string gender, string range, string area, string timing);

        [OperationContract]

        void AddTeacher(string gender ,string username, string age, string secret_Question, string answer, string contact_no, string password, string cPassword, string subject, string level, string timing, string area, string range);

        [OperationContract]
        Student verifyStudent(string username, string password);
        [OperationContract]
        Teacher verifyteacher(string username, string password);
        [OperationContract]
        void addRating(string rating);
        [OperationContract]
        bool isfoundT(string username);

        [OperationContract]
        bool isfoundS(string username);

        [OperationContract]
        bool ResetPasswordS(string username, string secret_Question, string secret_answer);

        [OperationContract]
        bool ResetPasswordT(string username, string secret_Question, string secret_answer);

        [OperationContract]
        Boolean VerifyByAdmin(string username, string password);

        [OperationContract]
        List<Teacher> Search_Teacher(string city);

        [OperationContract]
        List<Teacher> ShowAllTeachers();

        [OperationContract]
        List<Student> ShowAllStudents();

        [OperationContract]
        Boolean isUniqueT(string username);

        [OperationContract]
        Boolean isUniqueS(string username);

        [OperationContract]
        List<Teacher> selected_teachers(Teacher t);

        [OperationContract]
        string Calculate_rating();

        [OperationContract]
        void EditStudentDetails(string password, string username, string age, string contactno);

        [OperationContract]
        void EditTeacherDetails(string password, string username, string age, string contactno);

        [OperationContract]
        bool isfoundTeacher(string password);

        [OperationContract]
        bool isfoundStudent(string password);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
