using Npgsql;
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
    public partial class Muavinmaas : Form
    {
        public Muavinmaas()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbProje;user ID=postgres;password=12345");

        private void Tclbl_Click(object sender, EventArgs e)
        {

        }

        private void Listelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from muavin_maas";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into muavin_maas" +
                "(muavin,maaş) values (@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(TctextBox.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(İsimtextBox.Text));

            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Muavin maaş ekleme işlemi başarılı bir şekilde gerçekleşti");
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from muavin_maas where muavin=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TctextBox.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Muavin_Maaş Silme işlemi başarılı şekilde gerçekleşti",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Güncellebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update muavin_maas set  maaş=@p1 where muavin=@p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(İsimtextBox.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(TctextBox.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Muavin maaş güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();

        }

        private void Arabtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from muavin_maas where muavin = " + int.Parse(TctextBox.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void İsimtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void isimlabel_Click(object sender, EventArgs e)
        {

        }

        private void TctextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
