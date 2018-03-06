namespace bai_tap_8
{
       
     class Shape
    {
        public int Width{get;set;}
        public int Height{get;set;}

        public Shape(){}    //constructors 
        public Shape(int width , int height){     //constructor
             this.Width = width;  
             this.Height=height;
        }
        public virtual void getArea(int a , int b){}  //phương thức
        public virtual void getPerimeter(int a,int b ) {} // phương thức
       

    }
    class Square:Shape
    {
        public override void getArea(int a , int b)
        {
                System.Console.WriteLine("dien tich hinh vuong {0} * {1} = {2}",a,b,a*b);
        }
        public override void getPerimeter(int a,int b)
        {
            System.Console.WriteLine("tinh chu vi hinh vuong {0} * {1} = {2}",a,b,a*4);
        }
    }
    class Rectangle:Shape
    {
         public override void getArea(int width, int height)
        {
            System.Console.WriteLine("dien tich hinh chu nhat {0} * {1} = {2}",width,height,width*height);
        }
        public override void getPerimeter(int width , int height)
        {
            System.Console.WriteLine("chu vi  hinh chu nhat {0} * {1} = {2}",width,height,(2*(width*height)));
        }
        
    }
   
}