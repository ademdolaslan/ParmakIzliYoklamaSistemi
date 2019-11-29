using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Yoklama_Desktop
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        public static PersonHolder person = new PersonHolder();
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString("http://localhost:55394/Login/Default/Login/" + tb_username.Text.ToString() + "," + tb_password.Text.ToString() + "");
                if (data == "")
                {
                    MessageBox.Show("Kullanıcı Adınız veya Şifreniz Hatalı! Lütfen Kontrol Edip Tekrar Deneyiniz.");
                }
                else
                {
                    person.TeacherID = data;
                    Form_Main main = new Form_Main();
                    main.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }            
        }
    }
}
