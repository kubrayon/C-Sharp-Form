using System;
using System.Collections.Generic;
using System.Data.SqlClient;//
using System.Data.Sql;//
using System.Data;//
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//
using System.Windows.Forms.DataVisualization.Charting;//
namespace anket
{
    class kbr
    {
        SqlConnection bag = new SqlConnection(@"server=PC-BILGISAYAR\SQLEXPRESS;initial catalog=anket;integrated security=true");
        public void sorulari_getir(ComboBox cb)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM sorular ORDER BY soru", bag);

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            cb.DataSource = tablo;
            cb.ValueMember = "soruno";
            cb.DisplayMember = "soru";
        }
        public void cevaplari_getir(string soruno, ListBox lb)
        {
            SqlDataAdapter da = new SqlDataAdapter(("SELECT cevapno,cevap FROM cevaplar WHERE soruno=" + soruno), bag);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            lb.DataSource = tablo;
            lb.ValueMember = "cevapno";
            lb.DisplayMember = "cevap";
        }
        public void oyver(string cevapno)
        {
            string sql = "update cevaplar set oy=oy+1 where cevapno=" + cevapno;
            SqlCommand komut = new SqlCommand(sql, bag);
            bag.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Oy Kullanıldı");
            bag.Close();
        }
        public void grafik_goster(string soruno, Chart c)
        {
            string sql = "select sum(oy) from cevaplar where soruno=" + soruno;
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int toplam = Convert.ToInt32(dt.Rows[0][0]); 
            sql = "select cevap,oy,((oy*100)/" + toplam.ToString() + ") as yuzde from cevaplar where soruno = " + soruno;
            SqlDataAdapter da2 = new SqlDataAdapter(sql, bag);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            c.DataSource = dt2;
            c.Series[0].XValueMember = "cevap";
            c.Series[0].YValueMembers = "yuzde";
            c.Series[0].Name = "Grafik";
            c.Series[0].ChartType = SeriesChartType.Pie;
            c.DataBind();
        }
    }
}

