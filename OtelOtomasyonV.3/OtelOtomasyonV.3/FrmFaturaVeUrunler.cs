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
    public partial class FrmFaturaVeUrunler : Form
    {
        public FrmFaturaVeUrunler()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=C:\\Users\\batuh\\source\\repos\\OtelOtomasyonV.3\\Database.mdb");

        public void Listele()
        {
            dataGridView1.Rows.Clear(); //her çağrıldıgında datagrid1 i temizler
            dataGridView2.Rows.Clear(); 


            baglanti.Open();
            //ÜRÜNLER
            OleDbCommand komutStok = new OleDbCommand("select * from Urunler", baglanti);
            OleDbDataReader oku = komutStok.ExecuteReader();

            while (oku.Read())
            {
                DataGridViewRow yaz = new DataGridViewRow();
                yaz.CreateCells(dataGridView1);

                yaz.Cells[0].Value = oku["Gida"].ToString();
                yaz.Cells[1].Value = ((DateTime)oku["Gida_Tarih"]).ToString("dd.MM.yyyy");
                yaz.Cells[2].Value = oku["Icecek"].ToString();
                yaz.Cells[3].Value = ((DateTime)oku["Icecek_Tarih"]).ToString("dd.MM.yyyy");
                yaz.Cells[4].Value = oku["Atistirmalik"].ToString();
                yaz.Cells[5].Value = ((DateTime)oku["Atistirmalik_Tarih"]).ToString("dd.MM.yyyy");


                dataGridView1.Rows.Add(yaz);
            }

            //FATURALAR
            OleDbCommand komutFatura = new OleDbCommand("select * from Faturalar", baglanti);
            OleDbDataReader oku1 = komutFatura.ExecuteReader();

            while (oku1.Read())
            {
                DataGridViewRow yaz1 = new DataGridViewRow();
                yaz1.CreateCells(dataGridView2);

                yaz1.Cells[0].Value = oku1["Elektrik"].ToString();
                yaz1.Cells[1].Value = ((DateTime)oku1["Elektrik_Tarih"]).ToString("dd.MM.yyyy");
                yaz1.Cells[2].Value = oku1["Su"].ToString();
                yaz1.Cells[3].Value = ((DateTime)oku1["Su_Tarih"]).ToString("dd.MM.yyyy");
                yaz1.Cells[4].Value = oku1["Dogalgaz"].ToString();
                yaz1.Cells[5].Value = ((DateTime)oku1["Dogalgaz_Tarih"]).ToString("dd.MM.yyyy");
                yaz1.Cells[6].Value = oku1["Internet"].ToString();
                yaz1.Cells[7].Value = ((DateTime)oku1["Internet_Tarih"]).ToString("dd.MM.yyyy");



                dataGridView2.Rows.Add(yaz1);
            }

            baglanti.Close();

        }

        public void temizle()
        {
            //ÜRÜNLER KISMI
            TxtGida.Clear();
            DtpGidaTarihi.Value = DateTime.Today;
            TxtIcecek.Clear();
            DtpIcecekTarihi.Value = DateTime.Today;
            TxtAtistirmalik.Clear();
            DtpAtistirmalikTarihi.Value = DateTime.Today;
            
            //FATURALAR KISMI
            TxtElektrik.Clear();
            DtpElektrikTarihi.Value = DateTime.Today;
            TxtSu.Clear();
            DtpSuTarihi.Value = DateTime.Today;
            TxtGaz.Clear();
            DtpGazTarihi.Value = DateTime.Today;
            TxtInternet.Clear();
            DtpInternetTarihi.Value = DateTime.Today;

        }

        private void FrmFaturaVeUrunler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            FrmAdmin Admin = new FrmAdmin();
            Admin.Show();
            this.Hide();
        }

        private void BtnUrunKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Urunler (Gida,Gida_Tarih,Icecek,Icecek_Tarih,Atistirmalik,Atistirmalik_Tarih) values ('" + TxtGida.Text + "','" + DtpGidaTarihi.Value.ToString("yyyy-MM-dd") + "','" + TxtIcecek.Text + "', '" + DtpIcecekTarihi.Value.ToString("yyyy-MM-dd") + "','" + TxtAtistirmalik.Text + "','" + DtpAtistirmalikTarihi.Value.ToString("yyyy-MM-dd") + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürünler Başarıyla Kaydedildi");

            Listele();
            temizle();
        }

        private void BtnFaturaKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Faturalar (Elektrik,Elektrik_Tarih,Su,Su_Tarih,Dogalgaz,Dogalgaz_Tarih,Internet,Internet_Tarih) values ('" + TxtElektrik.Text + "','" + DtpElektrikTarihi.Value.ToString("yyyy-MM-dd") + "','" + TxtSu.Text + "', '" + DtpSuTarihi.Value.ToString("yyyy-MM-dd") + "' , '" + TxtGaz.Text + "', '" + DtpGazTarihi.Value.ToString("yyyy-MM-dd") + "' , '" + TxtInternet.Text + "' , '" + DtpInternetTarihi.Value.ToString("yyyy-MM-dd") + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Faturalar Başarıyla Kaydedildi");

            Listele();
            temizle();
        }
    }
}
