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
    public partial class FrmSifreDegis : Form
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=C:\\Users\\batuh\\source\\repos\\OtelOtomasyonV.3\\Database.mdb");

        public FrmSifreDegis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from Personel where TcKimlik='" + TxtTc.Text + "'", baglanti);
            
            
            baglanti.Open();

            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                flowLayoutPanel1.Visible = false;
                TxtGizliSoru.Text = oku["Gizli_Soru"].ToString();
                baglanti.Close();


            }
            else
            {
                MessageBox.Show("TC Numaranız Yada Şifreniz Yanlış Yazılmıştır");
                TxtTc.Text = "";
                TxtYanit.Text = "";
                baglanti.Close();
                //verileri temizler
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from Personel where TcKimlik='" + TxtTc.Text + "' and Gizli_Cevap ='" + TxtYanit.Text + "'", baglanti);
            

            if (ConnectionState.Closed == baglanti.State)
            {
                baglanti.Open();

            }

            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                flowLayoutPanel2.Visible = false;
                TxtSifre.Text = oku["Sifre"].ToString();

            }
            else
            {
                MessageBox.Show("Hatalı Bilgiler");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmGiris giris = new FrmGiris();
            giris.Show();
            this.Hide();
        }
    }
}
