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
    public partial class Oneri : Form
    {
        public Oneri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=eliz\sqlexpress;Initial Catalog=otelotomasyon;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Oneri_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_oneri(Oneriadisoyadi,Onerimail,Onerikonu,Onerimesaj)values('" + txtad.Text + "','" + txtmail.Text + "','" + txtkonu.Text + "','" + txtmsj.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız alındı.En kısa zamanda dönüş yapılacaktır.");
            txtad.Clear();
            txtkonu.Clear();
            txtmail.Clear();
            txtmsj.Clear();

        }
    }
}
