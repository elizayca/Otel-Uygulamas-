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
    public partial class YeniMüşteriEkleme : Form
    {
        public YeniMüşteriEkleme()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=eliz\sqlexpress;Initial Catalog=otelotomasyon;Integrated Security=True");
        


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtodano.Text = "101";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnoda102_Click(object sender, EventArgs e)
        {
            txtodano.Text = "102";

        }

        private void btnoda103_Click(object sender, EventArgs e)
        {
            txtodano.Text = "103";
        }

        private void btnoda104_Click(object sender, EventArgs e)
        {
            txtodano.Text = "104";
        }

        private void btnoda105_Click(object sender, EventArgs e)
        {
            txtodano.Text = "105";
        }

        private void btnoda106_Click(object sender, EventArgs e)
        {
            txtodano.Text = "106";
            
        }

        private void btnoda107_Click(object sender, EventArgs e)
        {
            txtodano.Text = "107";
        }

        private void btnoda108_Click(object sender, EventArgs e)
        {
            txtodano.Text = "108";
        }

        private void btnoda109_Click(object sender, EventArgs e)
        {
            txtodano.Text = "109";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızılar dolu odaları göstermektedir.");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşiller boş odaları göstermektedir.");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void datecikis_ValueChanged(object sender, EventArgs e)
        {
            ucrethesapla();
        }


        private void ucrethesapla()
        {
            int ucret;
            DateTime girisTarih = Convert.ToDateTime(dategiris.Text);
            DateTime cikisTarih = Convert.ToDateTime(datecikis.Text);
            TimeSpan sonuc = cikisTarih - girisTarih;
            String sonuc2= sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(sonuc2) * 50;
            txtucret.Text = ucret.ToString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("insert into tbl_musteri(Musteriadi,Musterisoyadi,Musteritc,Mustericinsiyet,Musteritelefon,Musterimail,Musteriodano,Musteriucret,Musterigiris,Mustericikis)values('"+txtad.Text+"','"+txtsoyad.Text+"','"+txttc.Text+"','"+comboBox1.Text+"','"+txttel.Text+"','"+txtmail.Text+"','"+txtodano.Text+"','"+txtucret.Text+"','"+dategiris.Text+"','"+datecikis.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri başarıyla eklendi.");
        }

        private void YeniMüşteriEkleme_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + btnoda101.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                btnoda101.Text = oku["Musteriadi"].ToString() + " " + oku["Musterisoyadi"].ToString();
            }
            if (btnoda101.Text != "101")
            {
                btnoda101.BackColor = Color.Red;
                btnoda101.Enabled = false;
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + btnoda102.Text + "'", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btnoda102.Text = oku2["Musteriadi"].ToString() + " " + oku2["Musterisoyadi"].ToString();
            }
            if (btnoda102.Text != "102")
            {
                btnoda102.BackColor = Color.Red;
                btnoda102.Enabled = false;
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + btnoda103.Text + "'", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btnoda103.Text = oku3["Musteriadi"].ToString() + " " + oku3["Musterisoyadi"].ToString();
            }
            if (btnoda103.Text != "103")
            {
                btnoda103.BackColor = Color.Red;
                btnoda103.Enabled = false;
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + btnoda104.Text + "'", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btnoda104.Text = oku4["Musteriadi"].ToString() + " " + oku4["Musterisoyadi"].ToString();
            }
            if (btnoda104.Text != "104")
            {
                btnoda104.BackColor = Color.Red;
                btnoda104.Enabled = false;
            }

            baglanti.Close();
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + btnoda105.Text + "'", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btnoda105.Text = oku5["Musteriadi"].ToString() + " " + oku5["Musterisoyadi"].ToString();
            }
            if (btnoda105.Text != "105")
            {
                btnoda105.BackColor = Color.Red;
                btnoda105.Enabled = false;
            }

            baglanti.Close();
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + btnoda106.Text + "'", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btnoda106.Text = oku6["Musteriadi"].ToString() + " " + oku6["Musterisoyadi"].ToString();
            }
            if (btnoda106.Text != "106")
            {
                btnoda106.BackColor = Color.Red;
                btnoda106.Enabled = false;
            }

            baglanti.Close();

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + btnoda107.Text + "'", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btnoda107.Text = oku7["Musteriadi"].ToString() + " " + oku7["Musterisoyadi"].ToString();
            }
            if (btnoda107.Text != "107")
            {
                btnoda107.BackColor = Color.Red;
                btnoda107.Enabled = false;
            }

            baglanti.Close();
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + btnoda108.Text + "'", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btnoda108.Text = oku8["Musteriadi"].ToString() + " " + oku8["Musterisoyadi"].ToString();
            }
            if (btnoda108.Text != "108")
            {
                btnoda108.BackColor = Color.Red;
                btnoda108.Enabled = false;
            }

            baglanti.Close();
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select * from tbl_musteri where Musteriodano='" + btnoda109.Text + "'", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                btnoda109.Text = oku9["Musteriadi"].ToString() + " " + oku9["Musterisoyadi"].ToString();
            }
            if (btnoda109.Text != "109")
            {
                btnoda109.BackColor = Color.Red;
                btnoda109.Enabled = false;
            }

            baglanti.Close();
        }
    }


}
