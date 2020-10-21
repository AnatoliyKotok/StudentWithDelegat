using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_Student
{
    delegate void ShowDelegat();
    class Student
    {
        List<int> progMarks=new List<int>();
        List<int> adminMarks=new List<int>();
        List<int> disanMarks=new List<int>();
        ShowDelegat sd;
        public void addProgMarks()
        {
            Random rd = new Random();
            progMarks.Add(rd.Next(1, 12));
        }
        public void addAdminMarks()
        {
            Random rd = new Random();
            adminMarks.Add(rd.Next(1, 12));
        }
        public void addDisanMarks()
        {
            Random rd = new Random();
            disanMarks.Add(rd.Next(1, 12));
        }
        public void ShowProgMarks()
        {
            Console.WriteLine("Program marks");
            foreach(var i in progMarks)
            {
                Console.WriteLine(i);
            }
        }
        public void ShowAdminMarks()
        {
            Console.WriteLine("Admin marks");
            foreach (var i in adminMarks)
            {
                Console.WriteLine(i);
            }
        }
        public void ShowDisanMarks()
        {
            Console.WriteLine("Desin mrks");
            foreach (var i in disanMarks)
            {
                Console.WriteLine(i);
            }
        }
       public  enum Subjects { Programming,Administration,Desing,All}
        public void Info(Subjects s)
        {
            if (s == Subjects.Programming) {

                sd = ShowProgMarks;
                sd();
            }
            else if (s == Subjects.Administration)
            {
                sd = ShowAdminMarks;
                sd();
            }
            else if (s == Subjects.Desing)
            {
                sd = ShowDisanMarks;
                sd();
            }
            else if (s == Subjects.All)
            {
                sd = ShowProgMarks;
                sd += ShowAdminMarks;
                sd += ShowDisanMarks;
                sd();
            }
            else
            {
                Console.WriteLine($"Tyte {s} not found!");
            }
                   
        }
    }
}
