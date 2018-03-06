namespace bai_tap_7
{
    public class Person
    {
         public string Name { get; set; }="ducanh";
        public int Age { get; set; }=18;
        public string Email { get; set; }="anhvuong730@gmail.com";
        public int Phone { get; set; }=0123456789;
        public Person(string name, int age, string email, int phone)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
            this.Phone = phone;
        }
        public Person() {}

        public Person(string name,int age, string email){
                this.Name = name;
                this.Age=age;
                this.Email=email;
        }
    }
    class Student : Person
    {
        private int ID { get; set;}
        private string Degree{get;set;} 
        // tu khai bao bien private va phuong get - set
        public Student(string name, int age, string email, int phone, int id) : base(name, age, email, phone)  
        {
            this.ID = id;
        }
        // từ khóa base để thể hiện lớp con kế thừa các thuộc tính của lớp cha vốn có;
        public Student(string name,int age, string email,string degree):base(name,age,email)
        {
            this.Degree=degree;
        }
    }
    class Teacher : Person
    {
        private int Maso { get; set; }
        private string Experience{get;set;}
        public Teacher(string name, int age, string email, int phone, int maso) : base(name, age, email, phone)
        {
            this.Maso = maso;
        }
        public Teacher(string name,int age, string email,string experience) :base(name, age, email)
        {
            this.Experience=experience;
        }
    }

   static class  Calculator
    {
       public static void Add(int a ,int b)
       {
          System.Console.WriteLine("KQ CUA {0} + {1} = {2}",a,b,a+b );
       }
       public static void Substract(int a , int b)
       {
           System.Console.WriteLine(a-b);
       }
    }
}