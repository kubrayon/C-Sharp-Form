using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace kelime
{
    class kubra
    {
        SqlConnection bag = new SqlConnection("server=PC-BILGISAYAR\\SQLEXPRESS;initial catalog = kelimetahmin; integrated security = true;");
        public string kelimegetir(bool en)
        {
            string sql = "select tr, en from kelimeler";
            int index;
            int kelime_sayisi;
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            kelime_sayisi = tablo.Rows.Count;
            Random rasgele = new Random();
            index = rasgele.Next(0, kelime_sayisi);
            if (en == true)
                return tablo.Rows[index][1].ToString();
            else
                return tablo.Rows[index][0].ToString();
        }
        public string kelimegizle(string kelimem)
        {
            kelimem = kelimem.Trim();
            string gizli = "";
            for (int i = 0; i < kelimem.Length; i++)
            {
                gizli += "*";
            }
            return gizli;
        }
        public string dene(string harf,string kelime,string gizli)
        {
            string yeni="";
            kelime = kelime.Trim();
            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime[i].ToString() == harf.ToString())
                {
                    yeni += harf.ToString();
                }
                else
                {
                    yeni += gizli[i].ToString();
                }   
            }
            return yeni;
        }
        public bool tahmin(string kelime,string tahmin)
        {
            if (kelime == tahmin)
                return true;
            else
                return false;
        }
    }
}
