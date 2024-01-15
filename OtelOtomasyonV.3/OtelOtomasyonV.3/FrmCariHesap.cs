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
    public partial class FrmCariHesap : Form
    {
        public FrmCariHesap()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=C:\\Users\\batuh\\source\\repos\\OtelOtomasyonV.3\\Database.mdb");

        private void FrmCariHesap_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            //ODA GELİRLERİ
            OleDbCommand oda = new OleDbCommand(" Select sum(Ucret) as OdaGelir from MusteriEkle", baglanti);
            OleDbDataReader oku = oda.ExecuteReader();

            while (oku.Read()) 
            { 
                LblOda.Text = oku["OdaGelir"].ToString();

            }
            

            //MAAŞLAR
            OleDbCommand maas = new OleDbCommand(" Select sum(Maas) as Maas from Personel", baglanti);
            OleDbDataReader oku1 = maas.ExecuteReader();

            while (oku1.Read())
            {
                LblMaas.Text = oku1["Maas"].ToString();

            }

            //ELEKTRİK
            OleDbCommand elektrik = new OleDbCommand(" Select sum(Elektrik) as Elektrik from Faturalar", baglanti);
            OleDbDataReader oku2 = elektrik.ExecuteReader();

            while (oku2.Read())
            {
                LblElektrik.Text = oku2["Elektrik"].ToString();

            }

            //SU
            OleDbCommand su = new OleDbCommand(" Select sum(Su) as Su from Faturalar", baglanti);
            OleDbDataReader oku3 = su.ExecuteReader();

            while (oku3.Read())
            {
                LblSu.Text = oku3["Su"].ToString();

            }

            //DOĞALGAZ
            OleDbCommand dogalgaz = new OleDbCommand(" Select sum(Dogalgaz) as Dogalgaz from Faturalar", baglanti);
            OleDbDataReader oku4 = dogalgaz.ExecuteReader();

            while (oku4.Read())
            {
                LblGaz.Text = oku4["Dogalgaz"].ToString();

            }

            //İNTERNET
            OleDbCommand internet = new OleDbCommand(" Select sum(Internet) as Internet from Faturalar", baglanti);
            OleDbDataReader oku5 = internet.ExecuteReader();

            while (oku5.Read())
            {
                LblInternet.Text = oku5["Internet"].ToString();

            }

            //GIDA
            OleDbCommand gida = new OleDbCommand(" Select sum(Gida) as Gida from Urunler", baglanti);
            OleDbDataReader oku6 = gida.ExecuteReader();

            while (oku6.Read())
            {
                LblGida.Text = oku6["Gida"].ToString();

            }

            //İçecek
            OleDbCommand icecek = new OleDbCommand(" Select sum(Icecek) as Icecek from Urunler", baglanti);
            OleDbDataReader oku7 = icecek.ExecuteReader();

            while (oku7.Read())
            {
                LblIcecek.Text = oku7["Icecek"].ToString();

            }

            //Atıştırmalık
            OleDbCommand atistirmalik = new OleDbCommand(" Select sum(Atistirmalik) as Atistirmalik from Urunler", baglanti);
            OleDbDataReader oku8 = atistirmalik.ExecuteReader();

            while (oku8.Read())
            {
                LblAtistirmalik.Text = oku8["Atistirmalik"].ToString();

            }


            baglanti.Close();

            //KASA

            int kasa;
            kasa = Convert.ToInt32(LblOda.Text) - ( Convert.ToInt32(LblMaas.Text) + Convert.ToInt32(LblElektrik.Text) + Convert.ToInt32(LblSu.Text) + Convert.ToInt32(LblGaz.Text) + Convert.ToInt32(LblInternet.Text) + Convert.ToInt32(LblGida.Text) + Convert.ToInt32(LblIcecek.Text) + Convert.ToInt32(LblAtistirmalik.Text) );
            LblKasa.Text = kasa.ToString();

        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            FrmAdmin Admin = new FrmAdmin();
            Admin.Show();
            this.Hide();
        }
    }
}
