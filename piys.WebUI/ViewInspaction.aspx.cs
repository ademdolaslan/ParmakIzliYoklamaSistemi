using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bitirme_Web.Models;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace Bitirme_Web
{
    public partial class ViewInspaction : System.Web.UI.Page
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
                    #region "Gün Belirleme"
                    switch (insp.day_id)
                    {
                        case 1:
                            {
                                insp.dayname = "Pazartesi";
                                break;
                            }
                        case 2:
                            {
                                insp.dayname = "Salı";
                                break;
                            }
                        case 3:
                            {
                                insp.dayname = "Çarşamba";
                                break;
                            }
                        case 4:
                            {
                                insp.dayname = "Perşembe";
                                break;
                            }
                        case 5:
                            {
                                insp.dayname = "Cuma";
                                break;
                            }
                        case 6:
                            {
                                insp.dayname = "Cumartesi";
                                break;
                            }
                        case 7:
                            {
                                insp.dayname = "Pazar";
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                    #endregion
                    labelresults.Text = insp.lesson_id + " Dersi İçin; " + insp.week_id + ". Hafta,  " + insp.dayname + " Günü Yoklama Listesi: ";                   
                    try
                    {
                        connection.Open();
                        cmd.Connection = connection;
                        cmd.CommandText = "Select StudentID, StudentName, StudentSurname, StudentPeriod, InspectionLessonFirstHalf, InspectionLessonLastHalf from yoklama_getir where InspectionWeekID = " + insp.week_id + " and InspectionDayID = " + insp.day_id + " and InspectionLessonID LIKE '" + insp.lesson_id + "'";
                        SqlDataReader dr = cmd.ExecuteReader();
                        DataList1.DataSource = dr;
                        DataList1.DataBind();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Sayfada " + ex.Message.ToString() + " Hatası Meydana geldi!');</script>");
                    }
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }                
            }          

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Clear();
            Response.ClearHeaders();
            Response.ClearContent();
            Response.Charset = "windows-1254";
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("windows-1254");
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=" + insp.lesson_id + "_hafta_" + insp.week_id + "_" + insp.dayname + "_yoklaması.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Buffer = true;
            this.EnableViewState = false;
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            Panel1.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 100f, 10f);
            HTMLWorker htmlparser = new HTMLWorker(pdfdoc);
            PdfWriter.GetInstance(pdfdoc, Response.OutputStream);
            pdfdoc.Open();
            htmlparser.Parse(sr);
            pdfdoc.Close();
            Response.Write(pdfdoc);
            Response.End();


            
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            return;
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Clear();
            Response.ClearHeaders();
            Response.ClearContent();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("windows-1254");
            Response.AddHeader("content-disposition", "attachment;filename=" + insp.lesson_id + "_hafta_" + insp.week_id + "_" + insp.dayname + "_yoklaması.xls");  
            Response.Charset = "windows-1254";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Buffer = true;
            this.EnableViewState = false;
            Response.ContentType = "application/vnd.xls";
            System.IO.StringWriter stringWrite = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            DataList1.RenderControl(htmlWrite);
            string header = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\n<head>\n<title></title>\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=windows-1254\" />\n<style>\n</style>\n</head>\n<body>\n";
            Response.Write(header + stringWrite.ToString());
            Response.End();      

        }
    }
}