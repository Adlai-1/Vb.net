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
    public partial class Set_up : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-65D891GL;Initial Catalog= Student Management System;Integrated Security=True");
        public Set_up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            String query = "INSERT INTO Logins(StudentId,Username,SpecialPIN)VALUES('" + textBox1.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
            SqlCommand command = new SqlCommand(query, connect);
            command.ExecuteNonQuery();
            MessageBox.Show("Username and Password Created!");

            Login log = new Login();
            log.Show();
            this.Hide();
            connect.Close();
        }
    }
}