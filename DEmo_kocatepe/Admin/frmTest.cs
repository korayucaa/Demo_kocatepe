using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEmo_kocatepe.Admin
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            int sonuc, sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi;
            label1.Text = sonuc.ToString();
        }

        private void btnTekCift_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if(sayi % 2 == 0)
            {
                label2.Text = "Cift";
            }
            else
            {
                label2.Text = "Tek";
            }
        }

        private void btnBasamak_Click(object sender, EventArgs e)
        {
            int sayi,x,y,z,sonuc;
            sayi= Convert.ToInt32(textBox1.Text);
            x = sayi % 10;
            y = (sayi / 10) % 10;
            z = sayi / 100;
            sonuc = x + y + z;
            label3.Text = sonuc.ToString();

            
        }

        private void btnBakteri_Click(object sender, EventArgs e)
        {
            int bakteri,sayi;
            bakteri = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < 24; i++)
            {
               
                bakteri = bakteri * 2;

            }
            label3.Text = bakteri.ToString();
        }
    }
}
