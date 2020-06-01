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
    public partial class DeleteCourses : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-65D891GL;Initial Catalog= Student Management System;Integrated Security=True");
        public DeleteCourses()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();

            String query = "UPDATE Courses SET "+textBox1.Text+" = 'Course Deleted!'  WHERE StudentId= '"+textBox2.Text+"'";
            SqlCommand command = new SqlCommand(query, connect);
            command.ExecuteNonQuery();
            MessageBox.Show("Course Removed!");
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Hide();
            connect.Close();
        }
    }
}


