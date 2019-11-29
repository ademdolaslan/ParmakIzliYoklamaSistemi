using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bitirme_Web.Models;

namespace Bitirme_Web
{
    public partial class MainPage : System.Web.UI.Page
    {

        SqlConnection connection = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["fingerprintconnection"].ConnectionString);
        SqlCommand cmd = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["TeacherID"] != null)
                {
                    lbl_Usertitle.Text = Session["TeacherTitle"].ToString() + " " + Session["TeacherName"].ToString() + " " + Session["TeacherSurname"].ToString();
                    lbl_Userdept.Text = Session["TeacherDepartment"].ToString();
                    lbl_Usermail.Text = Session["TeacherMail"].ToString();
                    lbl_Userphone.Text = Session["TeacherPhone"].ToString();

                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "Select * from Lessonsbyteachers Where TeacherID=" + long.Parse(Session["TeacherID"].ToString()) + "";
                SqlDataReader dr = cmd.ExecuteReader();
                dtlLessons.DataSource = dr;
                dtlLessons.DataBind();
                connection.Close();


            }

            
            
        }

        protected void dtlLessons_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName=="göster")
            {
                insp.lesson_id = e.CommandArgument.ToString();
                Response.Redirect("ViewInspaction.aspx");
            }
        }

        protected void ddlweek_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = sender as DropDownList;
            DataListItem item = ddl.NamingContainer as DataListItem;
            insp.week_id = int.Parse(ddl.SelectedValue);
            
        }

        protected void ddlday_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = sender as DropDownList;
            DataListItem item = ddl.NamingContainer as DataListItem;
            insp.day_id = int.Parse(ddl.SelectedValue);
            
        }
    }
}