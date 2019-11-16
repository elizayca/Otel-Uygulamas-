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
    public partial class EtkinlikEkle : Form
    {
        public EtkinlikEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=eliz\sqlexpress;Initial Catalog=otelotomasyon;Integrated Security=True");

        private void dateduy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_etkinlik(Etkinliktarih,Etkinlikyer,Etkinlikmetin)values('" + dateet.Text + "','" + etyer.Text + "','"+txtduy.Text+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etkinlik eklendi.");
            txtduy.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_etkinlik", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Etkinlikid"].ToString();
                ekle.SubItems.Add(oku["Etkinlikmetin"].ToString());
                ekle.SubItems.Add(oku["Etkinliktarih"].ToString());
                ekle.SubItems.Add(oku["Etkinlikyer"].ToString());
               

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        int id = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from tbl_etkinlik where Etkinlikid=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi gerçekleştirildi");
            etyer.Clear();
            txtduy.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_etkinlik set Etkinliktarih='" + dateet.Text + "',Etkinlikmetin='" + txtduy.Text + "',Etkinlikyer='"+etyer.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Güncelleme işlemi gerçekleştirildi.");
            etyer.Clear();
            txtduy.Clear();
           
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            dateet.Text = listView1.SelectedItems[0].SubItems[2].Text;
            etyer.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtduy.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }
    }
}
