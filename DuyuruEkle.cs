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
    public partial class DuyuruEkle : Form
    {
        public DuyuruEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=eliz\sqlexpress;Initial Catalog=otelotomasyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_duyuru(Duyurutarih,Duyurumetin)values('" + dateduy.Text + "','" + txtduy.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Duyuru eklendi.");
            txtduy.Clear();


        }

        private void txtduy_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateduy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_duyuru", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Duyuruid"].ToString();
                ekle.SubItems.Add(oku["Duyurutarih"].ToString());
                ekle.SubItems.Add(oku["Duyurumetin"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            dateduy.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtduy.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_duyuru set Duyurutarih='" + dateduy.Text + "',Duyurumetin='" + txtduy.Text + "')", baglanti);
            baglanti.Close();
            MessageBox.Show("Müşteri Güncelleme işlemi gerçekleştirildi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from tbl_duyuru where Duyuruid=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi gerçekleştirildi");
            txtduy.Clear();
        }

        private void DuyuruEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
