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
    public partial class NewTeacher : Form
    {
        public NewTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            DbTeacherClass d_teacher = new DbTeacherClass();
            d_teacher.insert(name);

            MessageBox.Show("added");
        }
    }
}
