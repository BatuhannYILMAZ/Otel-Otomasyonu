using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonV._3
{
    public partial class FrmPersonelIslemleri : Form
    {

                                                                       
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=C:\\Users\\batuh\\source\\repos\\OtelOtomasyonV.3\\Database.mdb");

        public FrmPersonelIslemleri()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            dataGridView1.Rows.Clear(); //her çağrıldıgında datagrid i temizler

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from Personel", baglanti);
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

                yaz.Cells[6].Value = ((DateTime)oku["Dogum_Tarih"]).ToString("dd.MM.yyyy");
                yaz.Cells[7].Value = oku["Gorev"].ToString();
                yaz.Cells[8].Value = oku["Sifre"].ToString();
                yaz.Cells[9].Value = oku["Gizli_Soru"].ToString();
                yaz.Cells[10].Value = oku["Gizli_Cevap"].ToString();
                yaz.Cells[11].Value = oku["Maas"].ToString();


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
            CbGorev.Text = "Seçiniz";
            TxtSifre.Clear();
            comboBox2.Text = "Seçiniz";
            TxtGizliCevap.Clear();
            TxtMaas.Clear();
            DtpDogumTarihi.Value = DateTime.Today;
        }

        private void FrmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //datagridview den satıra basınca textboxlara bilgileri taşır
            TxtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtKimlikNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtSoyadi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            MskTxtTelefon.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            DtpDogumTarihi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            CbGorev.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            TxtSifre.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            TxtGizliCevap.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            TxtMaas.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            FrmAdmin Admin = new FrmAdmin();
            Admin.Show();
            this.Hide();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand sil = new OleDbCommand("delete from Personel where id=" + TxtId.Text, baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Silme İşlemi Başarılı");

            Temizle();
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand guncelle = new OleDbCommand("update Personel set TcKimlik= '" + TxtKimlikNo.Text + "', Ad='" + TxtAdi.Text + "', Soyad='" + TxtSoyadi.Text + "', Cinsiyet='" + comboBox1.Text + "', Telefon='" + MskTxtTelefon.Text + "', Dogum_Tarih='" + DtpDogumTarihi.Value.ToString("yyyy-MM-dd") + "', Gorev='" + CbGorev.Text + "', Sifre='" + TxtSifre.Text + "', Gizli_Soru='" + comboBox2.Text + "', Gizli_Cevap='" + TxtGizliCevap.Text + "' , Maas='" + TxtMaas.Text + "'  where id=" + TxtId.Text, baglanti);
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
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Personel WHERE TcKimlik LIKE '" + TxtTcAra.Text + "%'", baglanti);


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

                yaz.Cells[6].Value = ((DateTime)oku["Dogum_Tarih"]).ToString("dd.MM.yyyy");
                yaz.Cells[7].Value = oku["Gorev"].ToString();
                yaz.Cells[8].Value = oku["Sifre"].ToString();
                yaz.Cells[9].Value = oku["Gizli_Soru"].ToString();
                yaz.Cells[10].Value = oku["Gizli_Cevap"].ToString();
                yaz.Cells[11].Value = oku["Maas"].ToString();

                dataGridView1.Rows.Add(yaz);
            }

            baglanti.Close();
        }

        private void BtnAdSorgu_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); //her çağrıldıgında datagrid i temizler

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Personel WHERE Ad LIKE '" + TxtAdAra.Text + "%'", baglanti);


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

                yaz.Cells[6].Value = ((DateTime)oku["Dogum_Tarih"]).ToString("dd.MM.yyyy");
                yaz.Cells[7].Value = oku["Gorev"].ToString();
                yaz.Cells[8].Value = oku["Sifre"].ToString();
                yaz.Cells[9].Value = oku["Gizli_Soru"].ToString();
                yaz.Cells[10].Value = oku["Gizli_Cevap"].ToString();
                yaz.Cells[11].Value = oku["Maas"].ToString();

                dataGridView1.Rows.Add(yaz);
            }

            baglanti.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Personel (TcKimlik,Ad,Soyad,Cinsiyet,Telefon,Dogum_Tarih,Gorev,Sifre,Gizli_Soru,Gizli_Cevap,Maas) values ('" + TxtKimlikNo.Text + "' , '" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + comboBox1.Text + "' , '" + MskTxtTelefon.Text + "' , '" + DtpDogumTarihi.Value.ToString("yyyy-MM-dd") + "' , '" + CbGorev.Text + "' , '" + TxtSifre.Text + "' , '" + comboBox2.Text + "' , '" + TxtGizliCevap.Text + "' , '" + TxtMaas.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Başarıyla Kaydedildi.");

            Listele();
            Temizle();
        }


        //Gorev seçilince ücret otomatik yazdırma
        private void CbGorev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbGorev.SelectedIndex == 0)
            {
                TxtMaas.Text = "12000";
            }
            else if (CbGorev.SelectedIndex == 1)
            {
                TxtMaas.Text = "12000";
            }
            else if (CbGorev.SelectedIndex == 2)
            {
                TxtMaas.Text = "12000";
            }
            else if (CbGorev.SelectedIndex == 3)
            {
                TxtMaas.Text = "13000";
            }
            else if (CbGorev.SelectedIndex == 4)
            {
                TxtMaas.Text = "15000";
            }
            else if (CbGorev.SelectedIndex == 5)
            {
                TxtMaas.Text = "14000";
            }
            else if (CbGorev.SelectedIndex == 6)
            {
                TxtMaas.Text = "12000";
            }

        }
    }
}
