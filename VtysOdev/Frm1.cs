using Npgsql;
using System.Data;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace VtysOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbProje;user ID=postgres;password=12345");

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Listelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from yolcular";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from yolcular where yolcutc=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TctextBox.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yolcu Silme i�lemi ba�ar�l� �ekilde ger�ekle�ti",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);


        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into yolcular" +
                "(yolcutc,isim,soyisim,otob�s,koltuk) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(TctextBox.Text));
            komut1.Parameters.AddWithValue("@p2", �simtextBox.Text);
            komut1.Parameters.AddWithValue("@p3", Soy�simtextBox.Text);
            komut1.Parameters.AddWithValue("@p4", int.Parse(Otob�stextBox.Text));
            komut1.Parameters.AddWithValue("@p5", int.Parse(KoltuktextBox.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yolcu ekleme i�lemi ba�ar�l� bir �ekilde ger�ekle�ti");

        }

        private void G�ncellebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update yolcular set otob�s=@p1,koltuk=@p2 where yolcutc=@p3", baglanti);
            komut3.Parameters.AddWithValue("@p1",int.Parse(Otob�stextBox.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(KoltuktextBox.Text));
            komut3.Parameters.AddWithValue("@p3", int.Parse(TctextBox.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Yolcu g�ncelleme i�lemi ba�ar�l� bir �ekilde ger�ekle�ti","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            baglanti.Close() ;


        }

        private void Arabtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from yolcular where yolcutc = " + int.Parse(TctextBox.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}