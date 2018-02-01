using System;

namespace bai_tap_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(20,10);
            Calculator.Add(50.9,20.9);
            Calculator.Add("duc","anh");
        }
    }
    class Calculator
    {
         public static void Add(int a , int b)
         {
             System.Console.WriteLine("phep tinh cong int {0} + {1} = {2}" ,a,b,a+b);
         }
         public static void Add(double a, double b)
         {
             System.Console.WriteLine("phep cong cua hai duoble {0} + {1}  = {2}",a,b,a+b);
         }
         public static void Add(string a, string b)
         {
             System.Console.WriteLine("phep cong cua string {0} +{1} = {2}",a,b,a+b);
         }
    }
}
