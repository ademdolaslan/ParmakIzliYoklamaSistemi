using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Yoklama_Desktop
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        TeacherHolder holder = new TeacherHolder();
        DataTable dt = new DataTable();
        public static string info = "";
        public static string dept = "";
        public static string mail = "";
        public static string tel = "";   
        public static string lessonid = "";
        public static string lessonname = "";
        private void Form_Main_Load(object sender, EventArgs e)
        {
            try
            {
                var json = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString("http://localhost:55394/Default/Default/Lessons/" + Form_Login.person.TeacherID + "");
                var datatable = JsonConvert.DeserializeObject<DataTable>(json);
                dataGridView1.DataSource = datatable;
                var ınfo = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString("http://localhost:55394/Teacher/Default/Teacher/" + Form_Login.person.TeacherID + "");
                var teachertable = JsonConvert.DeserializeObject<DataTable>(ınfo);
                dt = datatable;
                holder.TeacherID = teachertable.Rows[0][0].ToString();
                holder.TeacherName = teachertable.Rows[0][1].ToString();
                holder.TeacherSurname = teachertable.Rows[0][2].ToString();
                holder.TeacherTitle = teachertable.Rows[0][3].ToString();
                holder.TeacherDepartment = teachertable.Rows[0][4].ToString();
                holder.TeacherMail = teachertable.Rows[0][5].ToString();
                holder.TeacherPhone = teachertable.Rows[0][6].ToString();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                lblinfo.Text = holder.TeacherTitle.ToString() + " " + holder.TeacherName.ToString() + " " + holder.TeacherSurname.ToString();
                info = lblinfo.Text.ToString();
                lbldept.Text = holder.TeacherDepartment.ToString();
                dept = lbldept.Text.ToString();
                lblmail.Text = holder.TeacherMail.ToString();
                mail = lblmail.Text.ToString();
                lblphone.Text = holder.TeacherPhone.ToString();
                tel = lblphone.Text.ToString();
                //dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "LessonSemester", "1");
                dataGridView1.Columns[4].HeaderText = "Ders Kodu";
                dataGridView1.Columns[5].HeaderText = "Ders Adı";
                dataGridView1.Columns[6].HeaderText = "Ders Dönemi";
                dataGridView1.Columns[7].HeaderText = "Ders Saati";
                dataGridView1.Columns[8].HeaderText = "Ders AKTS";
            }
            catch (Exception ex)
            {

                throw;
            }           

        }
        

        //Dönemlik Listelemeler
        //program.cs içindeki click eventlarıda aktifleştirilecek
        //loaddaki filtre uygulanacak
        //butonlar geri düzenlenecek
        //private void btndonem1_Click(object sender, EventArgs e)
        //{
        //   dt.DefaultView.RowFilter= string.Format("[{0}] LIKE '%{1}%'", "LessonSemester", "1");
        //}

        //private void btndonem2_Click(object sender, EventArgs e)
        //{
        //    dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "LessonSemester", "2");
        //}

        //private void btndonem3_Click(object sender, EventArgs e)
        //{
        //    dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "LessonSemester", "3");
        //}

        //private void btndonem4_Click(object sender, EventArgs e)
        //{
        //    dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "LessonSemester", "4");
        //}

        //private void btndonem5_Click(object sender, EventArgs e)
        //{
        //    dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "LessonSemester", "5");
        //}

        //private void btndonem6_Click(object sender, EventArgs e)
        //{
        //    dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "LessonSemester", "6");
        //}

        //private void btndonem7_Click(object sender, EventArgs e)
        //{
        //    dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "LessonSemester", "7");
        //}

        //private void btndonem8_Click(object sender, EventArgs e)
        //{
        //    dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "LessonSemester", "8");
        //}       
        
        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                lessonid = dataGridView1.CurrentRow.Cells["LessonID"].Value.ToString();
                lessonname = dataGridView1.CurrentRow.Cells["LessonName"].Value.ToString();
                Form_Yoklama a = new Form_Yoklama();
                a.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Yoklamayı Başlatabilmek İçin Listeden Bir Ders Seçmeniz Gerekmektedir");
            }            
            
        }
    }
}
