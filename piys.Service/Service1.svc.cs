using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Bitirme_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inspection;Integrated Security=True");
        public List<Lessonsbyteachers> GetData(string ID)
        {
            try
            {
                Lessonsbyteachers lbtc = new Lessonsbyteachers();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Lessonsbyteachers where Lessonsbyteachers.TeacherID='" + long.Parse(ID) + "'", con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dr.Read();
                lbtc.TeacherID = dr["TeacherID"].ToString();
                lbtc.TeacherTitle = dr["TeacherTitle"].ToString();
                lbtc.TeacherName = dr["TeacherName"].ToString();
                lbtc.TeacherSurname = dr["TeacherSurname"].ToString();
                lbtc.LessonID = dr["LessonID"].ToString();
                lbtc.LessonName = dr["LessonName"].ToString();
                lbtc.LessonSemester = dr["LessonSemester"].ToString();
                lbtc.LessonHour = dr["LessonHour"].ToString();
                lbtc.LessonAKTS = dr["LessonAKTS"].ToString();
                List<Lessonsbyteachers> list = new List<Lessonsbyteachers>();
                list.Add(lbtc);
                foreach (var item in dr)
                {
                    list.Add(new Lessonsbyteachers()
                    {
                        TeacherID = dr["TeacherID"].ToString(),
                        TeacherTitle = dr["TeacherTitle"].ToString(),
                        TeacherName = dr["TeacherName"].ToString(),
                        TeacherSurname = dr["TeacherSurname"].ToString(),
                        LessonID = dr["LessonID"].ToString(),
                        LessonName = dr["LessonName"].ToString(),
                        LessonSemester = dr["LessonSemester"].ToString(),
                        LessonHour = dr["LessonHour"].ToString(),
                        LessonAKTS = dr["LessonAKTS"].ToString()
                    });
                }
                return list;
                con.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public string teacherLogin(string uname, string upw)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Teachers where Teachers.TeacherUserID LIKE '" + uname.ToString() + "' and Teachers.TeacherPassword LIKE '" + upw.ToString() + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return dr["TeacherID"].ToString();
                }
                else
                {
                    return "";
                }
                con.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
                       
        }

        public List<TeacherInfo> teacherInfo(string ID)
        {
            try
            {
                TeacherInfo info = new TeacherInfo();
                con.Open();
                SqlCommand cmd = new SqlCommand("select TeacherID, TeacherName, TeacherSurname, TeacherTitle, TeacherDepartment, TeacherMail, TeacherPhone from Teachers where TeacherID='" + long.Parse(ID) + "'", con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    info.TeacherID = dr["TeacherID"].ToString();
                    info.TeacherName = dr["TeacherName"].ToString();
                    info.TeacherSurname = dr["TeacherSurname"].ToString();
                    info.TeacherTitle = dr["TeacherTitle"].ToString();
                    info.TeacherDepartment = dr["TeacherDepartment"].ToString();
                    info.TeacherMail = dr["TeacherMail"].ToString();
                    info.TeacherPhone = dr["TeacherPhone"].ToString();
                    List<TeacherInfo> list = new List<TeacherInfo>();
                    list.Add(info);
                    return list;
                }
                else
                {
                    info.TeacherID = "";
                    info.TeacherName = "";
                    info.TeacherSurname = "";
                    info.TeacherTitle = "";
                    info.TeacherDepartment = "";
                    info.TeacherMail = "";
                    info.TeacherPhone = "";
                    List<TeacherInfo> list = new List<TeacherInfo>();
                    list.Add(info);
                    return list;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }            
        }

        public string yoklama(string lessonid, string fingerid, string day, string week, string firsth, string lasth)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Inspections set InspectionLessonFirstHalf = "+int.Parse(firsth)+ ", InspectionLessonLastHalf = " + int.Parse(lasth) + " where InspectionLessonID='"+lessonid.ToString()+ "' and InspectionWeekID=" + int.Parse(week) + " and InspectionDayID=" + int.Parse(day) + " and InspectionStudentID=(Select StudentID from Students where StudentFingerID=" + int.Parse(fingerid) + ")";
                cmd.ExecuteNonQuery();
                return "success";
                con.Close();
                
            }
            catch (Exception ex)
            {

                return "error";
            }            
        }
    }
}
