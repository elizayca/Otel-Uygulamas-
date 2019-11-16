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
    public partial class MüşteriGörüntüle : Form
    {
        public MüşteriGörüntüle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=eliz\sqlexpress;Initial Catalog=otelotomasyon;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_musteri", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Musteriadi"].ToString());
                ekle.SubItems.Add(oku["Musterisoyadi"].ToString());
                ekle.SubItems.Add(oku["Musteritc"].ToString());
                ekle.SubItems.Add(oku["Mustericinsiyet"].ToString());
                ekle.SubItems.Add(oku["Musteritelefon"].ToString());
                ekle.SubItems.Add(oku["Musterimail"].ToString());
                ekle.SubItems.Add(oku["Musteriodano"].ToString());
                ekle.SubItems.Add(oku["Musteriucret"].ToString());
                ekle.SubItems.Add(oku["Musterigiris"].ToString());
                ekle.SubItems.Add(oku["Mustericikis"].ToString());

                listView1.Items.Add(ekle);


            }
            baglanti.Close();
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txttel.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtmail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txttc.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtodano.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dategiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            datecikis.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from tbl_musteri where Musteriid=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi gerçekleştirildi");
            ekraniTemizle();
            verileriGoster();
           
        }
        private void ekraniTemizle()
        {
            txtad.Clear();
            txtsoyad.Clear();
            txttc.Clear();
            txttel.Clear();
            txtmail.Clear();
            txtodano.Clear();
            txtucret.Clear();
            comboBox1.Text = " ";
          
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_musteri set Musteriadi='" + txtad.Text + "',Musterisoyadi='" + txtsoyad.Text + "',Musteritc='" + txttc.Text + "',Mustericinsiyet='" + comboBox1.Text + "',Musteritelefon='" + txttel.Text + "',Musterimail='" + txtmail.Text + "',Musteriodano='" + txtodano.Text + "',Musteriucret='" + txtucret.Text + "',Musterigiris='" + dategiris.Text + "',Mustericikis='" + datecikis.Text + "' where Musteriid="+id+"", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Güncelleme işlemi gerçekleştirildi.");
            

        }

        private void verileriGoster()
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txttel.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtmail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txttc.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtodano.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dategiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            datecikis.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_musteri where Musteriadi like '%"+txtara.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Musteriadi"].ToString());
                ekle.SubItems.Add(oku["Musterisoyadi"].ToString());
                ekle.SubItems.Add(oku["Musteritc"].ToString());
                ekle.SubItems.Add(oku["Mustericinsiyet"].ToString());
                ekle.SubItems.Add(oku["Musteritelefon"].ToString());
                ekle.SubItems.Add(oku["Musterimail"].ToString());
                ekle.SubItems.Add(oku["Musteriodano"].ToString());
                ekle.SubItems.Add(oku["Musteriucret"].ToString());
                ekle.SubItems.Add(oku["Musterigiris"].ToString());
                ekle.SubItems.Add(oku["Mustericikis"].ToString());

                listView1.Items.Add(ekle);


            }
            baglanti.Close();

        }
    }
}
