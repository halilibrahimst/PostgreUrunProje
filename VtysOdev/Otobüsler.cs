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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VtysOdev
{
    public partial class Otobüsler : Form
    {
        public Otobüsler()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbProje;user ID=postgres;password=12345");

        private void Otobüsler_Load(object sender, EventArgs e)
        {

        }

        private void Listelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from otobüsler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into otobüsler" +
                "(otobüsid,firma) values (@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(IdtextBox.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(İsimtextBox.Text));
    

            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Otobüs ekleme işlemi başarılı bir şekilde gerçekleşti");
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from otobüsler where otobüsid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(IdtextBox.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Otobüs Silme işlemi başarılı şekilde gerçekleşti",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Güncellebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update otobüsler set  firma=@p1 where otobüsid=@p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(İsimtextBox.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(IdtextBox.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Otobüs güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }

       

        private void Arabtn_Click_1(object sender, EventArgs e)
        {
            string sorgu = "select * from otobüsler where otobüsid = " + int.Parse(IdtextBox.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

       

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("Select * from" +
                " firmaisim", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();




        }
    }
}
