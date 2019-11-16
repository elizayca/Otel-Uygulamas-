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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=eliz\sqlexpress;Initial Catalog=otelotomasyon;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + button1.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                button1.Text = oku["Musteriadi"].ToString() + " "+ oku["Musterisoyadi"].ToString();
            }
            if (button1.Text!="101")
            {
                button1.BackColor = Color.Red;
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + button2.Text + "'", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                button2.Text = oku2["Musteriadi"].ToString() + " " + oku2["Musterisoyadi"].ToString();
            }
            if (button2.Text != "102")
            {
                button2.BackColor = Color.Red;
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + button3.Text + "'", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                button3.Text = oku3["Musteriadi"].ToString() + " " + oku3["Musterisoyadi"].ToString();
            }
            if (button3.Text != "103")
            {
                button3.BackColor = Color.Red;
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + button6.Text + "'", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                button6.Text = oku4["Musteriadi"].ToString() + " " + oku4["Musterisoyadi"].ToString();
            }
            if (button6.Text != "104")
            {
                button6.BackColor = Color.Red;
            }

            baglanti.Close();
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + button5.Text + "'", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                button5.Text = oku5["Musteriadi"].ToString() + " " + oku5["Musterisoyadi"].ToString();
            }
            if (button5.Text != "105")
            {
                button5.BackColor = Color.Red;
            }

            baglanti.Close();
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + button4.Text + "'", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                button4.Text = oku6["Musteriadi"].ToString() + " " + oku6["Musterisoyadi"].ToString();
            }
            if (button4.Text != "106")
            {
                button4.BackColor = Color.Red;
            }

            baglanti.Close();

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + button9.Text + "'", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                button9.Text = oku7["Musteriadi"].ToString() + " " + oku7["Musterisoyadi"].ToString();
            }
            if (button9.Text != "107")
            {
                button9.BackColor = Color.Red;
            }

            baglanti.Close();
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + button8.Text + "'", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                button8.Text = oku8["Musteriadi"].ToString() + " " + oku8["Musterisoyadi"].ToString();
            }
            if (button8.Text != "108")
            {
                button8.BackColor = Color.Red;
            }

            baglanti.Close();
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + button7.Text + "'", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                button7.Text = oku9["Musteriadi"].ToString() + " " + oku9["Musterisoyadi"].ToString();
            }
            if (button7.Text!= "109")
            {
                button7.BackColor = Color.Red;
            }

            baglanti.Close();

        }
    }
}
