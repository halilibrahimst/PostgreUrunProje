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
    public partial class Koltuklar : Form
    {
        public Koltuklar()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbProje;user ID=postgres;password=12345");

        private void Listelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from koltuklar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into koltuklar" +
                "(koltukid,otobüs) values (@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(TctextBox.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(İsimtextBox.Text));

            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Koltuk ekleme işlemi başarılı bir şekilde gerçekleşti");
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from koltuklar where koltukid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TctextBox.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Koltuk Silme işlemi başarılı şekilde gerçekleşti",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Güncellebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update koltuklar set  koltukid=@p1 where otobüs=@p2", baglanti);
            komut3.Parameters.AddWithValue("@p2", int.Parse(İsimtextBox.Text));
            komut3.Parameters.AddWithValue("@p1", int.Parse(TctextBox.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Koltuk güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }

        private void Arabtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from koltuklar where koltukid = " + int.Parse(TctextBox.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
