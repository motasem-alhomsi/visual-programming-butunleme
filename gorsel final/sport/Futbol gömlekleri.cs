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
    public partial class Futbol_gömlekleri : Form
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
        public Futbol_gömlekleri()
        {
            InitializeComponent();
            image1 = Image.FromFile(@"..\..\imgs\1_org.jpg");
            image2 = Image.FromFile(@"..\..\imgs\77.jpg");
            image3 = Image.FromFile(@"..\..\imgs\r1.jpeg");
            image4 = Image.FromFile(@"..\..\imgs\9890019180594.jpg");
            image5 = Image.FromFile(@"..\..\imgs\ch.jpg");
            image6 = Image.FromFile(@"..\..\imgs\ms.jpg");
            image7 = Image.FromFile(@"..\..\imgs\lbas10.png");
            image8 = Image.FromFile(@"..\..\imgs\m1.jpeg");
            image9 = Image.FromFile(@"..\..\imgs\lbas14.png");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
         
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            
        }

        private void Futbol_gömlekleri_Load(object sender, EventArgs e)
        {

        }

        private void img1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image1);
            frm2.lab1 = label4.Text;
            frm2.lab2 = label1.Text;
            frm2.Show();
        }

        private void img2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image2);
            frm2.lab1 = label2.Text;
            frm2.lab2 = label3.Text;
            frm2.Show();
        }

        private void img3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image3);
            frm2.lab1 = label6.Text;
            frm2.lab2 = label5.Text;
            frm2.Show();
        }

        private void img4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image4);
            frm2.lab1 = label8.Text;
            frm2.lab2 = label7.Text;
            frm2.Show();
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
            frm2.lab1 = label12.Text;
            frm2.lab2 = label11.Text;
            frm2.Show();
        }

        private void img7_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image7);
            frm2.lab1 = label14.Text;
            frm2.lab2 = label13.Text;
            frm2.Show();
        }

        private void img8_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image8);
            frm2.lab1 = label16.Text;
            frm2.lab2 = label15.Text;
            frm2.Show();
        }

        private void img9_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(image9);
            frm2.lab1 = label17.Text;
            frm2.lab2 = label18.Text;
            frm2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
