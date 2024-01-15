using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonV._3
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPersonelIslemleri PersonelIslem = new FrmPersonelIslemleri();
            PersonelIslem.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmFaturaVeUrunler fr = new FrmFaturaVeUrunler();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCariHesap fr = new FrmCariHesap();
            fr.Show();
            this.Hide();
        }

        
    }
}
