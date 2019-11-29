using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yoklama_Desktop
{
    public partial class Form_Yoklama : Form
    {
        public Form_Yoklama()
        {
            InitializeComponent();
        }
        string[] ports = SerialPort.GetPortNames();
        int baudrate = 9600;
        string value;        
        int firsthalf = 0;
        int lasthalf = 0;
        DateTime[] dates = new DateTime[28];
        int daynumber;
        int weeknumber;
        string basket;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                #region "Tarih Bilgileri"

                dates[0]= Convert.ToDateTime("2018-09-17");
                dates[1] = Convert.ToDateTime("2018-09-21");
                dates[2] = Convert.ToDateTime("2018-09-24");
                dates[3] = Convert.ToDateTime("2018-09-28");
                dates[4] = Convert.ToDateTime("2018-10-01");
                dates[5] = Convert.ToDateTime("2018-10-05");
                dates[6] = Convert.ToDateTime("2018-10-08");
                dates[7] = Convert.ToDateTime("2018-10-12");
                dates[8] = Convert.ToDateTime("2018-10-15");
                dates[9] = Convert.ToDateTime("2018-10-19");
                dates[10] = Convert.ToDateTime("2018-10-22");
                dates[11] = Convert.ToDateTime("2018-10-26");
                dates[12] = Convert.ToDateTime("2018-10-29");
                dates[13] = Convert.ToDateTime("2018-11-02");
                dates[14] = Convert.ToDateTime("2018-11-05");
                dates[15] = Convert.ToDateTime("2018-11-09");
                dates[16] = Convert.ToDateTime("2018-11-12");
                dates[17] = Convert.ToDateTime("2018-11-16");
                dates[18] = Convert.ToDateTime("2018-11-19");
                dates[19] = Convert.ToDateTime("2018-11-23");
                dates[20] = Convert.ToDateTime("2018-11-26");
                dates[21] = Convert.ToDateTime("2018-11-30");
                dates[22] = Convert.ToDateTime("2018-12-03");
                dates[23] = Convert.ToDateTime("2018-12-07");
                dates[24] = Convert.ToDateTime("2018-12-10");
                dates[25] = Convert.ToDateTime("2018-12-14");
                dates[26] = Convert.ToDateTime("2018-12-17");
                dates[27] = Convert.ToDateTime("2018-12-21");

                #endregion
                var day = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)DateTime.Now.DayOfWeek];
                var dateofday = DateTime.Now.Date;
                #region "Gün Bilgileri Atama"
                if (day=="Pazartesi")
                {
                    daynumber = 1;
                }
                else if (day == "Salı")
                {
                    daynumber = 2;
                }
                else if (day == "Çarşamba")
                {
                    daynumber = 3;
                }
                else if (day == "Perşembe")
                {
                    daynumber = 4;
                }
                else if (day == "Cuma")
                {
                    daynumber = 5;
                }
                else if (day == "Cumartesi")
                {
                    daynumber = 6;
                }
                else if (day == "Pazar")
                {
                    daynumber = 7;
                }
                else
                {

                }
                #endregion
                #region "Hafta Bilgileri Atama"
                if (dateofday>=dates[0] && dateofday<=dates[1])
                {
                    weeknumber = 1;
                }
                else if (dateofday >= dates[2] && dateofday <= dates[3])
                {
                    weeknumber = 2;
                }
                else if (dateofday >= dates[4] && dateofday <= dates[5])
                {
                    weeknumber = 3;
                }
                else if (dateofday >= dates[6] && dateofday <= dates[7])
                {
                    weeknumber = 4;
                }
                else if (dateofday >= dates[8] && dateofday <= dates[9])
                {
                    weeknumber = 5;
                }
                else if (dateofday >= dates[10] && dateofday <= dates[11])
                {
                    weeknumber = 6;
                }
                else if (dateofday >= dates[12] && dateofday <= dates[13])
                {
                    weeknumber = 7;
                }
                else if (dateofday >= dates[14] && dateofday <= dates[15])
                {
                    weeknumber = 8;
                }
                else if (dateofday >= dates[16] && dateofday <= dates[17])
                {
                    weeknumber = 9;
                }
                else if (dateofday >= dates[18] && dateofday <= dates[19])
                {
                    weeknumber = 10;
                }
                else if (dateofday >= dates[20] && dateofday <= dates[21])
                {
                    weeknumber = 11;
                }
                else if (dateofday >= dates[22] && dateofday <= dates[23])
                {
                    weeknumber = 12;
                }
                else if (dateofday >= dates[24] && dateofday <= dates[25])
                {
                    weeknumber = 13;
                }
                else if (dateofday >= dates[26] && dateofday <= dates[27])
                {
                    weeknumber = 14;
                }
                else
                {

                }
                #endregion                              



                comboPorts.Items.Add("Cihaz Bağlantı Noktası");
                foreach (string port in ports)
                {
                    comboPorts.Items.Add(port);
                    comboPorts.SelectedIndex = 0;
                }
                lblConnectionState.Text = "Bağlantı Kapalı";
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.DiscardInBuffer();
                    serialPort1.Close();
                }
                label1.Text = Form_Main.lessonid.ToString() + " " + Form_Main.lessonname.ToString() + " Dersi için " + dateofday.ToShortDateString() + " " + day.ToString() + " tarihli yoklama alınıyor.";
                basket = label1.Text;
                btnOpen.Enabled = false;
                btnClose.Enabled = false;
                combodays.SelectedIndex = 0;
                comboweeks.SelectedIndex = 0;
                lblinfo.Text = Form_Main.info;
                lbldept.Text = Form_Main.dept;
                lblmail.Text = Form_Main.mail;
                lblphone.Text = Form_Main.tel;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }           

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {            
            timer1.Start();
            if (serialPort1.IsOpen==false)
            {
                if (comboPorts.Text=="")
                {
                    return;
                }                
                serialPort1.PortName = comboPorts.Text;
                serialPort1.BaudRate = baudrate;
                try
                {
                    serialPort1.Open();
                    lblConnectionState.Text = "Bağlantı Açık";

                }
                catch ( Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    
                }
            }
            else
            {
                lblConnectionState.Text = "Bağlantı Kuruldu";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
            if (serialPort1.IsOpen==true)
            {
                serialPort1.DiscardInBuffer();
                serialPort1.Close();
                lblConnectionState.Text = "Bağlantı Kapalı";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                value = serialPort1.ReadLine();
                value = value.First().ToString();
                lblConnectionValue.Text = value + "";
                serialPort1.DiscardInBuffer();

                if (value=="a")
                {
                    lbl_sunucu_cevap.Text = "Parmak Bekleniyor..";
                    pictureBox1.Image = Properties.Resources.wait;
                }
                else if (value=="b")
                {
                    lbl_sunucu_cevap.Text = "Parmak İzi Okunamada Hata.";
                    pictureBox1.Image = Properties.Resources.cross;
                }
                else if (value=="c")
                {
                    lbl_sunucu_cevap.Text = "Parmak İzi Sistemde Bulunmuyor.";
                    pictureBox1.Image = Properties.Resources.cross;
                }
                else
                {//burası id verisinin gönderildiği kısım olacak 


                    var response = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString("http://localhost:55394/inspection/Default/inspection/" + Form_Main.lessonid.ToString() + "_" + value.ToString() + "_" + daynumber.ToString() + "_" + weeknumber.ToString() + "_" + firsthalf.ToString() + "_" + lasthalf.ToString());
                    if (response=="success")
                    {
                        lbl_sunucu_cevap.Text = "Yoklama Bilgisi Alındı.";
                        pictureBox1.Image = Properties.Resources.tick;
                    }
                    if (response=="error")
                    {
                        lbl_sunucu_cevap.Text = "Yoklama Bilgisi Alınamadı.";
                        pictureBox1.Image = Properties.Resources.cross;
                    }
                    
                }



            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                //timer1.Stop();
                
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.Close();
                }
                Form_Main m = new Form_Main();
                m.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void comboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboPorts.Text != "")
                {
                    btnOpen.Enabled = true;
                    btnClose.Enabled = true;

                }
                else
                {
                    btnOpen.Enabled = false;
                    btnClose.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());                
            }
            
        }

        private void comboweeks_SelectedIndexChanged(object sender, EventArgs e)
        {
            weeknumber = comboweeks.SelectedIndex;          
        }

        private void combodays_SelectedIndexChanged(object sender, EventArgs e)
        {
            daynumber = combodays.SelectedIndex;   
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                firsthalf = 1;
            }
            else
            {
                firsthalf = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked==true)
            {
                lasthalf = 1;
            }
            else
            {
                lasthalf = 0;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked==true)
            {
                combodays.Enabled = true;
                comboweeks.Enabled = true;
                label1.Text = Form_Main.lessonid.ToString() + " " + Form_Main.lessonname.ToString() + " Dersi için Telafi Yoklaması Alınıyor.";

            }
            else
            {
                combodays.Enabled = false;
                comboweeks.Enabled = false;
                label1.Text = basket;

            }
        }
    }
}
