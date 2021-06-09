using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kast_Ajansı_SON_
{
    public partial class Takvim : Form
    {
        public Takvim()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=Kast Ajansı;Integrated Security=True");
        private void Takvim_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader oku;
            comboBox1.Items.Clear();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select isim,soyisim from kisi_kayıt";

            //cmd.CommandText = "select isimsoyisim from kisi_kayıt";
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0]);
               // comboBox1.Items.Add(oku["soyisim"]);
            }
            con.Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Kullanıcı_Ekle kl = new Kullanıcı_Ekle();
            this.Hide();
            kl.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO randevu_kayıt2 (randevu_sahibi,randevu_tarihi,randevu_yeri,randevu_konusu) VALUES " +
              "(@randevu_sahibi,@randevu_tarihi,@randevu_yeri,@randevu_konusu)", con);

            cmd.Parameters.AddWithValue("@randevu_sahibi", comboBox1.Text);
            cmd.Parameters.AddWithValue("@randevu_tarihi", textBox4.Text);
            //cmd.Parameters.AddWithValue("@randevu_tarihi", Convert.ToDateTime(dateTimePicker1.Text));
            cmd.Parameters.AddWithValue("@randevu_yeri", textBox2.Text);
            cmd.Parameters.AddWithValue("@randevu_konusu", textBox1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.DataSource = yenile();
            MessageBox.Show("Randevu Kaydedilmiştir.");
     
        }
        DataTable yenile()
        {
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from randevu_kayıt2", con);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            con.Close();
            return tablo;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = yenile();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from randevu_kayıt2 where randevu_sahibi=@randevu_sahibi", con);
            cmd.Parameters.AddWithValue("@randevu_sahibi", comboBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.DataSource = yenile();
            MessageBox.Show("Kayıt silinmiştir.");
 
        }
       
        private void simpleButton4_Click(object sender, EventArgs e)
        {
              string id, randevu_sahibi, randevu_tarihi, randevu_yeri, randevu_konusu;
             // randevu_tarihi =Convert.ToDateTime();
              id = dataGridView1.CurrentRow.Cells["id"].Value.ToString(); 
              randevu_sahibi = dataGridView1.CurrentRow.Cells["randevu_sahibi"].Value.ToString();
             //  randevu_tarihi=dataGridView1.CurrentRow.Cells("@randevu_tarihi", Convert.ToDateTime(dateTimePicker1.Text));
              randevu_tarihi = dataGridView1.CurrentRow.Cells["randevu_tarihi"].Value.ToString();
              randevu_yeri = dataGridView1.CurrentRow.Cells["randevu_yeri"].Value.ToString();
              randevu_konusu = dataGridView1.CurrentRow.Cells["randevu_konusu"].Value.ToString();

              con.Open();
              SqlCommand cmd = new SqlCommand("update randevu_kayıt2 set randevu_sahibi='" + randevu_sahibi + 
                  "',randevu_tarihi='" + randevu_tarihi + 
                  "',randevu_yeri='" + randevu_yeri + 
                  "',randevu_konusu='" + randevu_konusu + 
                  "'where id='" + id + "'", con);
              cmd.ExecuteNonQuery();
              con.Close();
              dataGridView1.DataSource = yenile();
              MessageBox.Show("işlem başarılı");

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            comboBox1.DataSource = null;
        }
    }
}
