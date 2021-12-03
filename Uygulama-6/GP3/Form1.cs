using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int saat = Convert.ToInt32(textBox1.Text);
            int ucret = 0;
            int katsayi = 0;
            int secilen = comboBox2.SelectedIndex;
            if (secilen == 0) katsayi = 5;
            else if (secilen == 1) katsayi = 10;
            else katsayi = 15;
            ucret = saat * katsayi;
            lblSonuc.Text = ucret.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
