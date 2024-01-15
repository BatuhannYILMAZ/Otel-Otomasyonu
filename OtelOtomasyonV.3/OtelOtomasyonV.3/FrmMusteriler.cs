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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtelOtomasyonV._3
{
    public partial class FrmMusteriler : Form
    {

                                                                                /*VERİTABANI BAĞLANTISI*/
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=C:\\Users\\batuh\\source\\repos\\OtelOtomasyonV.3\\Database.mdb");

        public FrmMusteriler()
        {
            InitializeComponent();
        }


        public void Listele()
        {
            dataGridView1.Rows.Clear(); //her çağrıldıgında datagrid i temizler

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from MusteriEkle", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                DataGridViewRow yaz = new DataGridViewRow();
                yaz.CreateCells(dataGridView1);

                yaz.Cells[0].Value = oku["id"].ToString();
                yaz.Cells[1].Value = oku["TcKimlik"].ToString();
                yaz.Cells[2].Value = oku["Ad"].ToString();
                yaz.Cells[3].Value = oku["Soyad"].ToString();
                yaz.Cells[4].Value = oku["Cinsiyet"].ToString();
                yaz.Cells[5].Value = oku["Telefon"].ToString();
                yaz.Cells[6].Value = oku["Mail"].ToString();
                yaz.Cells[7].Value = oku["OdaNo"].ToString();
                yaz.Cells[8].Value = oku["Ucret"].ToString();
                // tarih alaında saat dakika saniye de yazıyor du sorunu çözdüm
                yaz.Cells[9].Value = ((DateTime)oku["GirisTarihi"]).ToString("dd.MM.yyyy");
                yaz.Cells[10].Value = ((DateTime)oku["CikisTarihi"]).ToString("dd.MM.yyyy");

                dataGridView1.Rows.Add(yaz);
            }

            baglanti.Close();
            
        }

        private void Temizle()
        {
            TxtId.Clear();
            TxtKimlikNo.Clear();
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "Seçiniz";
            MskTxtTelefon.Clear();
            TxtMail.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Value = DateTime.Today;
            DtpCikisTarihi.Value = DateTime.Today;
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            Listele();
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {   //datagridview den satıra basınca bilgileri Textboxlara  taşır
            TxtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtKimlikNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtSoyadi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            MskTxtTelefon.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TxtMail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            TxtOdaNo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            TxtUcret.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            DtpGirisTarihi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            DtpCikisTarihi.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            FrmPersonel AnaSayfa = new FrmPersonel();
            AnaSayfa.Show();
            this.Hide();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand sil = new OleDbCommand("delete from MusteriEkle where id=" + TxtId.Text, baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Silme İşlemi Başarılı");

            Temizle();
            Listele();


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open(); 
            OleDbCommand guncelle = new OleDbCommand("update MusteriEkle set TcKimlik= '" + TxtKimlikNo.Text + "', Ad='" + TxtAdi.Text + "', Soyad='" + TxtSoyadi.Text + "', Cinsiyet='" + comboBox1.Text + "', Telefon='" + MskTxtTelefon.Text + "', Mail='" + TxtMail.Text + "', OdaNo='" + TxtOdaNo.Text + "', Ucret='" + TxtUcret.Text + "', GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "', CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "' where id=" + TxtId.Text, baglanti);
            guncelle.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Güncelleme İşlemi Başarılı");

            Temizle();
            Listele();
        }

        private void BtnTcAra_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); //her çağrıldıgında datagrid i temizler

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM MusteriEkle WHERE TcKimlik LIKE '" + TxtTcAra.Text + "%'", baglanti);


            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                DataGridViewRow yaz = new DataGridViewRow();
                yaz.CreateCells(dataGridView1);

                yaz.Cells[0].Value = oku["id"].ToString();
                yaz.Cells[1].Value = oku["TcKimlik"].ToString();
                yaz.Cells[2].Value = oku["Ad"].ToString();
                yaz.Cells[3].Value = oku["Soyad"].ToString();
                yaz.Cells[4].Value = oku["Cinsiyet"].ToString();
                yaz.Cells[5].Value = oku["Telefon"].ToString();
                yaz.Cells[6].Value = oku["Mail"].ToString();
                yaz.Cells[7].Value = oku["OdaNo"].ToString();
                yaz.Cells[8].Value = oku["Ucret"].ToString();
                // tarih alaında saat dakika saniye de yazıyor du sorunu çözdüm
                yaz.Cells[9].Value = ((DateTime)oku["GirisTarihi"]).ToString("dd.MM.yyyy");
                yaz.Cells[10].Value = ((DateTime)oku["CikisTarihi"]).ToString("dd.MM.yyyy");

                dataGridView1.Rows.Add(yaz);
            }

            baglanti.Close();
        }

        private void BtnAdSorgu_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); //her çağrıldıgında datagrid i temizler

            baglanti.Open(); 
            OleDbCommand komut = new OleDbCommand("SELECT * FROM MusteriEkle WHERE Ad LIKE '" + TxtAdAra.Text + "%'", baglanti);


            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                DataGridViewRow yaz = new DataGridViewRow();
                yaz.CreateCells(dataGridView1);

                yaz.Cells[0].Value = oku["id"].ToString();
                yaz.Cells[1].Value = oku["TcKimlik"].ToString();
                yaz.Cells[2].Value = oku["Ad"].ToString();
                yaz.Cells[3].Value = oku["Soyad"].ToString();
                yaz.Cells[4].Value = oku["Cinsiyet"].ToString();
                yaz.Cells[5].Value = oku["Telefon"].ToString();
                yaz.Cells[6].Value = oku["Mail"].ToString();
                yaz.Cells[7].Value = oku["OdaNo"].ToString();
                yaz.Cells[8].Value = oku["Ucret"].ToString();
                // tarih alaında saat dakika saniye de yazıyor du sorunu çözdüm
                yaz.Cells[9].Value = ((DateTime)oku["GirisTarihi"]).ToString("dd.MM.yyyy");
                yaz.Cells[10].Value = ((DateTime)oku["CikisTarihi"]).ToString("dd.MM.yyyy");

                dataGridView1.Rows.Add(yaz);
            }

            baglanti.Close();
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
    }
    
}
