using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Courses courses = new Add_Courses();
            courses.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteCourses delete = new DeleteCourses();
            delete.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Semester sem = new Semester();
            sem.Show();
            this.Hide();
        }
    }
}
