using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sport
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult ext = MessageBox.Show("emin misiniz?", "çıkmak mı istiyorsunuz?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information );
            if (ext == DialogResult.OK)
                this.Close();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            futbol fut = new futbol();
            fut.ShowDialog();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Futbol_gömlekleri gor = new Futbol_gömlekleri();
            gor.ShowDialog();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Futbol_Takımı_Kıyafetleri tak = new Futbol_Takımı_Kıyafetleri();
            tak.ShowDialog();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            Basketbol bas = new Basketbol();
            bas.ShowDialog();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Basketbol_Kıyafetleri kiy = new Basketbol_Kıyafetleri();
            kiy.ShowDialog();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Buz_Hokeyi hok = new Buz_Hokeyi();
            hok.ShowDialog();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            Vücut_Geliştirme gel = new Vücut_Geliştirme();
            gel.ShowDialog();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            çeşitli_spor_malzemeleri mal = new çeşitli_spor_malzemeleri();
            mal.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            admin adm = new admin();
            adm.ShowDialog();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            admin adm = new admin();
            adm.ShowDialog();
        }
    }
}
