using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseManagement.DbHelperClass;
namespace CourseManagement.Forms
{
    public partial class NewCourse : Form
    {
        public NewCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            DbCourseClass d_course = new DbCourseClass();
            d_course.insert(name);

            MessageBox.Show("added");
        }
    }
}
