using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoklama_Desktop
{
    public partial class PersonHolder
    {
        string tid = "";
        string ttitle = "";
        string tname = "";
        string tsurname = "";
        string lid = "";
        string lname = "";
        string lsemester = "";
        string lhour = "";
        string lakts = "";


        public string TeacherID
        {
            get { return tid; }
            set { tid = value; }
        }

        public string TeacherTitle
        {
            get { return ttitle; }
            set { ttitle = value; }
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

        public string LessonID
        {
            get { return lid; }
            set { lid = value; }
        }

        public string LessonName
        {
            get { return lname; }
            set { lname = value; }
        }

        public string LessonSemester
        {
            get { return lsemester; }
            set { lsemester = value; }
        }

        public string LessonHour
        {
            get { return lhour; }
            set { lhour = value; }
        }

        public string LessonAKTS
        {
            get { return lakts; }
            set { lakts = value; }
        }
    }
}