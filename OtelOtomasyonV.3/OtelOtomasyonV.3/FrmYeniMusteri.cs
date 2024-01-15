using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OtelOtomasyonV._3
{                       
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
                                                           
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=C:\\Users\\batuh\\source\\repos\\OtelOtomasyonV.3\\Database.mdb");


        private void Temizle()
        {
            
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "Seçiniz";
            MskTxtTelefon.Clear();
            TxtMail.Clear();
            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Value = DateTime.Today;
            DtpCikisTarihi.Value = DateTime.Today;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
                                     
        public void odayaz()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from MusteriEkle", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                switch (oku[7].ToString())
                {
                    case "101":
                        {
                            BtnOda101.Text = oku[7].ToString();
                            BtnOda101.BackColor = System.Drawing.Color.Red;
                            BtnOda101.Enabled = false;
                            break;
                        }
                    case "102":
                        {
                            BtnOda102.Text = oku[7].ToString();
                            BtnOda102.BackColor = System.Drawing.Color.Red;
                            BtnOda102.Enabled = false;
                            break;
                        }
                    case "103":
                        {
                            BtnOda103.Text = oku[7].ToString();
                            BtnOda103.BackColor = System.Drawing.Color.Red;
                            BtnOda103.Enabled = false;
                            break;
                        }
                    case "104":
                        {
                            BtnOda104.Text = oku[7].ToString();
                            BtnOda104.BackColor = System.Drawing.Color.Red;
                            BtnOda104.Enabled = false;
                            break;
                        }
                    case "105":
                        {
                            BtnOda105.Text = oku[7].ToString();
                            BtnOda105.BackColor = System.Drawing.Color.Red;
                            BtnOda105.Enabled = false;
                            break;
                        }
                    case "201":
                        {
                            BtnOda201.Text = oku[7].ToString();
                            BtnOda201.BackColor = System.Drawing.Color.Red;
                            BtnOda201.Enabled = false;
                            break;
                        }
                    case "202":
                        {
                            BtnOda202.Text = oku[7].ToString();
                            BtnOda202.BackColor = System.Drawing.Color.Red;
                            BtnOda202.Enabled = false;
                            break;
                        }
                    case "203":
                        {
                            BtnOda203.Text = oku[7].ToString();
                            BtnOda203.BackColor = System.Drawing.Color.Red;
                            BtnOda203.Enabled = false;
                            break;
                        }
                    case "204":
                        {
                            BtnOda204.Text = oku[7].ToString();
                            BtnOda204.BackColor = System.Drawing.Color.Red;
                            BtnOda204.Enabled = false;
                            break;
                        }
                    case "205":
                        {
                            BtnOda205.Text = oku[7].ToString();
                            BtnOda205.BackColor = System.Drawing.Color.Red;
                            BtnOda205.Enabled = false;
                            break;
                        }
                    case "301":
                        {
                            BtnOda301.Text = oku[7].ToString();
                            BtnOda301.BackColor = System.Drawing.Color.Red;
                            BtnOda301.Enabled = false;
                            break;
                        }
                    case "302":
                        {
                            BtnOda302.Text = oku[7].ToString();
                            BtnOda302.BackColor = System.Drawing.Color.Red;
                            BtnOda302.Enabled = false;
                            break;
                        }
                    case "303":
                        {
                            BtnOda303.Text = oku[7].ToString();
                            BtnOda303.BackColor = System.Drawing.Color.Red;
                            BtnOda303.Enabled = false;
                            break;
                        }
                    case "304":
                        {
                            BtnOda304.Text = oku[7].ToString();
                            BtnOda304.BackColor = System.Drawing.Color.Red;
                            BtnOda304.Enabled = false;
                            break;
                        }
                    case "305":
                        {
                            BtnOda305.Text = oku[7].ToString();
                            BtnOda305.BackColor = System.Drawing.Color.Red;
                            BtnOda305.Enabled = false;
                            break;
                        }
                    case "401":
                        {
                            BtnOda401.Text = oku[7].ToString();
                            BtnOda401.BackColor = System.Drawing.Color.Red;
                            BtnOda401.Enabled = false;
                            break;
                        }
                    case "402":
                        {
                            BtnOda402.Text = oku[7].ToString();
                            BtnOda402.BackColor = System.Drawing.Color.Red;
                            BtnOda402.Enabled = false;
                            break;
                        }
                    case "403":
                        {
                            BtnOda403.Text = oku[7].ToString();
                            BtnOda403.BackColor = System.Drawing.Color.Red;
                            BtnOda403.Enabled = false;
                            break;
                        }
                    case "404":
                        {
                            BtnOda404.Text = oku[7].ToString();
                            BtnOda404.BackColor = System.Drawing.Color.Red;
                            BtnOda404.Enabled = false;
                            break;
                        }
                    case "405":
                        {
                            BtnOda405.Text = oku[7].ToString();
                            BtnOda405.BackColor = System.Drawing.Color.Red;
                            BtnOda405.Enabled = false;
                            break;
                        }
                }

            }

            baglanti.Close();
            oku.Dispose();
        }

        
        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
        }

        private void BtnOda201_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "201";
        }

        private void BtnOda202_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "202";
        }

        private void BtnOda203_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "203";
        }

        private void BtnOda204_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "204";
        }

        private void BtnOda205_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "205";
        }

        private void BtnOda301_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "301";
        }

        private void BtnOda302_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "302";
        }

        private void BtnOda303_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "303";
        }

        private void BtnOda304_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "304";
        }

        private void BtnOda305_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "305";
        }

        private void BtnOda401_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "401";
        }

        private void BtnOda402_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "402";
        }

        private void BtnOda403_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "403";
        }

        private void BtnOda404_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "404";
        }

        private void BtnOda405_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "405";
        }

                                                               

                                                                
        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime GirisTarihi = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime CikisTarihi = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan Sonuc = CikisTarihi - GirisTarihi;

            LblHesap.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(LblHesap.Text) * 350;
            TxtUcret.Text = Ucret.ToString();
        }

                                                        
                                             
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
                baglanti.Open();             
                OleDbCommand komutx = new OleDbCommand("insert into MusteriBilgi (TcKimlik,Ad,Soyad,Cinsiyet,Telefon,Mail,OdaNo,Ucret,GirisTarihi,CikisTarihi) values ('" + TxtKimlikNo.Text + "' , '" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + comboBox1.Text + "' , '" + MskTxtTelefon.Text + "' , '" + TxtMail.Text + "' , '" + TxtOdaNo.Text + "' , '" + TxtUcret.Text + "' , '" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "' , '" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
                OleDbCommand komut = new OleDbCommand("insert into MusteriEkle (TcKimlik,Ad,Soyad,Cinsiyet,Telefon,Mail,OdaNo,Ucret,GirisTarihi,CikisTarihi) values ('" + TxtKimlikNo.Text + "' , '" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + comboBox1.Text + "' , '"+ MskTxtTelefon.Text +"' , '"+ TxtMail.Text + "' , '"+ TxtOdaNo.Text +"' , '" + TxtUcret.Text + "' , '" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") +"' , '" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
                komutx.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt İşlemi Başarıyla Kaydedildi.");
                Temizle();
                
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            FrmPersonel AnaSayfa = new FrmPersonel();
            AnaSayfa.Show();
            this.Hide();
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            odayaz();
        }
    }
}
