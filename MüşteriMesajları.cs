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
    public partial class MüşteriMesajları : Form
    {
        public MüşteriMesajları()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=eliz\sqlexpress;Initial Catalog=otelotomasyon;Integrated Security=True");


        private void MüşteriMesajları_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_oneri", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Oneriid"].ToString();
                ekle.SubItems.Add(oku["Oneriadisoyadi"].ToString());
                ekle.SubItems.Add(oku["Onerikonu"].ToString());
                ekle.SubItems.Add(oku["Onerimail"].ToString());
                ekle.SubItems.Add(oku["Onerimesaj"].ToString());
                listView1.Items.Add(ekle);

            }
        }
        int id = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from tbl_oneri where Oneriid=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi gerçekleştirildi");
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[4].Text;            

        }
    }
}
