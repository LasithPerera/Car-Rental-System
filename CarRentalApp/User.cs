using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace CarRentalApp
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\ved\\CarRentalApp\\CarDataBase.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            if (UserID.Text == "" || UserN.Text == "" || UserPass.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into userT values(@userID,@userName,@userPassword)", Con);
                    cmd.Parameters.AddWithValue("@userID", UserID.Text);
                    cmd.Parameters.AddWithValue("@userName", UserN.Text);
                    cmd.Parameters.AddWithValue("@userPassword", UserPass.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Sucessfully added");
                    Con.Close();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void searchbtt_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd2 = new SqlCommand("Select userID,userName from userT", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Delete userT where UserID=@userID ", Con);
            cmd.Parameters.AddWithValue("@userID", UserID.Text);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Deleted Successfully");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
