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
            System.Console.WriteLine("call iphone ...");
       }
       public void Camera(){
           System.Console.WriteLine("camera  iphone .... ");
       }
       public void wachingTv(){
            System.Console.WriteLine("wachingTv iphone...");
       }
    }
    class Samsung :Smartphone
    {
        public void Call(){
            System.Console.WriteLine("call samsung ...");
        }
        public void Camera()
        {
            System.Console.WriteLine(" Camere samsung ...");
        }
        public void wachingTv()
        {
            System.Console.WriteLine("wachingTv samsung ...");
            
        }
        
    }
    
}