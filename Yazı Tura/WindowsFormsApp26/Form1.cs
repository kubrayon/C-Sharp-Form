using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
/*Uygulama 6: Aşağıdaki form görüntüsünü oluşturunuz.
* Butona basınca rasgele yazı tura atan kodu yapınız */
        private void button1_Click(object sender, EventArgs e)
        {

            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rasgele = new Random();
            int gelen = rasgele.Next(1,3);
            if (gelen==1)
            {
                pictureBox1.BackgroundImage = Image.FromFile("yazi.jpg");System.Threading.Thread.Sleep(200);
                pictureBox1.BackgroundImage = Image.FromFile("tura.jpg"); System.Threading.Thread.Sleep(200);
                pictureBox1.BackgroundImage = Image.FromFile("yazi.jpg"); System.Threading.Thread.Sleep(200);
                pictureBox1.BackgroundImage = Image.FromFile("tura.jpg"); System.Threading.Thread.Sleep(200);
                pictureBox1.BackgroundImage = Image.FromFile("yazi.jpg");

            }
            else
            {
                pictureBox1.BackgroundImage = Image.FromFile("tura.jpg"); System.Threading.Thread.Sleep(200);
                pictureBox1.BackgroundImage = Image.FromFile("yazi.jpg"); System.Threading.Thread.Sleep(200);
                pictureBox1.BackgroundImage = Image.FromFile("tura.jpg"); System.Threading.Thread.Sleep(200);
                pictureBox1.BackgroundImage = Image.FromFile("yazi.jpg"); System.Threading.Thread.Sleep(200);
                pictureBox1.BackgroundImage = Image.FromFile("tura.jpg");

            }
        }
    }
}
