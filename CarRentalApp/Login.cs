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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\ved\\CarRentalApp\\CarDataBase.mdf;Integrated Security=True;Connect Timeout=30");


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Uname.Text == "" || psName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from userT where userName=@userName and userPassword=@userPassword", Con);
                    cmd.Parameters.AddWithValue("@userName" , Uname.Text);
                    cmd.Parameters.AddWithValue("@userPassword", psName.Text);
                    SqlDataAdapter dt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dt.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;
                    if(i == 1)
                    {
                        Home home = new Home();
                        home.Show();
                        MessageBox.Show("User Sucessfully Loged In");
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Please enter valid credentials!!!");
                    }

                    cmd.ExecuteNonQuery();   
                    Con.Close();

                    
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
