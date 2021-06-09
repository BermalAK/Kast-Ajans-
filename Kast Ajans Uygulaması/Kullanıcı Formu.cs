using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kast_Ajansı_SON_
{
    class Kullanıcı_Formu
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TLB8Q2AL;Initial Catalog=Kast Ajansı;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader read;

        public void giris_yap(string ad, string parola, Form frm1)
        {

           /* cmd = new SqlCommand("select * from kayıt where kullanıcı_adı='" + ad + "'and parola='" + parola + "'", con);
            con.Open();
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                MessageBox.Show("Giris Basarılı.");
                // Anasayfa_Formu ana_s = new Anasayfa_Formu();
                //ana_s.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatali Giris!..", "Error");
            }
            con.Close();
         //   cmd.Dispose();*/
        }

       /* private void temizle()
        {
            foreach (Control nesne in this.Controls)
            {
                if (nesne is TextBox)
                {
                    TextBox textbox = (TextBox)nesne;
                    textbox.Clear();
                }
            }
        }*/

    }
}
