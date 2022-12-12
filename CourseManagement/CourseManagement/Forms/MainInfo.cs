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
    public partial class MainInfo : Form
    {
        public MainInfo()
        {
            InitializeComponent();
        }

        int id = -1;
        string s1 = null;
        string s2 = null;
        string s3 = null;
        string s4 = null;
        string s5 = null;
        string s6 = null;

        public void dataFromDGV(int id, string s1, string s2, string s3, string s4, string s5, string s6)
        {
            this.id = id;
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            this.s4 = s4;
            this.s5 = s5;
            this.s6 = s6;
        }

        private void getData()
        {
            course_managementEntities cm = new course_managementEntities();
            comboBox1.DataSource = cm.students.ToList();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";

            comboBox2.DataSource = cm.teachers.ToList();
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";

            comboBox3.DataSource = cm.courses.ToList();
            comboBox3.DisplayMember = "name";
            comboBox3.ValueMember = "id";
        }

        private void InsertMain_Load(object sender, EventArgs e)
        {
            if (s1 != null && s2 != null && s3 != null && s4 != null && s5 != null && s6 != null)
            {
                getData();
                comboBox1.Text = s1;
                comboBox2.Text = s2;
                comboBox3.Text = s3;
                dateTimePicker1.Text = s4;
                textBox1.Text = s5;
                textBox2.Text = s6;
            }
            else
            {
                getData();
            }
        }

        private bool DoSomethingElse(string v1, object s1, string v2, object s2)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s_name = comboBox1.Text;
            string t_name = comboBox2.Text;
            string c_name = comboBox3.Text;
            string date = dateTimePicker1.Text;
            string s_time = textBox1.Text;
            string f_time = textBox2.Text;

            if(s_time == null || f_time == null)
            {
                throw new NullReferenceException("start time/finish time cannot be null");
            }

            if (s1 == null && s2 == null && s3 == null && s4 == null && s5 == null && s6 == null)
            {
                DbMainClass db = new DbMainClass();
                db.insert(s_name, t_name, c_name, date, s_time, f_time);
            }
            else
            {
                DbMainClass db = new DbMainClass();
                db.update(this.id, s_name, t_name, c_name, date, s_time, f_time);
            }

            MessageBox.Show("success");
        }
    }
}
