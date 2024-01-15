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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOdalar Oda = new FrmOdalar();
            Oda.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMusteriler Musteri_islem = new FrmMusteriler();
            Musteri_islem.Show();
            this.Hide();
        }
    }
}
