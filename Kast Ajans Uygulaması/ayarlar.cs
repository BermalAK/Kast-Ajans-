using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kast_Ajansı_SON_
{
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=Kast Ajansı;Integrated Security=True");


        private void temizle()
        {
            foreach (Control nesne in this.Controls)
            {
                if (nesne is TextBox)
                {
                    TextBox textbox = (TextBox)nesne;
                    textbox.Clear();
                }
            }
        }
        private void veriler()
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from kayıt", con);
            SqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["id"].ToString();
                ekle.SubItems.Add(read["kullanıcı_adı"].ToString());
                ekle.SubItems.Add(read["parola"].ToString());
                listView1.Items.Add(ekle);
            }
            con.Close();
        }
        int id = 1;
        private void simpleButton2_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("Update kayıt Set parola=@parola Where kullanıcı_adı='" + kullanıcı_adı.Text + "'",con);
            cmd.Parameters.AddWithValue("@parola", parola.Text);
            // SqlCommand cmd = new SqlCommand("update kayıt set kullanıcı_adı='" + kullanıcı_adı.Text + "',parola='" + parola.Text + "',where id='" + id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            veriler();

            /*SqlCommand cmd;
            con.Open();
            cmd = new SqlCommand("update kayıt set kullanıcı_adı='" + kullanıcı_adı.Text.ToString() + "',parola='" + parola.Text.ToString() + "',where id='" + id + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("güncellendi.");
            con.Close();*/


        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;

        }

        private void ayarlar_Load(object sender, EventArgs e)
        {
            veriler();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //ayarlar.ActiveForm.Hide();
            Kullanıcı_Ekle kl = new Kullanıcı_Ekle();
            this.Hide();
            kl.ShowDialog();
        }
    }
}
