using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
// started with public and private internal classes and how to split them into different files
//then went over set and get for the classes and why we need them to retrieve values
//



namespace ConsoleApp1//the name of the project that contains the namespace information must be the same as the project name
{
    internal class Product{
        public string Name;// { get; set; }
        public double Price;// { get; set; }
        public int Quantity;// { get; set; }
        public enum Category{
                    office,
                    kids,
                    clothing,
                    electronics

                }
        Category category;


        bool SetName(string name){
            if(name.Length>0){
                this.Name=name;
                return true;
            }
            return false;
        }
        bool SetPrice(double price){
            this.Price=price;
            return true;
        }

        bool SetQuantity(int quantity){
            this.Quantity=quantity;
            return true;
        }
        bool SetCategory(Category category){
           this.category = category;

        return true;
              
        }

        string GetName(){return this.Name;}
        double GetPrice(){return this.Price;}
        int GetQuantity(){return this.Quantity;}    
        Category GetCategory(){return this.category;}
        


        
        public Product(string name, double price, int quantity, Category category)
        {
            this.SetName(name);
            this.SetPrice(price);
            this.SetQuantity(quantity);
            this.SetCategory(category);
        }

        public void DisplayProduct()
        {
            Console.WriteLine("Product Name: " + this.GetName());
            System.Console.WriteLine("Product Price: " + this.GetPrice());
            System.Console.WriteLine("Product Category: " + this.GetCategory());
        }

      

    }
  

}    
