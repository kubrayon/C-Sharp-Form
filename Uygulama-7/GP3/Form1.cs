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

        private void Form1_Load(object sender, EventArgs e)
        {
            //Miktar değeri numericupdown kontrolüne girdikten sonra radio düğmeleri ile kullanıcı labeldaki
            //sayıyı arttıracak veya azaltacaktır.Bu işlemi yapan buton olayını yazınız.
        }
        int sayi =0;
        private void button1_Click(object sender, EventArgs e)
        {
         
           
            int miktar = Convert.ToInt32(numericUpDown1.Value);
            if (radioButton1.Checked)
            {
                sayi += miktar;
            }
            else
            {
                sayi -= miktar;
            }
            lblSonuc.Text = sayi.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
