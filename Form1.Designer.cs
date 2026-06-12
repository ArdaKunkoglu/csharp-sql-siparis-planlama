namespace BotUretmeDeneme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSiparis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDakika = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeriM2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalisan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSonucTaban = new System.Windows.Forms.Label();
            this.lblSonucEtiket = new System.Windows.Forms.Label();
            this.lblSonucIplik = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSonucDeri = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSonucBitis = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pcbBotResim = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotResim)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(129, 22);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(217, 24);
            this.cmbModel.TabIndex = 0;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSiparis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbModel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(19, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model Bilgileri";
            // 
            // txtSiparis
            // 
            this.txtSiparis.Location = new System.Drawing.Point(129, 54);
            this.txtSiparis.Name = "txtSiparis";
            this.txtSiparis.Size = new System.Drawing.Size(217, 22);
            this.txtSiparis.TabIndex = 3;
            this.txtSiparis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sipariş Adedi: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDakika);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDeriM2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCalisan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(15, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 108);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Model Detayları: ";
            // 
            // txtDakika
            // 
            this.txtDakika.Location = new System.Drawing.Point(138, 82);
            this.txtDakika.Name = "txtDakika";
            this.txtDakika.Size = new System.Drawing.Size(212, 22);
            this.txtDakika.TabIndex = 5;
            this.txtDakika.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bot Başı Dakika :";
            // 
            // txtDeriM2
            // 
            this.txtDeriM2.Location = new System.Drawing.Point(138, 54);
            this.txtDeriM2.Name = "txtDeriM2";
            this.txtDeriM2.ReadOnly = true;
            this.txtDeriM2.Size = new System.Drawing.Size(212, 22);
            this.txtDeriM2.TabIndex = 3;
            this.txtDeriM2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Birim Deri (m²):";
            // 
            // txtCalisan
            // 
            this.txtCalisan.Location = new System.Drawing.Point(138, 21);
            this.txtCalisan.Name = "txtCalisan";
            this.txtCalisan.ReadOnly = true;
            this.txtCalisan.Size = new System.Drawing.Size(212, 22);
            this.txtCalisan.TabIndex = 1;
            this.txtCalisan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Çalışan Sayısı:";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(168, 27);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(212, 22);
            this.dtpBaslangic.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Teslim Tarihi  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Deri (m²) :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSonucTaban);
            this.groupBox3.Controls.Add(this.lblSonucEtiket);
            this.groupBox3.Controls.Add(this.lblSonucIplik);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblSonucDeri);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(15, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 120);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gereken Malzemeler :";
            // 
            // lblSonucTaban
            // 
            this.lblSonucTaban.AutoSize = true;
            this.lblSonucTaban.Location = new System.Drawing.Point(143, 95);
            this.lblSonucTaban.Name = "lblSonucTaban";
            this.lblSonucTaban.Size = new System.Drawing.Size(12, 16);
            this.lblSonucTaban.TabIndex = 10;
            this.lblSonucTaban.Text = "-";
            // 
            // lblSonucEtiket
            // 
            this.lblSonucEtiket.AutoSize = true;
            this.lblSonucEtiket.Location = new System.Drawing.Point(143, 72);
            this.lblSonucEtiket.Name = "lblSonucEtiket";
            this.lblSonucEtiket.Size = new System.Drawing.Size(12, 16);
            this.lblSonucEtiket.TabIndex = 9;
            this.lblSonucEtiket.Text = "-";
            // 
            // lblSonucIplik
            // 
            this.lblSonucIplik.AutoSize = true;
            this.lblSonucIplik.Location = new System.Drawing.Point(143, 45);
            this.lblSonucIplik.Name = "lblSonucIplik";
            this.lblSonucIplik.Size = new System.Drawing.Size(12, 16);
            this.lblSonucIplik.TabIndex = 8;
            this.lblSonucIplik.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Toplam Taban:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Toplam Etiket:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Toplam İplik:";
            // 
            // lblSonucDeri
            // 
            this.lblSonucDeri.AutoSize = true;
            this.lblSonucDeri.Location = new System.Drawing.Point(143, 18);
            this.lblSonucDeri.Name = "lblSonucDeri";
            this.lblSonucDeri.Size = new System.Drawing.Size(12, 16);
            this.lblSonucDeri.TabIndex = 4;
            this.lblSonucDeri.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpBaslangic);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lblSonucBitis);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(396, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 111);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Teslimat Planlaması :";
            // 
            // lblSonucBitis
            // 
            this.lblSonucBitis.AutoSize = true;
            this.lblSonucBitis.Location = new System.Drawing.Point(175, 74);
            this.lblSonucBitis.Name = "lblSonucBitis";
            this.lblSonucBitis.Size = new System.Drawing.Size(55, 16);
            this.lblSonucBitis.TabIndex = 2;
            this.lblSonucBitis.Text = "--.--.----";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Üretim Bitiş Tarihi:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.Green;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(442, 394);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(244, 51);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "\"HESAPLA VE PLANLAMAYA BAŞLA\"";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(19, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 56);
            this.panel1.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(16, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(318, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sipariş Planlama Uygulaması";
            // 
            // pcbBotResim
            // 
            this.pcbBotResim.BackColor = System.Drawing.Color.Transparent;
            this.pcbBotResim.Location = new System.Drawing.Point(6, 11);
            this.pcbBotResim.Name = "pcbBotResim";
            this.pcbBotResim.Size = new System.Drawing.Size(380, 253);
            this.pcbBotResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBotResim.TabIndex = 9;
            this.pcbBotResim.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pcbBotResim);
            this.groupBox5.Location = new System.Drawing.Point(396, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(392, 270);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtMusteri);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(19, 63);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(357, 50);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Müşteri Bilgisi :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Müşteri / Firma Adı :";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(147, 15);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(204, 22);
            this.txtMusteri.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Sipariş Planlama Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotResim)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSiparis;
        private System.Windows.Forms.TextBox txtCalisan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeriM2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDakika;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSonucDeri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSonucTaban;
        private System.Windows.Forms.Label lblSonucEtiket;
        private System.Windows.Forms.Label lblSonucIplik;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSonucBitis;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.PictureBox pcbBotResim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMusteri;
    }
}

