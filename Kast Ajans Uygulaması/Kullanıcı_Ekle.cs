using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kast_Ajansı_SON_
{
    public partial class Kullanıcı_Ekle : Form
    {
        public Kullanıcı_Ekle()
        {
            InitializeComponent();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oyuncu_ekle_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            this.Hide();
            fr2.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            proje_kayıt pr = new proje_kayıt();
            this.Hide();
            pr.ShowDialog();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            Hakkımızda hk = new Hakkımızda();
            this.Hide();
            hk.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Proje_İşlemleri oy = new Proje_İşlemleri();
            this.Hide();
            oy.ShowDialog();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            VCard3 vc = new VCard3();
            this.Hide();
            vc.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ayarlar ay = new ayarlar();
            this.Hide();
            ay.ShowDialog();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            Oyuncu_İşlemleri ls = new Oyuncu_İşlemleri();
            this.Hide();
            ls.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Proje_İşlemleri oy = new Proje_İşlemleri();
            this.Hide();
            oy.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            Takvim tk = new Takvim();
            tk.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
