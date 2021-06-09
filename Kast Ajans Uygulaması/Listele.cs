using System;
using System.Collections;
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
    public partial class Oyuncu_İşlemleri : Form
    {
        public Oyuncu_İşlemleri()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=Kast Ajansı;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Listele_Load(object sender, EventArgs e)
        {
            listele2();
        }
        public void listele2()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader oku;
            comboBox1.Items.Clear();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select isim,soyisim from kisi_kayıt";
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0]);
            }
            con.Close();
        }
        public void listele()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from kisi_kayıt";
            cmd.Connection = con;

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable tablo = new DataTable();
            adap.Fill(tablo);

            dataGridView1.DataSource = tablo;
            con.Close();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from kisi_kayıt where isim like '%" + comboBox1.Text + "%'", con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            dataGridView1.Columns.Clear();
            listele2();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete  from kisi_kayıt where isim=@isim", con);
            cmd.Parameters.AddWithValue("@isim", comboBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt silinmiştir.");
            listele();
            listele2();
            comboBox1.Text = "";
        }
        DataTable yenile()
        {
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kisi_kayıt", con);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            con.Close();
            return tablo;
        }
        private void simpleButton7_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = yenile();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
     
            string id,cinsiyet, isim, soyisim, dogum_t, dogum_y, meslek, boy, kilo, göz_r, sac_r, hakkında, cep_tel, is_tel, ev_tel, adres, e_mail, face, insta, twitt, photo;
            id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            cinsiyet = dataGridView1.CurrentRow.Cells["cinsiyet"].Value.ToString();
            isim = dataGridView1.CurrentRow.Cells["isim"].Value.ToString();
            soyisim = dataGridView1.CurrentRow.Cells["soyisim"].Value.ToString();
            dogum_t = dataGridView1.CurrentRow.Cells["dogum_t"].Value.ToString();
            dogum_y = dataGridView1.CurrentRow.Cells["dogum_y"].Value.ToString();
            meslek = dataGridView1.CurrentRow.Cells["meslek"].Value.ToString();
            boy = dataGridView1.CurrentRow.Cells["boy"].Value.ToString();
            kilo = dataGridView1.CurrentRow.Cells["kilo"].Value.ToString();
            göz_r = dataGridView1.CurrentRow.Cells["göz_r"].Value.ToString();
            sac_r = dataGridView1.CurrentRow.Cells["sac_r"].Value.ToString();
            hakkında = dataGridView1.CurrentRow.Cells["hakkında"].Value.ToString();
            cep_tel = dataGridView1.CurrentRow.Cells["cep_tel"].Value.ToString();
            is_tel = dataGridView1.CurrentRow.Cells["is_tel"].Value.ToString();
            ev_tel = dataGridView1.CurrentRow.Cells["ev_tel"].Value.ToString();
            adres = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            e_mail = dataGridView1.CurrentRow.Cells["e_mail"].Value.ToString();
            face = dataGridView1.CurrentRow.Cells["face"].Value.ToString();
            insta = dataGridView1.CurrentRow.Cells["insta"].Value.ToString();
            twitt = dataGridView1.CurrentRow.Cells["twitt"].Value.ToString();
            photo = dataGridView1.CurrentRow.Cells["photo"].Value.ToString();
            con.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = ("kisi_kayit2");
            command.Connection = (con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@id", id);
            command.Parameters.Add("@cinsiyet", cinsiyet);
            command.Parameters.Add("@isim", isim);
            command.Parameters.Add("@soyisim", soyisim);
            command.Parameters.Add("@dogum_t", dogum_t);
            command.Parameters.Add("@dogum_y", dogum_y);
            command.Parameters.Add("@meslek", meslek);
            command.Parameters.Add("@boy", boy);
            command.Parameters.Add("@kilo", kilo);
            command.Parameters.Add("@göz_r", göz_r);
            command.Parameters.Add("@sac_r", sac_r);
            command.Parameters.Add("@hakkında", hakkında);
            command.Parameters.Add("@cep_tel", cep_tel);
            command.Parameters.Add("@is_tel", is_tel);
            command.Parameters.Add("@ev_tel",ev_tel);
            command.Parameters.Add("@adres", adres);
            command.Parameters.Add("@e_mail", e_mail);
            command.Parameters.Add("@face", face);
            command.Parameters.Add("@insta", insta);
            command.Parameters.Add("@twitt", twitt);
            command.Parameters.Add("@photo", photo);
            command.ExecuteNonQuery();
            con.Close();
            dataGridView1.DataSource = yenile();
            MessageBox.Show("işlem başarılı");

           
            
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            /*PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = printDocument1;
            onizleme.ShowDialog();*/
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            //Listele.ActiveForm.Hide();
            Kullanıcı_Ekle kl = new Kullanıcı_Ekle();
            this.Hide();
            kl.ShowDialog();
        }
    }
}
