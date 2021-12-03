using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                comboBox1.Items.Add(i);
                button1.Text = "Göster";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            int sayi =Convert.ToInt32( comboBox1.Text);
            int cevap = 0;
            for (int i = 1; i < 10; i++)
            {
                cevap = i * sayi;
                label1.Text += sayi.ToString() + "X" + i.ToString() + "=" + cevap.ToString() +"\n";

            }

        }
    }
}
