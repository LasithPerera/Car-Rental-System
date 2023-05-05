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
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\ved\\CarRentalApp\\CarDataBase.mdf;Integrated Security=True;Connect Timeout=30");

        private void Rent_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void add_rent_Click(object sender, EventArgs e)
        
        //Add new Rent data
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Rent values(@CustomerNum,@CustomerName,@VehicleNum, @VehicleType, @Duration, @Cost)", Con);
            cmd.Parameters.AddWithValue("@CustomerNum", CusId.Text);
            cmd.Parameters.AddWithValue("@CustomerName", CusName.Text);
            cmd.Parameters.AddWithValue("@VehicleNum", VehNum.Text);
            cmd.Parameters.AddWithValue("@VehicleType", vehType.Text);
            cmd.Parameters.AddWithValue("@Duration", int.Parse(Duration.Text));
            cmd.Parameters.AddWithValue("@Cost", int.Parse(fee.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Rent Sucessfully added");
            Con.Close();
        }
        //This method used to delete rent customer number when the parameter is equal to con
        private void delete_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Delete Rent where CusId=@CustomerNum ", Con);
            cmd.Parameters.AddWithValue("@CustomerNum", CusId.Text);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Deleted Successfully");
        }
        //When the buttont clink on function is used to rent a car
        private void view_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Rent", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rentView.DataSource = dt;
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
