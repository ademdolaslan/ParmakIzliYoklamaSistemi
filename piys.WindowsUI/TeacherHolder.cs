using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoklama_Desktop
{
    class TeacherHolder
    {
        string tid = "";
        string tname = "";
        string tsurname = "";
        string ttitle = "";
        string tdep = "";
        string tmail = "";
        string tphone = "";

        
        public string TeacherID
        {
            get { return tid; }
            set { tid = value; }
        }
        
        public string TeacherName
        {
            get { return tname; }
            set { tname = value; }
        }
        
        public string TeacherSurname
        {
            get { return tsurname; }
            set { tsurname = value; }
        }
        
        public string TeacherTitle
        {
            get { return ttitle; }
            set { ttitle = value; }
        }
        
        public string TeacherDepartment
        {
            get { return tdep; }
            set { tdep = value; }
        }
        
        public string TeacherMail
        {
            get { return tmail; }
            set { tmail = value; }
        }
        
        public string TeacherPhone
        {
            get { return tphone; }
            set { tphone = value; }
        }



    }
}
