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

namespace StudentManagementSystem
{
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-65D891GL;Initial Catalog= Student Management System;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQL Instructions........
            connect.Open();
            String query = "SELECT COUNT(*) FROM Logins WHERE Username = '"+textBox1.Text+"'AND SpecialPIN = '"+textBox2.Text+"'";
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            if(ds.Rows[0][0].ToString() == "1")
            {
                DashBoard dash = new DashBoard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Credentials Try Again!");
                this.Show();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            command.ExecuteNonQuery();
            connect.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp next = new SignUp();
            next.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

