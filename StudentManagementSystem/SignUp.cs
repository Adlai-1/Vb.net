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
    public partial class SignUp : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-65D891GL;Initial Catalog= Student Management System;Integrated Security=True");
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sql Query for Populating Table....

            connect.Open();
            String query = "INSERT INTO Student_Information(StudentId,First_Name,Last_Name,Nationality,DoB,Age,Study_Level,Programme,Hall_of_Residence)  VALUES('"+textBox7.Text+ "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + comboBox3.Text + "')";
            SqlCommand command = new SqlCommand(query,connect);
            command.ExecuteNonQuery();
            MessageBox.Show("Profile Saved!");

            //Switching between Forms
            Set_up set = new Set_up();
            set.Show();
            this.Hide();
            connect.Close();
        }
    }

    
}




