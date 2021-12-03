using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        kbr kb = new kbr();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string soruno = cbsoru.SelectedValue.ToString();
                kb.cevaplari_getir(soruno, LbCevap);
                kb.grafik_goster(soruno, grafik);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kb.sorulari_getir(cbsoru);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LbCevap.SelectedIndex >= 0)
            {
                string cevapno = LbCevap.SelectedValue.ToString();
                string soruno = cbsoru.SelectedValue.ToString();
                kb.oyver(cevapno);
                kb.grafik_goster(soruno, grafik);
            }
            else
            {
                MessageBox.Show("Bir cevap seçmelisiniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Anketi sonlandırmak istediğinize emin misiniz ?", "Anket Sonlandırılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (cevap == DialogResult.Yes)
                Application.Exit();
        }
    }
}
