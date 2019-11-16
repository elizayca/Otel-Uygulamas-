using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Uygulaması
{
    public partial class MusteriAnasayfa : Form
    {
        public MusteriAnasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Galeri fr = new Galeri();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Oneri fr = new Oneri();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Duyurular fr = new Duyurular();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Etkinlikler fr = new Etkinlikler();
            fr.Show();
        }
    }
}
