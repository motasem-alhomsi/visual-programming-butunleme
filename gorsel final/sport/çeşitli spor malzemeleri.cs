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
    public partial class çeşitli_spor_malzemeleri : Form
    {
        Image image1;
        Image image2;
        Image image3;
        Image image4;
        Image image5;
        Image image6;
        Image image7;
        Image image8;
        Image image9;
        public çeşitli_spor_malzemeleri()
        {
            InitializeComponent();
            image1 = Image.FromFile(@"..\..\imgs\elbise\j14 copy.png");
            image2 = Image.FromFile(@"..\..\imgs\elbise\j19.jpg");
            image3 = Image.FromFile(@"..\..\imgs\elbise\j17.jpg");
            image4 = Image.FromFile(@"..\..\imgs\elbise\j5.jpg");
            image5 = Image.FromFile(@"..\..\imgs\elbise\j6.jpg");
            image6 = Image.FromFile(@"..\..\imgs\elbise\l7.jpg");
            image7 = Image.FromFile(@"..\..\imgs\elbise\j12.jpg");
            image8 = Image.FromFile(@"..\..\imgs\elbise\j10.jpg");
            image9 = Image.FromFile(@"..\..\imgs\elbise\j11.jpg");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image4);
            frm4.lab1 = label12.Text;
            frm4.lab2 = label11.Text;
            frm4.Show();
        }

        private void çeşitli_spor_malzemeleri_Load(object sender, EventArgs e)
        {

        }

        private void img1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image1);
            frm4.lab1 = label1.Text;
            frm4.lab2 = label2.Text;
            frm4.Show();
        }

        private void img2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image2);
            frm4.lab1 = label4.Text;
            frm4.lab2 = label3.Text;
            frm4.Show();
        }

        private void img3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image3);
            frm4.lab1 = label6.Text;
            frm4.lab2 = label5.Text;
            frm4.Show();
        }

        private void img5_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image5);
            frm4.lab1 = label10.Text;
            frm4.lab2 = label9.Text;
            frm4.Show();
        }

        private void img6_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image6);
            frm4.lab1 = label8.Text;
            frm4.lab2 = label7.Text;
            frm4.Show();
        }

        private void img7_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image7);
            frm4.lab1 = label18.Text;
            frm4.lab2 = label17.Text;
            frm4.Show();
        }

        private void img8_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(image8);
            frm3.lab1 = label16.Text;
            frm3.lab2 = label15.Text;
            frm3.Show();
        }

        private void img9_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(image9);
            frm3.lab1 = label14.Text;
            frm3.lab2 = label13.Text;
            frm3.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label19_MouseHover(object sender, EventArgs e)
        {
            label19.ForeColor = Color.Red;
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            label19.ForeColor = Color.Black;
        }
    }
}
