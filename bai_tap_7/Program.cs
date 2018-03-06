using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace bai_tap_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();   //car() ở đây là tạo một đối tượng từ class Car. 
            var car2 = new Car("white", 2005);

            var car3 = new Car("blue", 2008, "bugatti", 260);
            var car4 = new Car("yellow", 2020, "honda", 600);
            var car5 = new Car("black", 2020, "honda", 1200);
            System.Console.WriteLine("ban co {0} o to", Car.kqcount());

            var nguoi = new Person("ducanh", 18, "anhvuong@gmail.com", 0123456789);
            var nguoi2 = new Person();
            var student1 = new Student("ducanh", 18, "anhvuong123@gmail.com", 0123456789, 15);
            System.Console.WriteLine(student1.Age);
            var teacher1=new Teacher("thao",20,"thao@gamil.com","day html");
            
            System.Console.WriteLine(teacher1.Name);

            Calculator.Add(10,20);
            Calculator.Substract(2,9);

        }
    }
    class Car
    {
        public string Color { get; set; } = "red";
        public int Year { get; set; } = 2017;
        public string Brand { get; set; } = "Hyundai";
        public int Mileage { get; set; } = 780;
        public static int count;   //tạo một biến count để một lần tao một đối tương thì biến count này sẽ công thêm một để cho lâp trình viên quản lí một cách dễ dàng ;
       
        public Car()    // car() mà không truyền vào gì là constructor mắc định
        {
            count++;     
        }
        public Car(string color, int year)  //constructor với hai tham số truyền vào
        {
            Color = color;
            Year = year;
            count++;
        }
        public Car(string color, int year, string brand, int mileage)      //constructor với 4 tham số truyền vào.
        {
            Color = color;
            Year = year;
            Brand = brand;
            Mileage = mileage;
            count++;
        }
         public static int kqcount()
        {
            return count;
        }
    }
    
    

}
