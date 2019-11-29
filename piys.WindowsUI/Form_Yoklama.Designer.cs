namespace Yoklama_Desktop
{
    partial class Form_Yoklama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboPorts = new System.Windows.Forms.ComboBox();
            this.lblConnectionValue = new System.Windows.Forms.Label();
            this.lblConnectionState = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboweeks = new System.Windows.Forms.ComboBox();
            this.combodays = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.lbldept = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_sunucu_cevap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpen.Location = new System.Drawing.Point(849, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(187, 68);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Yoklamayı Başlat";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(849, 86);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(187, 68);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Yoklamayı Durdur";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboPorts
            // 
            this.comboPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboPorts.FormattingEnabled = true;
            this.comboPorts.Location = new System.Drawing.Point(9, 46);
            this.comboPorts.Name = "comboPorts";
            this.comboPorts.Size = new System.Drawing.Size(427, 32);
            this.comboPorts.TabIndex = 2;
            this.comboPorts.SelectedIndexChanged += new System.EventHandler(this.comboPorts_SelectedIndexChanged);
            // 
            // lblConnectionValue
            // 
            this.lblConnectionValue.AutoSize = true;
            this.lblConnectionValue.Location = new System.Drawing.Point(1001, 682);
            this.lblConnectionValue.Name = "lblConnectionValue";
            this.lblConnectionValue.Size = new System.Drawing.Size(35, 13);
            this.lblConnectionValue.TabIndex = 4;
            this.lblConnectionValue.Text = "label1";
            this.lblConnectionValue.Visible = false;
            // 
            // lblConnectionState
            // 
            this.lblConnectionState.AutoSize = true;
            this.lblConnectionState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConnectionState.Location = new System.Drawing.Point(90, 140);
            this.lblConnectionState.Name = "lblConnectionState";
            this.lblConnectionState.Size = new System.Drawing.Size(24, 25);
            this.lblConnectionState.TabIndex = 5;
            this.lblConnectionState.Text = "y";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblConnectionState);
            this.panel1.Location = new System.Drawing.Point(12, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 190);
            this.panel1.TabIndex = 6;
            this.panel1.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cihaz Ayarları";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.Location = new System.Drawing.Point(253, 138);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(200, 28);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Dersin İkinci Yarısı";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(59, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(172, 28);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Dersin İlk Yarısı";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // comboweeks
            // 
            this.comboweeks.Enabled = false;
            this.comboweeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboweeks.FormattingEnabled = true;
            this.comboweeks.Items.AddRange(new object[] {
            "Lütfen Yoklamanın Alınacağı Haftayı Seçiniz",
            "1. Hafta - 17 Eylül 2018 / 21 Eylül 2018",
            "2. Hafta - 24 Eylül 2018 / 28 Eylül 2018",
            "3. Hafta - 1 Ekim 2018 / 5 Ekim 2018",
            "4. Hafta - 8 Ekim 2018 / 12 Ekim 2018",
            "5. Hafta - 15 Ekim 2018 / 19 Ekim 2018",
            "6. Hafta - 22 Ekim 2018 / 26 Ekim 2018",
            "7. Hafta - 29 Ekim 2018 / 2 Kasım 2018",
            "8. Hafta - 5 Kasım 2018 / 9 Kasım 2018",
            "9. Hafta - 12 Kasım 2018 / 16 Kasım 2018",
            "10. Hafta - 19 Kasım 2018 / 23 Kasım 2018",
            "11. Hafta - 26 Kasım 2018 / 30 Kasım 2018",
            "12. Hafta - 3 Aralık 2018 / 7 Aralık 2018",
            "13. Hafta - 10 Aralık 2018 / 14 Aralık 2018",
            "14. Hafta - 17 Aralık 2018 / 21 Aralık 2018"});
            this.comboweeks.Location = new System.Drawing.Point(36, 65);
            this.comboweeks.Name = "comboweeks";
            this.comboweeks.Size = new System.Drawing.Size(451, 28);
            this.comboweeks.TabIndex = 9;
            this.comboweeks.SelectedIndexChanged += new System.EventHandler(this.comboweeks_SelectedIndexChanged);
            // 
            // combodays
            // 
            this.combodays.Enabled = false;
            this.combodays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combodays.FormattingEnabled = true;
            this.combodays.Items.AddRange(new object[] {
            "Lütfen yoklamanın alınacağı günü belirleyiniz.",
            "1 - Pazartesi",
            "2 - Salı",
            "3 - Çarşamba",
            "4 - Perşembe",
            "5 -Cuma",
            "6 - Cumartesi",
            "7 - Pazar"});
            this.combodays.Location = new System.Drawing.Point(36, 99);
            this.combodays.Name = "combodays";
            this.combodays.Size = new System.Drawing.Size(451, 28);
            this.combodays.TabIndex = 8;
            this.combodays.SelectedIndexChanged += new System.EventHandler(this.combodays_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboPorts);
            this.panel2.Location = new System.Drawing.Point(26, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 91);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cihazın bağlandığı bağlantı noktasını belirtiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yoklama_Desktop.Properties.Resources.wait1;
            this.pictureBox1.Location = new System.Drawing.Point(667, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(593, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 107);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblphone.Location = new System.Drawing.Point(258, 142);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(66, 24);
            this.lblphone.TabIndex = 9;
            this.lblphone.Text = "label1";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmail.Location = new System.Drawing.Point(258, 102);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(66, 24);
            this.lblmail.TabIndex = 10;
            this.lblmail.Text = "label1";
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldept.Location = new System.Drawing.Point(257, 63);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(85, 29);
            this.lbldept.TabIndex = 11;
            this.lbldept.Text = "label1";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblinfo.Location = new System.Drawing.Point(255, 12);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(115, 39);
            this.lblinfo.TabIndex = 12;
            this.lblinfo.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Yoklama_Desktop.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_sunucu_cevap
            // 
            this.lbl_sunucu_cevap.AutoSize = true;
            this.lbl_sunucu_cevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sunucu_cevap.Location = new System.Drawing.Point(663, 639);
            this.lbl_sunucu_cevap.Name = "lbl_sunucu_cevap";
            this.lbl_sunucu_cevap.Size = new System.Drawing.Size(292, 24);
            this.lbl_sunucu_cevap.TabIndex = 13;
            this.lbl_sunucu_cevap.Text = "Sistemin Başlaması Bekleniyor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1001, 659);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.comboweeks);
            this.panel3.Controls.Add(this.combodays);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Location = new System.Drawing.Point(12, 507);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 185);
            this.panel3.TabIndex = 15;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox3.Location = new System.Drawing.Point(13, 21);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(369, 28);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Telafi Dersi İçin Yoklama Almak İstiyorum";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form_Yoklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1048, 704);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_sunucu_cevap);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldept);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblConnectionValue);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form_Yoklama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yoklama Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboPorts;
        private System.Windows.Forms.Label lblConnectionValue;
        private System.Windows.Forms.Label lblConnectionState;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combodays;
        private System.Windows.Forms.ComboBox comboweeks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sunucu_cevap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

