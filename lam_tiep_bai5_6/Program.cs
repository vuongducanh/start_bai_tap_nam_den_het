using System;
using System.Linq;
using System.Collections.Generic;
namespace bai5_6_lam_rien
{
    class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public int Point { get; set; }
        }
        static void Main(string[] args)
        {
            List<Student> studentlist = new List<Student>(){
               new Student(){Name = "ducanh" , Point=5},
               new Student(){Name= "thai",Point=6},
               new Student(){Name = "tung" , Point=5},
               new Student(){Name= "huong",Point=7},
               new Student(){Name = "si" , Point=5},
               new Student(){Name= "duong",Point=8}
           };
            int num = 0;
           foreach (var student in studentlist)
           {
               num += student.Point;
           }
            // System.Console.WriteLine(num/6);
          var teenAgerStudent = from s in studentlist
							  where s.Point < num/6
							  select s;
            foreach (var item in teenAgerStudent)
            {
                 System.Console.WriteLine(item.Name);
            }
        }
    }
}
