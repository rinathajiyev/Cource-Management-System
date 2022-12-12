using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.DbHelperInter;

namespace CourseManagement.DbHelperClass
{
    class DbCourseClass : DbNameInter
    {
        public void insert(string name)
        {
            course_managementEntities cm = new course_managementEntities();
            courses s = new courses();

            s.name = name;

            cm.courses.Add(s);
            cm.SaveChanges();
        }
    }
}
