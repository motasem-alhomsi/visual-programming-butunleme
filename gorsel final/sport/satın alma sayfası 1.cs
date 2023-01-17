using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sport
{
    public partial class satın_alma_sayfası_1 : Form
    {
        public string lab3 { get; set; }
        public string lab4 { get; set; }

        public satın_alma_sayfası_1(Image image , int adat , string size , string adi , string lab)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            label12.Text = adat.ToString();
            label13.Text = size;
       


        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=gorsal;port=3306;username=root;password=");

        private void satın_alma_sayfası_1_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(20, 192, 192, 192);
            groupBox2.BackColor = Color.FromArgb(20, 192, 192, 192);
            groupBox2.BackColor = Color.FromArgb(20, 192, 192, 192);
            label15.Text = lab3;
            label16.Text = lab4;

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
             textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("Hata! Lütfen tüm bilgileri doldurunuz");
            }
            else
            {
                string str = "INSERT INTO bilgi values(@id,@adi,@soyadi,@email,@telefone)";
                MySqlCommand cmd = new MySqlCommand(str,con);
                cmd.Parameters.AddWithValue("@id",textBox11.Text);
                cmd.Parameters.AddWithValue("@adi", textBox1.Text);
                cmd.Parameters.AddWithValue("@soyadi", textBox2.Text);
                cmd.Parameters.AddWithValue("@email", textBox3.Text);
                cmd.Parameters.AddWithValue("@telefone", textBox10.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                string st = "INSERT INTO odeme values(@id,@kartno,@ay,@cvv,@kartname)";
                MySqlCommand cmdd = new MySqlCommand(st, con);
                cmdd.Parameters.AddWithValue("@id", textBox12.Text);
                cmdd.Parameters.AddWithValue("@kartno", textBox8.Text);
                cmdd.Parameters.AddWithValue("@ay", textBox7.Text);
                cmdd.Parameters.AddWithValue("@cvv", textBox5.Text);
                cmdd.Parameters.AddWithValue("@kartname", textBox6.Text);
   
                con.Open();
                cmdd.ExecuteNonQuery();
                con.Close();

                string stt = "INSERT INTO sati values(@id,@adi,@fiyat,@Boy,@Sayi,@adres,@nots,@img)";
                MySqlCommand cmddd = new MySqlCommand(stt, con);
                cmddd.Parameters.AddWithValue("@id", textBox13.Text);
                cmddd.Parameters.AddWithValue("@adi", label15.Text);
                cmddd.Parameters.AddWithValue("@fiyat", label16.Text);
                cmddd.Parameters.AddWithValue("@Boy", label13.Text);
                cmddd.Parameters.AddWithValue("@Sayi", label12.Text);
                cmddd.Parameters.AddWithValue("@adres", textBox4);
                cmddd.Parameters.AddWithValue("@nots", textBox9.Text);
                cmddd.Parameters.AddWithValue("@img", satın_alma_sayfası_1.ActiveForm);

                con.Open();
                cmddd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Red;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Black;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
