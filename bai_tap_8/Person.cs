namespace bai_tap_8
{
    public class Person
    {
        public string Name{get;set;}
        public int Age{get;set;}

        public string Hair{get;set;}
        public Person(){}
        public  Person(string name, int age,string hair) {
            this.Name = Name;
            this.Age=age;
            this.Hair=hair;
        }
        public virtual void Character(){
            System.Console.WriteLine("Person have  character ... ");
        }
        public virtual void Run(){
          System.Console.WriteLine("Preson run");
        }
        public virtual void Cry(){
            System.Console.WriteLine("Person cry");
        }
    }
    class Student:Person
    {
        private int ID{get;set;}
        public Student(string name, int age,string hair,int id):base (name,age,hair)
        {
            this.ID=1234;
        }
        public override void Character()
        {
            System.Console.WriteLine("student  character ....");
        }
        public override void Run(){
            System.Console.WriteLine("student Run ....");
        }
        public override void Cry(){
            System.Console.WriteLine("student cry ....");
        }
    }
    
}