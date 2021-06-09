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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=Kast Ajansı;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader read;

        private void button1_Click(object sender, EventArgs e)
        {

           /* string user = txtUser.Text;
            string pass = txtPass.Text;
            //con = new SqlConnection("server=DESKTOP-JU1LJ2M\\SQLEXPRESS; Initial Catalog=dbLogin;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kayıt where kullanıcı_adı='" + txtUser.Text + "' AND parola='" + txtPass.Text + "'";
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();


           // string kullanıcı_adı = this.txtUser.Text;
           // string parola = this.txtPass.Text;
            //Kullanıcı_Formu k = new Kullanıcı_Formu();
            //k.giris_yap(kullanıcı_adı, parola, this);
            
            Kullanıcı_Ekle kn = new Kullanıcı_Ekle();
            kn.ShowDialog();*/
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            hatırlama();
            string user = txtUser.Text;
            string pass = txtPass.Text;
            //con = new SqlConnection("server=DESKTOP-JU1LJ2M\\SQLEXPRESS; Initial Catalog=dbLogin;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kayıt where kullanıcı_adı='" + txtUser.Text + "' AND parola='" + txtPass.Text + "'";
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                //MessageBox.Show("Giris başarılı.");
                Kullanıcı_Ekle kn = new Kullanıcı_Ekle();
                kn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                txtPass.Clear();
                txtUser.Clear();
            }
            con.Close();


            /* string kullanıcı_adı = this.txtUser.Text;
             string parola = this.txtPass.Text;
             Kullanıcı_Formu k = new Kullanıcı_Formu();
             k.giris_yap(kullanıcı_adı, parola, this);*/

           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUser.Text = Properties.Settings.Default["kuladi"].ToString();
            txtPass.Text = Properties.Settings.Default["şifre"].ToString();
        }
        public void hatırlama()
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default["kuladi"] = txtUser.Text;
                Properties.Settings.Default["şifre"] = txtPass.Text;
            }
            else
            {
                Properties.Settings.Default["kuladi"] = "";
                Properties.Settings.Default["şifre"] = "";
            }
            Properties.Settings.Default.Save();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
