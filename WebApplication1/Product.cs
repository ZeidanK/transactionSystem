using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
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
            this.Name="default";
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
        bool SetCategory(string category){
           this.category = (Category)Enum.Parse(typeof(Category), category);

        return true;
              
        }

        public string GetName(){return this.Name;}
        public double GetPrice(){return this.Price;}
        public int GetQuantity(){return this.Quantity;}    
        public Category GetCategory(){return this.category;}
        


        public Product(){
            this.Name="default";
            this.Price=0;
            this.Quantity=0;
            this.category=Category.office;
        }
        public Product(string name, double price, int quantity, string category)
        {
            this.Name="default";
            this.Price=0;
            this.Quantity=0;
            this.category=Category.office;
            if(!this.SetName(name)){
                Console.WriteLine("Error in setting product name");
                this.SetName("default");
            }
            this.SetPrice(price);
            this.SetQuantity(quantity);
            this.SetCategory(category);
        }

        public void CopyFrom(Product product){
            this.SetName(product.GetName());
            this.SetPrice(product.GetPrice());
            this.SetQuantity(product.GetQuantity());
            this.SetCategory(product.GetCategory().ToString());

        }
        public void DisplayProduct(){
            Console.WriteLine("Product Name: "+this.Name+"Product Price: "+this.Price+"Product Quantity: "+this.Quantity+"Product Category: "+this.category.ToString());
        }
        

    }
  

}    
