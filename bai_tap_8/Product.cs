using System.Collections.Generic;
namespace bai_tap_8
{
    public class Product
    {
        public  string Name{get;set;}
        public int  Amount{get;set;}
        public double Price{get;set;}
        public Product(){}
        public  Product(string name ,int amount,double price){
            this.Name = name;
            this.Amount = amount;
            this.Price= price;
            count+=amount;    // dòng này là để tính số lượng  hàng 
        }
        public static int count=0;
        public static int tinhtongsp(){
            return count;   //sau đó trả về kết quả vủa tổng số lương hàng 
        }
    }
    class Inventory
    {
       public List<Product> Sp {get;set;} = new  List<Product>(){};
       static int count=0;
       public void num (Product sp){
           Sp.Add(sp);
           count++;
       }
       public static int kq(){
           return count;
       }
    }
}