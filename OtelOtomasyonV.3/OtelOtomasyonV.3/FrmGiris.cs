using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtelOtomasyonV._3
{
    public partial class FrmGiris : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=C:\\Users\\batuh\\source\\repos\\OtelOtomasyonV.3\\Database.mdb");


        public FrmGiris()
        {
            InitializeComponent();
        }

        private void BtnPersonelGiris_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from personel where TcKimlik='" + TxtPersonelKullaniciAdi.Text + "' and Sifre ='" + TxtPersonelSifre.Text + "'", baglanti);
            
            baglanti.Open();

            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {

                MessageBox.Show("Giriş Başarılı !");
                baglanti.Close();
                FrmPersonel fr = new FrmPersonel();
                fr.Show();
                this.Hide();
            }
            else
            {
                baglanti.Close();
                MessageBox.Show("Kullanıcı Adınız Yada Şifreniz Yanlış Yazılmıştır");
                TxtPersonelKullaniciAdi.Text = "";
                TxtPersonelSifre.Text = "";
                //verileri temizler
            }
            
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {

            OleDbCommand komut = new OleDbCommand("select * from admin where K_adi='" + TxtAdminKullaniciAdi.Text + "' and Sifre ='" + TxtAdminSifre.Text + "'", baglanti);
            
            baglanti.Open();

            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {

                MessageBox.Show("Giriş Başarılı !");
                baglanti.Close();
                FrmAdmin menu = new FrmAdmin();
                menu.Show();
                this.Hide();

            }
            else
            {
                baglanti.Close();
                MessageBox.Show("Kullanıcı Adınız Veya Şifreniz Yanlış Yazılmıştır");
                TxtAdminKullaniciAdi.Text = "";
                TxtAdminSifre.Text = "";
                //verileri temizler
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifreDegis SifreDegis = new FrmSifreDegis();
            SifreDegis.Show();
            this.Hide();////mevcut sayfayı gizler
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
