using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarRentalApp
{
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();
        }
        //Connect to vehicle database
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\ved\\CarRentalApp\\CarDataBase.mdf;Integrated Security=True;Connect Timeout=30");

        //Add new vehicle data
        private void ADD_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Vehicle values(@ReNum,@Model,@Type,@Milege)", Con);
            cmd.Parameters.AddWithValue("@ReNum", regNum.Text);
            cmd.Parameters.AddWithValue("@Model", Model.Text);
            cmd.Parameters.AddWithValue("@Type", Type.Text);
            cmd.Parameters.AddWithValue("@Milege", int.Parse(milege.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Vehicle Sucessfully added");
            Con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Navigate to Home window
        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        //Show all vehicle data
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Vehicle", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CarView.DataSource = dt;
            Con.Close();
        }

        //Delete vehicle data
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Delete Vehicle where ReNum=@ReNum ", Con);
            cmd.Parameters.AddWithValue("@ReNum", regNum.Text);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Deleted Successfully");
        }
    }
}
