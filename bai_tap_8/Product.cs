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
        }
    }
    class Inventory
    {
       public List<Product> Sp { get;set;} = new  List<Product>(){};
       public void num (Product sp){
           Sp.Add(sp);
       }
    }
}