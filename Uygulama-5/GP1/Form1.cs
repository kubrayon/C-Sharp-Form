using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnToplam.Text = "Topla";
            lblToplam.Text = "Sonuç";
        }

        private void btnDoldur_Click(object sender, EventArgs e)
        {
            int sayi;
            Random rastgele = new Random();
            for (int i = 0; i < 50; i++)
            {
                sayi = rastgele.Next(0, 1000);
                lbListele.Items.Add(sayi);
            }
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            int toplam=0;
            int sayi;
            for (int i = 0; i < 50; i++)
            {
                sayi = Convert.ToInt32(lbListele.Items[i]);
                toplam += sayi;
            }
            lblToplam.Text = toplam.ToString();
        }
    }
}
