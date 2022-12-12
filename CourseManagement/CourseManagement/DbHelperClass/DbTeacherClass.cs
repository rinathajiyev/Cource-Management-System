using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.DbHelperInter;

namespace CourseManagement.DbHelperClass
{
    class DbTeacherClass:DbNameInter
    {
        public void insert(string name)
        {
            course_managementEntities cm = new course_managementEntities();
            teachers s = new teachers();

            s.name = name;

            cm.teachers.Add(s);
            cm.SaveChanges();
        }
    }
}
