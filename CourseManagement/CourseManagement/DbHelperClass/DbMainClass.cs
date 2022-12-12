using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.DbHelperInter;

namespace CourseManagement.DbHelperClass
{
    class DbMainClass : DbMainInter
    {
        public void delete(int id)
        {
            course_managementEntities cm = new course_managementEntities();
            management m = cm.management.Find(id);

            cm.management.Remove(m);
            cm.SaveChanges();
        }

        public void insert(string s_name, string t_name, string c_name, string date, string s_time, string f_time)
        {
            course_managementEntities cm = new course_managementEntities();
            management m = new management();

            m.student_name = s_name;
            m.teacher_name = t_name;
            m.course = c_name;
            m.date = date;
            m.start_time = s_time;
            m.finish_time = f_time;

            cm.management.Add(m);
            cm.SaveChanges();
        }

        public void update(int id, string s_name, string t_name, string c_name, string date, string s_time, string f_time)
        {
            course_managementEntities cm = new course_managementEntities();
            management m = cm.management.Find(id);

            m.student_name = s_name;
            m.teacher_name = t_name;
            m.course = c_name;
            m.date = date;
            m.start_time = s_time;
            m.finish_time = f_time;

            cm.SaveChanges();
        }
    }
}
