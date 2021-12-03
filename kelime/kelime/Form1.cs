using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kelime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        kubra kbr = new kubra();
        string kelime="";
        int hak = 4;
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                kelime = kbr.kelimegetir(true);
                label1.Text = kbr.kelimegizle(kelime);
            }
            else
            {
                kelime = kbr.kelimegetir(false);
                label1.Text = kbr.kelimegizle(kelime);
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (hak>0)
            {
                label1.Text = kbr.dene(textBox1.Text, kelime, label1.Text);
                hak--;
            }
            else
            {
                MessageBox.Show("Hak bitti");
                textBox1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kbr.tahmin(kelime,textBox2.Text))
            {
                MessageBox.Show("Tahmin yanlış!");
            }
            else
            {
                MessageBox.Show("Tahmin doğru!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkılsın mı?", "Programı Kapat", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Çıkış yapılmadı");
            }
        }
    }
}
