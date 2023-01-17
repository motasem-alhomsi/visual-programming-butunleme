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
    public partial class Basketbol : Form
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
        public Basketbol()
        {
            InitializeComponent();
            image1 = Image.FromFile(@"..\..\imgs\pasketbol\pas1.jpg");
            image2 = Image.FromFile(@"..\..\imgs\pasketbol\pas2.jpg");
            image3 = Image.FromFile(@"..\..\imgs\pasketbol\shapk4.jpg");
            image4 = Image.FromFile(@"..\..\imgs\pasketbol\shapk3.jpg");
            image5 = Image.FromFile(@"..\..\imgs\pasketbol\short2.png");
            image6 = Image.FromFile(@"..\..\imgs\pasketbol\short1.png");
            image7 = Image.FromFile(@"..\..\imgs\pasketbol\shos4 copy.png");
            image8 = Image.FromFile(@"..\..\imgs\pasketbol\shos2.png");
            image9 = Image.FromFile(@"..\..\imgs\pasketbol\shos1.jpg");
        }

        private void Basketbol_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(image7);
            frm3.lab1 = label13.Text;
            frm3.lab2 = label14.Text;
            frm3.Show();
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
            frm4.lab1 = label3.Text;
            frm4.lab2 = label4.Text;
            frm4.Show();
        }

        private void img3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image3);
            frm4.lab1 = label5.Text;
            frm4.lab2 = label6.Text;
            frm4.Show();
        }

        private void img4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(image4);
            frm4.lab1 = label7.Text;
            frm4.lab2 = label8.Text;
            frm4.Show();
        }

        private void img5_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image5);
            frm2.lab1 = label9.Text;
            frm2.lab2 = label10.Text;
            frm2.Show();
        }

        private void img6_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image6);
            frm2.lab1 = label11.Text;
            frm2.lab2 = label2.Text;
            frm2.Show();
        }

        private void img8_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(image8);
            frm3.lab1 = label15.Text;
            frm3.lab2 = label16.Text;
            frm3.Show();
        }

        private void img9_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(image9);
            frm3.lab1 = label17.Text;
            frm3.lab2 = label18.Text;
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
            label19.ForeColor = Color.Red;
        }
    }
}
