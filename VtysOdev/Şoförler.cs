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
    public partial class Şoförler : Form
    {
        public Şoförler()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbProje;user ID=postgres;password=12345");

        private void Listelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from şoförler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into şoförler" +
                "(şoförtc,isim,soyisim) values (@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(TctextBox.Text));
            komut1.Parameters.AddWithValue("@p2", İsimtextBox.Text);
            komut1.Parameters.AddWithValue("@p3", SoyİsimtextBox.Text);
           
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şoför ekleme işlemi başarılı bir şekilde gerçekleşti");
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from şoförler where şoförtc=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TctextBox.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şoför Silme işlemi başarılı şekilde gerçekleşti",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void Güncellebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update şoförler set  isim=@p1,soyisim=@p2 where şoförtc=@p3", baglanti);
            komut3.Parameters.AddWithValue("@p1", (İsimtextBox.Text));
            komut3.Parameters.AddWithValue("@p2", (SoyİsimtextBox.Text));
            komut3.Parameters.AddWithValue("@p3", int.Parse(TctextBox.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Şoför güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();

        }

        private void Arabtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from şoförler where şoförtc = " + int.Parse(TctextBox.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Tclbl_Click(object sender, EventArgs e)
        {

        }

        private void SoyİsimtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void soyisimlabel_Click(object sender, EventArgs e)
        {

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
