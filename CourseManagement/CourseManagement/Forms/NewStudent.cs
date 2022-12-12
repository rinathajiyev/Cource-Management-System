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
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            DbStudentClass d_student = new DbStudentClass();
            d_student.insert(name);

            MessageBox.Show("added");
        }
    }
}
