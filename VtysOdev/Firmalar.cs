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
    public partial class Firmalar : Form
    {
        public Firmalar()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbProje;user ID=postgres;password=12345");

        private void Listelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from firmalar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into firmalar" +
                "(firmaid,firmaisim) values (@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(IdtextBox.Text));
            komut1.Parameters.AddWithValue("@p2", (İsimtextBox.Text));


            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Firma ekleme işlemi başarılı bir şekilde gerçekleşti");
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from firmalar where firmaid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(IdtextBox.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Firma Silme işlemi başarılı şekilde gerçekleşti",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Güncellebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update firmalar set  firmaisim=@p1 where firmaid=@p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", (İsimtextBox.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(IdtextBox.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Firma güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }

        private void Arabtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from firmalar where firmaid = " + int.Parse(IdtextBox.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
