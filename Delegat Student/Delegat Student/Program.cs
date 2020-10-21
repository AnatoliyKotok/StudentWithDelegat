using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.addProgMarks();
            student.addAdminMarks();
            student.addDisanMarks();
            student.Info(Student.Subjects.All);

        }
    }
}
