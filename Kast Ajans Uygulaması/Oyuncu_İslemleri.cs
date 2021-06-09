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
    public partial class Proje_İşlemleri : Form
    {
        public Proje_İşlemleri()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=Kast Ajansı;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void listele()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from proje_kayıt2";
            cmd.Connection = con;

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable tablo = new DataTable();
            adap.Fill(tablo);

            dataGridView1.DataSource = tablo;
            con.Close();
        }
        public void listele2()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader oku;
            comboBox1.Items.Clear();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select proje_ismi from proje_kayıt2";
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0]);
            }
            con.Close();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            //Oyuncu_İslemleri.ActiveForm.Hide();
            Kullanıcı_Ekle kl = new Kullanıcı_Ekle();
            this.Hide();
            kl.ShowDialog();
        }
       
        private void Oyuncu_İslemleri_Load(object sender, EventArgs e)
        {
            listele2();

           /* SqlCommand cmd = new SqlCommand();
            SqlDataReader oku;
            comboBox1.Items.Clear();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select proje_ismi from proje_kayıt2";
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0]);
            }
            con.Close();*/

           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            dataGridView1.Columns.Clear();
            listele2();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            // listele();
            dataGridView1.DataSource = yenile();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from proje_kayıt2 where proje_ismi=@proje_ismi", con);
            cmd.Parameters.AddWithValue("@proje_ismi", comboBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt silinmiştir.");
            listele();
            listele2();
            comboBox1.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from proje_kayıt2 where proje_ismi like '%" + comboBox1.Text + "%'", con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            PrintDialog yazdir = new PrintDialog();
            yazdir.Document = printDocument1;
            yazdir.UseEXDialog = true;
            if (yazdir.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        DataTable yenile()
        {
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from proje_kayıt2", con);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            con.Close();
            return tablo;
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string id, proje_ismi, resim, kadın_basrol, erkek_basrol, oyuncu_bir, oyuncu_iki, oyuncu_üc, oyuncu_dört, konu, senarist, yönetmen, yapımcı, maliyet, ülke, şehir, baslama_t, bitis_t;
            id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            proje_ismi = dataGridView1.CurrentRow.Cells["proje_ismi"].Value.ToString();
            resim = dataGridView1.CurrentRow.Cells["resim"].Value.ToString();
            kadın_basrol = dataGridView1.CurrentRow.Cells["kadın_basrol"].Value.ToString();
            erkek_basrol = dataGridView1.CurrentRow.Cells["erkek_basrol"].Value.ToString();
            oyuncu_bir= dataGridView1.CurrentRow.Cells["oyuncu_bir"].Value.ToString();
            oyuncu_iki = dataGridView1.CurrentRow.Cells["oyuncu_iki"].Value.ToString();
            oyuncu_üc = dataGridView1.CurrentRow.Cells["oyuncu_üc"].Value.ToString();
            oyuncu_dört = dataGridView1.CurrentRow.Cells["oyuncu_dört"].Value.ToString();
            konu = dataGridView1.CurrentRow.Cells["konu"].Value.ToString();
            senarist = dataGridView1.CurrentRow.Cells["senarist"].Value.ToString();
            yönetmen = dataGridView1.CurrentRow.Cells["yönetmen"].Value.ToString();
            yapımcı = dataGridView1.CurrentRow.Cells["yapımcı"].Value.ToString();
            maliyet = dataGridView1.CurrentRow.Cells["maliyet"].Value.ToString();
            ülke = dataGridView1.CurrentRow.Cells["ülke"].Value.ToString();
            şehir = dataGridView1.CurrentRow.Cells["şehir"].Value.ToString();
            baslama_t = dataGridView1.CurrentRow.Cells["baslama_t"].Value.ToString();
            bitis_t = dataGridView1.CurrentRow.Cells["bitis_t"].Value.ToString();
            con.Open();
            SqlCommand command = new SqlCommand();
                command.CommandText = ("proje_kayitt2");
                command.Connection = (con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", id);
                command.Parameters.Add("@proje_ismi", proje_ismi);
                command.Parameters.Add("@resim", resim);
                command.Parameters.Add("@kadın_basrol", kadın_basrol);
                command.Parameters.Add("@erkek_basrol", erkek_basrol);
                command.Parameters.Add("@oyuncu_bir", oyuncu_bir);
                command.Parameters.Add("@oyuncu_iki", oyuncu_iki);
                command.Parameters.Add("@oyuncu_uc", oyuncu_üc);
                command.Parameters.Add("@oyuncu_dort", oyuncu_dört);
                command.Parameters.Add("@konu", konu);
                command.Parameters.Add("@senarist", senarist);
                command.Parameters.Add("@yönetmen", yönetmen);
                command.Parameters.Add("@yapımcı", yapımcı);
                command.Parameters.Add("@maliyet", maliyet);
                command.Parameters.Add("@ülke", ülke);
                command.Parameters.Add("@şehir", şehir);
                command.Parameters.Add("@baslama_t", baslama_t);
                command.Parameters.Add("@bitis_t", bitis_t);
                command.ExecuteNonQuery();
              con.Close();
              dataGridView1.DataSource = yenile();
              MessageBox.Show("işlem basarılı");
        }
    }
}
