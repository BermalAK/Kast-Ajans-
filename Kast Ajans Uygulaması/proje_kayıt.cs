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
    public partial class proje_kayıt : Form
    {
        public proje_kayıt()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=Kast Ajansı;Integrated Security=True");

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //resim atma kodları
            openFileDialog2.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog2.FileName;
            textBox6.Text = openFileDialog2.FileName;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void cinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void proje_kayıt_Load(object sender, EventArgs e)
        {
            //comboboxta isimlerin görünmesi için
            SqlCommand cmd = new SqlCommand();
            SqlDataReader oku;
            basrol_kadın.Items.Clear();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select isim,soyisim from kisi_kayıt where cinsiyet='Kadın'";
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                basrol_kadın.Items.Add(oku[0]);
            }

            //cmd.CommandText = "select isin,soyisim from kisi_kayıt where cinsiyet='Erkek'";

            con.Close();
            SqlCommand komut = new SqlCommand();
            SqlDataReader dt;
            basrol_erkek.Items.Clear();
            con.Open();
            komut.Connection = con;
            komut.CommandText = "select isim,soyisim from kisi_kayıt where cinsiyet='Erkek'";
            dt = komut.ExecuteReader();
            while (dt.Read())
            {
                basrol_erkek.Items.Add(dt[0]);
            }

            con.Close();

            con.Close();
            SqlCommand oyuncu = new SqlCommand();
            SqlDataReader sdt;
            birinci_oyuncu.Items.Clear();
            con.Open();
            oyuncu.Connection = con;
            oyuncu.CommandText = "select isim,soyisim from kisi_kayıt";
            sdt = oyuncu.ExecuteReader();
            while (sdt.Read())
            {
                birinci_oyuncu.Items.Add(sdt[0]);
            }

            con.Close();

            con.Close();
            SqlCommand comm = new SqlCommand();
            SqlDataReader adt;
            ikinci_oyuncu.Items.Clear();
            con.Open();
            comm.Connection = con;
            comm.CommandText = "select isim,soyisim from kisi_kayıt";
            adt = comm.ExecuteReader();
            while (adt.Read())
            {
                ikinci_oyuncu.Items.Add(adt[0]);
            }

            con.Close();

            con.Close();
            SqlCommand cmdd = new SqlCommand();
            SqlDataReader fdt;
            ücüncü_oyuncu.Items.Clear();
            con.Open();
            cmdd.Connection = con;
            cmdd.CommandText = "select isim,soyisim from kisi_kayıt";
            fdt = cmdd.ExecuteReader();
            while (fdt.Read())
            {
                ücüncü_oyuncu.Items.Add(fdt[0]);
            }

            con.Close();

            con.Close();
            SqlCommand ccmd = new SqlCommand();
            SqlDataReader edt;
            dördüncü_oyuncu.Items.Clear();
            con.Open();
            ccmd.Connection = con;
            ccmd.CommandText = "select isim,soyisim from kisi_kayıt";
            edt = ccmd.ExecuteReader();
            while (edt.Read())
            {
                dördüncü_oyuncu.Items.Add(edt[0]);
            }

            con.Close();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO proje_kayıt2 (proje_ismi,resim,kadın_basrol,erkek_basrol,oyuncu_bir,oyuncu_iki,oyuncu_üc," +
                "oyuncu_dört,konu,senarist,yönetmen,yapımcı,maliyet,ülke,şehir,baslama_t,bitis_t) VALUES " +
               "(@proje_ismi,@resim,@kadın_basrol,@erkek_basrol,@oyuncu_bir,@oyuncu_iki,@oyuncu_üc,@oyuncu_dört,@konu,@senarist," +
               "@yönetmen,@yapımcı,@maliyet,@ülke,@şehir,@baslama_t,@bitis_t)", con);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@resim", textBox6.Text);
            cmd.Parameters.AddWithValue("@kadın_basrol", basrol_kadın.Text);
            cmd.Parameters.AddWithValue("@erkek_basrol", basrol_erkek.Text);
            cmd.Parameters.AddWithValue("@oyuncu_bir", birinci_oyuncu.Text);
            cmd.Parameters.AddWithValue("@oyuncu_iki", ikinci_oyuncu.Text);
            cmd.Parameters.AddWithValue("@oyuncu_üc", ücüncü_oyuncu.Text);
            cmd.Parameters.AddWithValue("@oyuncu_dört", dördüncü_oyuncu.Text);
            cmd.Parameters.AddWithValue("@proje_ismi", textBox9.Text);
            cmd.Parameters.AddWithValue("@maliyet", Convert.ToInt32(textBox17.Text));
            cmd.Parameters.AddWithValue("@senarist", textBox3.Text);
            cmd.Parameters.AddWithValue("@yönetmen", textBox4.Text);
            cmd.Parameters.AddWithValue("@yapımcı", textBox16.Text);
            cmd.Parameters.AddWithValue("@ülke", textBox5.Text);
            cmd.Parameters.AddWithValue("@şehir", textBox7.Text);
            cmd.Parameters.AddWithValue("@baslama_t", textBox2.Text);
            cmd.Parameters.AddWithValue("@bitis_t", textBox1.Text);
            cmd.Parameters.AddWithValue("@konu", textBox8.Text);
          
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //proje_kayıt.ActiveForm.Hide();
            Kullanıcı_Ekle kl = new Kullanıcı_Ekle();
            this.Hide();
            kl.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox9.Clear();
            textBox8.Clear();
            pictureBox1.Image = null;
            basrol_kadın.Text = "";
            basrol_erkek.Text = "";
            birinci_oyuncu.Text = "";
            ikinci_oyuncu.Text = "";
            ücüncü_oyuncu.Text = "";
            dördüncü_oyuncu.Text = "";
        }
    }
}
