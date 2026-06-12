using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BotUretmeDeneme
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Server=DESKTOP-5BMALJL\SQLEXPRESS;Database=AyakkabiDB;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ModelGetir();
            Temizle();
        }

        //sql den model çekmek
        private void ModelGetir()
        {
            try
            {
                cmbModel.Items.Clear();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM AyakkabiModelleri", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        cmbModel.Items.Add(new AyakkabiModeli
                        {
                            ModelAdi = dr["ModelAdi"].ToString(),
                            DeriM2 = Convert.ToDouble(dr["DeriM2"]),
                            YapimDakika = Convert.ToInt32(dr["YapimDakika"])
                        });
                    }
                }
                cmbModel.DisplayMember = "ModelAdi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası! Lütfen SQL Server'ın çalıştığından emin olun.\n\nDetay: " + ex.Message);
            }
        }
        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModel.SelectedItem is AyakkabiModeli secilen)
            {
                txtDeriM2.Text = secilen.DeriM2.ToString();
                txtDakika.Text = secilen.YapimDakika.ToString();

                // resim kısmı
                try
                {
                    if (secilen.ModelAdi == "Model_01")
                    {
                        pcbBotResim.Image = Properties.Resources.Model_01;
                    }
                    else if (secilen.ModelAdi == "Model_02")
                    {
                        pcbBotResim.Image = Properties.Resources.Model_02;
                    }
                    else
                    {
                        pcbBotResim.Image = null;
                    }
                }
                catch (Exception)
                {

                    pcbBotResim.Image = null;
                }
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSiparis.Text) || cmbModel.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir model seçin ve sipariş adedi girin!");
                    return;
                }

                int siparis = int.Parse(txtSiparis.Text);
                int dakika = int.Parse(txtDakika.Text);
                double deri = double.Parse(txtDeriM2.Text);

                DateTime teslim = dtpBaslangic.Value;
                DateTime bitis = teslim.AddDays(-14); 

                
                int isGunu = 0;
                DateTime temp = DateTime.Now;

                while (temp < bitis)
                {
                    temp = temp.AddDays(1);
                    if (temp.DayOfWeek != DayOfWeek.Sunday)
                        isGunu++;
                }

                if (isGunu <= 14)
                {
                    MessageBox.Show("Teslimat tarihi üretim süresi (14 gün öncesi) için çok yakın!");
                    return;
                }

                
                double kisiBasinaGunlukUretim = 480.0 / dakika;
                double gunlukHedeflenenUretim = (double)siparis / isGunu;
                int gerekenIsci = (int)Math.Ceiling(gunlukHedeflenenUretim / kisiBasinaGunlukUretim);

                
                txtCalisan.Text = gerekenIsci.ToString();
                lblSonucDeri.Text = (siparis * deri) + " m²";
                lblSonucTaban.Text = (siparis * 2) + " Adet";
                lblSonucIplik.Text = (siparis * 10) + " Metre";
                lblSonucEtiket.Text = (siparis * 2) + " Adet";
                lblSonucBitis.Text = bitis.ToShortDateString();

               

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Siparisler 
                   (MusteriAdi, ModelAdi, SiparisAdedi, GerekliIsci, ToplamDeri, Tarih, TeslimTarihi) 
                   VALUES 
                   (@MusteriAdi, @ModelAdi, @SiparisAdedi, @GerekliIsci, @ToplamDeri, @Tarih, @TeslimTarihi)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@MusteriAdi", txtMusteri.Text);
                    cmd.Parameters.AddWithValue("@ModelAdi", cmbModel.Text);
                    cmd.Parameters.AddWithValue("@SiparisAdedi", siparis);
                    cmd.Parameters.AddWithValue("@GerekliIsci", gerekenIsci);
                    cmd.Parameters.AddWithValue("@ToplamDeri", siparis * deri);
                    cmd.Parameters.AddWithValue("@Tarih", DateTime.Now); 
                    cmd.Parameters.AddWithValue("@TeslimTarihi", dtpBaslangic.Value); 

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Planlama başarıyla yapıldı ve Siparisler tablosuna kaydedildi!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex.ToString());
            }
        }


        private void Temizle()
        {
            lblSonucDeri.Text = "-";
            lblSonucTaban.Text = "-";
            lblSonucIplik.Text = "-";
            lblSonucEtiket.Text = "-";
            lblSonucBitis.Text = "--.--.----";
            txtSiparis.Clear();
            txtCalisan.Clear();
        }


    }


    public class AyakkabiModeli
    {
        public string ModelAdi { get; set; }
        public double DeriM2 { get; set; }
        public int YapimDakika { get; set; }

        public override string ToString()
        {
            return ModelAdi;
        }
    }
}