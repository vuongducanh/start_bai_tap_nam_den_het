namespace bai_tap_8
{
    interface  Smartphone
    {
         void Call();
         void Camera();
         void wachingTv();
    }
    class Iphone : Smartphone
    {
       public void Call(){
            System.Console.WriteLine("call smartphone ...");
       }
       public void Camera(){
           System.Console.WriteLine("camera  smartphone .... ");
       }
       public void wachingTv(){
            System.Console.WriteLine("wachingTv smartphone");
       }
    }
    
}