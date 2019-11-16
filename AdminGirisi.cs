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
    public partial class AdminGirisi : Form
    {
        public AdminGirisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=eliz\sqlexpress;Initial Catalog=otelotomasyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from tbl_admin where Kullaniciadi=@Kullaniciadi and Kullanicisifre=@Kullanicisifre", baglanti);
              //  komut.ExecuteNonQuery();
                SqlParameter prm1 = new SqlParameter("Kullaniciadi", txtkullanici.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Kullanicisifre", txtsifre.Text.Trim());
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    AdminAnasayfa fr = new AdminAnasayfa();
                    fr.Show();
                    this.Hide();
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }

        }
    }
}
