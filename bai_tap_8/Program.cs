using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace bai_tap_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(20,10);
            Calculator.Add(50.9,20.9);
            Calculator.Add("duc","anh");

            Square vuong1 = new Square();
            vuong1.getArea(10,20);
            vuong1.getPerimeter(10,20);
            Rectangle hcn1 = new Rectangle();
            hcn1.getArea(5,6);
            hcn1.getPerimeter(5,6);

            Iphone iphone1 = new Iphone();
            iphone1.Call(); 
            iphone1.Camera();

            Samsung samsung1 = new Samsung();
            samsung1.Camera();
        
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
