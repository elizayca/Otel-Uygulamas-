using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Otel_Uygulaması
{
    public partial class Etkinlikler : Form
    {
        public Etkinlikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=eliz\sqlexpress;Initial Catalog=otelotomasyon;Integrated Security=True");

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Etkinlikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_etkinlik", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Etkinlikmetin"].ToString();
                ekle.SubItems.Add(oku["Etkinliktarih"].ToString());
                ekle.SubItems.Add(oku["Etkinlikyer"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
