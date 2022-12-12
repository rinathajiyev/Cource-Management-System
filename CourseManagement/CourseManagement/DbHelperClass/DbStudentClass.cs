using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.DbHelperInter;

namespace CourseManagement.DbHelperClass
{
    class DbStudentClass : DbNameInter
    {
        public void insert(string name)
        {
            course_managementEntities cm = new course_managementEntities();
            students s = new students();

            s.name = name;

            cm.students.Add(s);
            cm.SaveChanges();
        }
    }
}
