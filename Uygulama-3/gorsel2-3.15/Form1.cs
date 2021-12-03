using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorsel2_3._15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*UYgulama: Textboxa girilen sayının faktöriyelini çarpmaları göstererek labela yazdıran kodu yazınızint  */
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int sonuc = 1;
            for (int i = sayi; i >=1; i--)
            {
                sonuc = sonuc * i;
                if (i==1)
                {
                    label1.Text += i.ToString() + " =  "+sonuc;

                }
                else
                {
                     label1.Text += i.ToString() +" X  ";
                }
               
            }
        }
    }
}
