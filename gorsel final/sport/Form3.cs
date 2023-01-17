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
    public partial class Form3 : Form
    {
        Image image;
        int adat;
        string size;
        string adi;
        string lab;
        public string lab1 { get; set; }
        public string lab2 { get; set; }
        public Form3(Image image)
        {
            InitializeComponent();
            this.image = image;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label6.Text = lab1;
            label7.Text = lab2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adat = Convert.ToInt32(numericUpDown1.Value);
            size = comboBox1.Text;
            if (numericUpDown1.Value <= 0 || comboBox1.Text == "")
            {
                label10.Text = ("Lütfen bedeni ve numarayı seçin");
            }
            else if (numericUpDown1.Value > 1)
            {
                int fiya = int.Parse(label7.Text);
                int sum = adat * fiya;
                label9.Text = sum.ToString();
                satın_alma_sayfası_1 sat = new satın_alma_sayfası_1(image, adat, size, adi, lab);
                sat.lab3 = label6.Text;
                sat.lab4 = label9.Text;
                sat.Show();

            }
            else
            {
                label9.Text = label7.Text;
                satın_alma_sayfası_1 sat = new satın_alma_sayfası_1(image, adat, size, adi, lab);
                sat.lab3 = label6.Text;
                sat.lab4 = label9.Text;
                sat.Show();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }
    }
}
