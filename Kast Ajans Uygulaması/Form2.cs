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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=Kast Ajansı;Integrated Security=True");

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
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
            comboBox2.DataSource = null;
            cinsiyet.DataSource = null;
            comboBox3.DataSource = null;
          //  cinsiyet.Items.RemoveAt(cinsiyet.SelectedIndex);
            //comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
            //comboBox3.Items.RemoveAt(comboBox3.SelectedIndex);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO kisi_kayıt (photo,cinsiyet,isim,soyisim,dogum_t,dogum_y,meslek,boy," +
               "kilo,göz_r,sac_r,hakkında,cep_tel,is_tel,ev_tel,adres,e_mail,face,insta,twitt) VALUES " +
               "(@photo,@cinsiyet,@isim,@soyisim,@dogum_t,@dogum_y,@meslek,@boy,@kilo,@göz_r,@sac_r,@hakkında,@cep_tel,@is_tel," +
               "@ev_tel,@adres,@e_mail,@face,@insta,@twitt)", con);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@photo", textBox17.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet.Text);
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.Parameters.AddWithValue("@soyisim", textBox2.Text);
            cmd.Parameters.AddWithValue("@dogum_t", textBox16.Text);
            cmd.Parameters.AddWithValue("@dogum_y", textBox4.Text);
            cmd.Parameters.AddWithValue("@meslek", textBox5.Text);
            cmd.Parameters.AddWithValue("@boy", Convert.ToInt64(textBox6.Text));
            cmd.Parameters.AddWithValue("@kilo", Convert.ToInt64(textBox7.Text));
            cmd.Parameters.AddWithValue("@göz_r", comboBox2.Text);
            cmd.Parameters.AddWithValue("@sac_r", comboBox3.Text);
            cmd.Parameters.AddWithValue("@hakkında", textBox3.Text);
            cmd.Parameters.AddWithValue("@cep_tel", textBox8.Text);
            cmd.Parameters.AddWithValue("@is_tel", textBox9.Text);
            cmd.Parameters.AddWithValue("@ev_tel", textBox10.Text);
            cmd.Parameters.AddWithValue("@adres", textBox11.Text);
            cmd.Parameters.AddWithValue("@e_mail", textBox12.Text);
            cmd.Parameters.AddWithValue("@face", textBox13.Text);
            cmd.Parameters.AddWithValue("@insta", textBox14.Text);
            cmd.Parameters.AddWithValue("@twitt", textBox15.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cinsiyet.Items.Add("Kadın");
            cinsiyet.Items.Add("Erkek");
            comboBox2.Items.Add("Kahve");
            comboBox2.Items.Add("Yeşil");
            comboBox2.Items.Add("Ela");
            comboBox2.Items.Add("Mavi");
            comboBox3.Items.Add("Siyah");
            comboBox3.Items.Add("Kahve");
            comboBox3.Items.Add("Kumral");
            comboBox3.Items.Add("Gri");
            comboBox3.Items.Add("Lacivert");
            comboBox3.Items.Add("Kızıl");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            /*openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox17.Text = openFileDialog1.FileName;*/
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox17.Text = openFileDialog1.FileName;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
           // Form2.ActiveForm.Hide();
            Kullanıcı_Ekle kl = new Kullanıcı_Ekle();
            this.Hide();
            kl.ShowDialog();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
