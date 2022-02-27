using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task10
{
    class AllStudents:List<Student>
    {
        public AllStudents()
        {
            Add(new Student("Ake"));
            Add(new Student("Make"));
            Add(new Student("Pera"));
            Add(new Student("Mä"));

        }
    }
}
