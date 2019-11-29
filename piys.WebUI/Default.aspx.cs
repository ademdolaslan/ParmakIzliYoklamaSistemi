using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bitirme_Web.Models;

namespace Bitirme_Web
{
    public partial class _Default : Page
    {

        SqlConnection connection = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["fingerprintconnection"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd_getuser = new SqlCommand();
        public DataTable dt = new DataTable();
        public userinfo user = new userinfo();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM Teachers WHERE TeacherUserID LIKE '" + tbUserName.Text.ToString() + "'AND TeacherPassword LIKE '" + tbUserPassword.Text.ToString() + "'";
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    connection.Close();
                    connection.Open();
                    cmd_getuser.Connection = connection;
                    cmd_getuser.CommandText = "SELECT * FROM Teachers WHERE TeacherUserID LIKE '" + tbUserName.Text.ToString() + "'AND TeacherPassword LIKE '" + tbUserPassword.Text.ToString() + "'";
                    SqlDataAdapter da = new SqlDataAdapter(cmd_getuser);
                    da.Fill(dt);
                    user.TeacherID = dt.Rows[0]["TeacherID"].ToString();
                    user.TeacherName = dt.Rows[0]["TeacherName"].ToString();
                    user.TeacherSurname = dt.Rows[0]["TeacherSurname"].ToString();
                    user.TeacherDepartment = dt.Rows[0]["TeacherDepartment"].ToString();
                    user.TeacherTitle = dt.Rows[0]["TeacherTitle"].ToString();
                    user.TeacherMail = dt.Rows[0]["TeacherMail"].ToString();
                    user.TeacherPhone = dt.Rows[0]["TeacherPhone"].ToString();
                    connection.Close();
                    Session["TeacherID"] = user.TeacherID.ToString();
                    Session["TeacherName"] = user.TeacherName.ToString();
                    Session["TeacherSurname"] = user.TeacherSurname.ToString();
                    Session["TeacherTitle"] = user.TeacherTitle.ToString();
                    Session["TeacherMail"] = user.TeacherMail.ToString();
                    Session["TeacherPhone"] = user.TeacherPhone.ToString();
                    Session["TeacherDepartment"] = user.TeacherDepartment.ToString();
                    Response.Redirect("MainPage.aspx");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Kullanıcı Adı veya Şifre Hatalı');</script>");
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Sayfada " + ex.Message.ToString() + " Hatası Meydana geldi!');</script>");
            }

        }
    }
}
