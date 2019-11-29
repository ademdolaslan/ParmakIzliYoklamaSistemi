using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bitirme_Service.Controllers
{
    public class DefaultController : Controller
    {
        Service1 svc = new Service1();
        public string Lessons(string ID)
        {
            Service1 svc = new Service1();
            List<Lessonsbyteachers> liste = new List<Lessonsbyteachers>();
            liste = svc.GetData(ID).ToList();
            var json = JsonConvert.SerializeObject(liste);
            return json;
        }
        public string Login(string userid, string userpassword)
        {
            return svc.teacherLogin(userid, userpassword).ToString();
        }
        public string Teacher(string ID)
        {
            Service1 svc = new Service1();
            List<TeacherInfo> liste = new List<TeacherInfo>();
            liste = svc.teacherInfo(ID).ToList();
            var json = JsonConvert.SerializeObject(liste);
            return json;
        }
        public string inspection(string lessonid,string fid,string day,string week,string firsth,string lasth)
        {
            Service1 svc = new Service1();
            var response = svc.yoklama(lessonid, fid, day, week, firsth, lasth);
            return response.ToString();
        }
    }
}