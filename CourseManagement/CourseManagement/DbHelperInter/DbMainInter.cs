using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.DbHelperInter
{
    interface DbMainInter
    {
        void insert(string s_name, string t_name, string c_name, string date, string s_time, string f_time);

        void delete(int id);

        void update(int id, string s_name, string t_name, string c_name, string date, string s_time, string f_time);
    }
}
