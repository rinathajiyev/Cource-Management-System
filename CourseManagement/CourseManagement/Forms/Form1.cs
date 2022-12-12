using CourseManagement.Forms;
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

namespace CourseManagement
{
    public partial class Form1 : Form
    {
        public DataGridView DGV { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainInfo main = new MainInfo();
            main.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudent student = new NewStudent();
            student.ShowDialog();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTeacher teacher = new NewTeacher();
            teacher.ShowDialog();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCourse course = new NewCourse();
            course.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MainInfo main = new MainInfo();

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    string value1 = row.Cells[1].Value.ToString();
                    string value2 = row.Cells[2].Value.ToString();
                    string value3 = row.Cells[3].Value.ToString();
                    string value4 = row.Cells[4].Value.ToString();
                    string value5 = row.Cells[5].Value.ToString();
                    string value6 = row.Cells[6].Value.ToString();
                    //...
                    main.dataFromDGV(id, value1, value2, value3, value4, value5, value6);
                }

                main.ShowDialog();
            }else
            {
                MessageBox.Show("Choose the row");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[item.Index];
                    int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    DbMainClass main = new DbMainClass();
                    main.delete(id);

                    loadData();

                    MessageBox.Show("deleted");
                }
            }
            else
            {
                MessageBox.Show("Choose the row");
            }
        }

        private void loadData()
        {
            course_managementEntities cm = new course_managementEntities();
            dataGridView1.DataSource = cm.management.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            course_managementEntities cm = new course_managementEntities();
            if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                var result = cm.management.Where(m => m.student_name == textBox1.Text).ToList();
                dataGridView2.DataSource = result;
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == "")
            {
                var result = cm.management.Where(m => m.student_name == textBox1.Text
                && m.teacher_name == textBox2.Text).ToList();
                dataGridView2.DataSource = result;
            }
            else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text != "" && textBox4.Text == "")
            {
                var result = cm.management.Where(m => m.student_name == textBox1.Text
                && m.course == textBox3.Text).ToList();
                dataGridView2.DataSource = result;
            }
            else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text != "")
            {
                var result = cm.management.Where(m => m.student_name == textBox1.Text
                && m.date == textBox4.Text).ToList();
                dataGridView2.DataSource = result;
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
            {
                var result = cm.management.Where(m => m.student_name == textBox1.Text
                && m.teacher_name == textBox2.Text && m.course == textBox3.Text).ToList();
                dataGridView2.DataSource = result;
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text != "")
            {
                var result = cm.management.Where(m => m.student_name == textBox1.Text
                && m.teacher_name == textBox2.Text && m.date == textBox4.Text).ToList();
                dataGridView2.DataSource = result;
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text == "")
            {
                var result = cm.management.Where(m => m.teacher_name == textBox2.Text).ToList();
                dataGridView2.DataSource = result;
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
            {
                var result = cm.management.Where(m => m.teacher_name == textBox2.Text
                && m.course == textBox3.Text).ToList();
                dataGridView2.DataSource = result;
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text == "" && textBox4.Text != "")
            {
                var result = cm.management.Where(m => m.teacher_name == textBox2.Text
                && m.date == textBox4.Text).ToList();
                dataGridView2.DataSource = result;
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                var result = cm.management.Where(m => m.teacher_name == textBox2.Text
                && m.course == textBox3.Text && m.date == textBox4.Text).ToList();
                dataGridView2.DataSource = result;
            }
            else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "" && textBox4.Text == "")
            {
                var result = cm.management.Where(m => m.course == textBox3.Text).ToList();
                dataGridView2.DataSource = result;
            }
            else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "" && textBox4.Text != "")
            {
                var result = cm.management.Where(m => m.course == textBox3.Text
                && m.date == textBox4.Text).ToList();
                dataGridView2.DataSource = result;
            }
            else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text != "")
            {
                var result = cm.management.Where(m => m.date == textBox4.Text).ToList();
                dataGridView2.DataSource = result;
            }
            else
            {
                var result = cm.management.Where(m => m.student_name == textBox1.Text
                && m.teacher_name == textBox2.Text && m.course == textBox3.Text
                && m.date == textBox4.Text).ToList();
                dataGridView2.DataSource = result;
            }

        }
    }
}
