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
using System.Drawing.Configuration;

namespace OtelOtomasyonV._3
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=C:\\Users\\batuh\\source\\repos\\OtelOtomasyonV.3\\Database.mdb");



        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            FrmPersonel AnaSayfa = new FrmPersonel();
            AnaSayfa.Show();
            this.Hide();
        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            odayaz();
        }


                   
        public void odayaz()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from MusteriEkle",baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                switch(oku[7].ToString())
                {
                    case "101":
                        {
                            BtnOda101.Text = oku[7].ToString();
                            BtnOda101.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "102":
                        {
                            BtnOda102.Text = oku[7].ToString();
                            BtnOda102.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "103":
                        {
                            BtnOda103.Text = oku[7].ToString();
                            BtnOda103.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "104":
                        {
                            BtnOda104.Text = oku[7].ToString();
                            BtnOda104.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "105":
                        {
                            BtnOda105.Text = oku[7].ToString();
                            BtnOda105.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "201":
                        {
                            BtnOda201.Text = oku[7].ToString();
                            BtnOda201.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "202":
                        {
                            BtnOda202.Text = oku[7].ToString();
                            BtnOda202.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "203":
                        {
                            BtnOda203.Text = oku[7].ToString();
                            BtnOda203.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "204":
                        {
                            BtnOda204.Text = oku[7].ToString();
                            BtnOda204.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "205":
                        {
                            BtnOda205.Text = oku[7].ToString();
                            BtnOda205.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "301":
                        {
                            BtnOda301.Text = oku[7].ToString();
                            BtnOda301.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "302":
                        {
                            BtnOda302.Text = oku[7].ToString();
                            BtnOda302.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "303":
                        {
                            BtnOda303.Text = oku[7].ToString();
                            BtnOda303.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "304":
                        {
                            BtnOda304.Text = oku[7].ToString();
                            BtnOda304.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "305":
                        {
                            BtnOda305.Text = oku[7].ToString();
                            BtnOda305.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "401":
                        {
                            BtnOda401.Text = oku[7].ToString();
                            BtnOda401.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "402":
                        {
                            BtnOda402.Text = oku[7].ToString();
                            BtnOda402.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "403":
                        {
                            BtnOda403.Text = oku[7].ToString();
                            BtnOda403.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "404":
                        {
                            BtnOda404.Text = oku[7].ToString();
                            BtnOda404.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "405":
                        {
                            BtnOda405.Text = oku[7].ToString();
                            BtnOda405.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                }

            }

            baglanti.Close();
            oku.Dispose();
        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {

        }
    }
}
