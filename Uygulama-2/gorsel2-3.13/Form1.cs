using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorsel2_3._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            int s3 = Convert.ToInt32(textBox3.Text);
            int[] dizim = new int[3] { s1, s2, s3 };
           
            int gecici = 0;
            for (int i = 0; i < dizim.Length - 1; i++)
            {
                for (int j = i; j < dizim.Length; j++)
                {
                    if (dizim[i] < dizim[j])//küçükten büyüğe doğru > değiştir.
                    {
                        gecici = dizim[j];
                        dizim[j] = dizim[i];
                        dizim[i] = gecici;
                    }
                }
            }
            foreach (int deger in dizim)
            {
                textBox4.Text+=deger.ToString() + " ";
            }





        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
