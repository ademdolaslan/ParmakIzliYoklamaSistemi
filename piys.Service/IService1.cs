using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Bitirme_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Lessonsbyteachers> GetData(string ID);

        [OperationContract]
        string teacherLogin(string uname, string upw);
        [OperationContract]
        List<TeacherInfo> teacherInfo(string ID);


    }


    
    [DataContract]
    public class TeacherInfo
    {
        string tid = "";
        string tname = "";
        string tsurname = "";
        string ttitle = "";              
        string tdep = "";
        string tmail = "";
        string tphone = "";       

        [DataMember]
        public string TeacherID
        {
            get { return tid; }
            set { tid = value; }
        }        
        [DataMember]
        public string TeacherName
        {
            get { return tname; }
            set { tname = value; }
        }
        [DataMember]
        public string TeacherSurname
        {
            get { return tsurname; }
            set { tsurname = value; }
        }
        [DataMember]
        public string TeacherTitle
        {
            get { return ttitle; }
            set { ttitle = value; }
        }
        [DataMember]
        public string TeacherDepartment
        {
            get { return tdep; }
            set { tdep = value; }
        }
        [DataMember]
        public string TeacherMail
        {
            get { return tmail; }
            set { tmail = value; }
        }
        [DataMember]
        public string TeacherPhone
        {
            get { return tphone; }
            set { tphone = value; }
        }

    }

    [DataContract]
    public class Lessonsbyteachers
    {
        string tid="";
        string ttitle="";
        string tname = "";
        string tsurname = "";
        string lid = "";
        string lname = "";
        string lsemester = "";
        string lhour = "";
        string lakts = "";

        [DataMember]
        public string TeacherID
        {
            get { return tid; }
            set { tid = value; }
        }
        [DataMember]
        public string TeacherTitle
        {
            get { return ttitle; }
            set { ttitle = value; }
        }
        [DataMember]
        public string TeacherName
        {
            get { return tname; }
            set { tname = value; }
        }
        [DataMember]
        public string TeacherSurname
        {
            get { return tsurname; }
            set { tsurname = value; }
        }
        [DataMember]
        public string LessonID
        {
            get { return lid; }
            set { lid = value; }
        }
        [DataMember]
        public string LessonName
        {
            get { return lname; }
            set { lname = value; }
        }
        [DataMember]
        public string LessonSemester
        {
            get { return lsemester; }
            set { lsemester = value; }
        }
        [DataMember]
        public string LessonHour
        {
            get { return lhour; }
            set { lhour = value; }
        }
        [DataMember]
        public string LessonAKTS
        {
            get { return lakts; }
            set { lakts = value; }
        }
    }
}
