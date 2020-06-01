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
    public partial class Semester : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-65D891GL;Initial Catalog= Student Management System;Integrated Security=True");
        public Semester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Hide();
        }

        private void Semester_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlDataReader reader;
            String query = "SELECT Course1,Course2,Course3,Course4,Course5,Course6 FROM Courses WHERE StudentId='"+textBox1.Text+"'";
            SqlCommand command = new SqlCommand(query, connect);

           
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                label5.Text = (String) reader.GetValue(0);
                label6.Text = (String) reader.GetValue(1);
                label7.Text = (String) reader.GetValue(2);
                label8.Text = (String) reader.GetValue(3);
                label9.Text = (String) reader.GetValue(4);
                label10.Text = (String) reader.GetValue(5);
            }

            reader.Close();
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}
