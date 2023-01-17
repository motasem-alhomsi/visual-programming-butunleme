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
using System.IO;
namespace sport
{
    public partial class hesabim : Form
    {
        public hesabim()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("Server=localhost;database=gorsal;port=3306;username=root;password=");
        MySqlDataAdapter ad = new MySqlDataAdapter();
        MySqlDataAdapter add = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtt = new DataTable();
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

        private void hesabim_Load(object sender, EventArgs e)
        {
             
                ad =new MySqlDataAdapter( "SELECT * FROM bilgi",con);
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.DataSource = dt;
            MySqlCommand cmmm = new MySqlCommand("SELECT * FROM `sati` WHERE 1", con );
            DataTable tbl = new DataTable();
            con.Open();
            tbl.Load(cmmm.ExecuteReader());
            con.Close();
            dataGridView2.DataSource = tbl;
           
           
        }
        public DataTable LoadTableFromDatabase()
        {
            con.Open();
            DataTable dt = new DataTable();
            string query = "Select * From bilgi";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoy.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtemai.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE bilgi SET id=@id, adi=@adi, soyadi=@soyadi, email=@email, telefone=@telefone where id=" + dataGridView1.CurrentRow.Cells[0].Value + "";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", txtid.Text);
                cmd.Parameters.AddWithValue("@adi", txtadi.Text);
                cmd.Parameters.AddWithValue("@soyadi", txtsoy.Text);
                cmd.Parameters.AddWithValue("@email", txtemai.Text);
                cmd.Parameters.AddWithValue("@telefone", txttel.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = dt;
                con.Close();
                MessageBox.Show("bilgiler değiştirildi");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message");
            }
        }

        private void butsil_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM bilgi WHERE id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = dt;
                con.Close();
                MessageBox.Show("silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message");
            }
        }

        private void butAra_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            string query = "Select * From bilgi WHERE adi LIKE '%"+txtara.Text+"%' ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void picimg_Click(object sender, EventArgs e)
        {
            
           

        }
    }
}
