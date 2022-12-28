using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VtysOdev
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void otobüslerbtn_Click(object sender, EventArgs e)
        {
            Otobüsler otobüsler=new Otobüsler();
            otobüsler.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Firmalar firmalar = new Firmalar();
            firmalar.ShowDialog();
        }

        private void şoförlerbtn_Click(object sender, EventArgs e)
        {
            Şoförler şoförler = new Şoförler();
            şoförler.ShowDialog();
        }

        private void muavinbtn_Click(object sender, EventArgs e)
        {
             Muavinler muavinler = new Muavinler();
             muavinler.ShowDialog();
        }

        private void muavinmaas_Click(object sender, EventArgs e)
        {
            Muavinmaas m = new Muavinmaas();
            m.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 y= new Form1();
            y.ShowDialog();
        }

        private void yolcuinis_Click(object sender, EventArgs e)
        {
            Yolcuinis y = new Yolcuinis();
            y.ShowDialog();
        }

        private void koltuklar_Click(object sender, EventArgs e)
        {
            Koltuklar y = new Koltuklar();
            y.ShowDialog();
        }
    }
}
