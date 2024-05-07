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

        string GetName(){return this.Name;}
        double GetPrice(){return this.Price;}
        int GetQuantity(){return this.Quantity;}    

        


        enum Category{
            office,
            kids,
            clothing,
            electronics

        }
        public Product(string name, double price, int quantity)
        {
            this.SetName(name);
            this.SetPrice(price);
            this.SetQuantity(quantity);
        }  

    }
  

}    
