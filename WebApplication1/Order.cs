using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1//the name of the project that contains the namespace information must be the same as the project name
{
    internal class Order{  
        User buyer;
        Product[] products;
        int totalPrice;
        int numberOfProducts;

    public Order(User buyer, Product[] products, int totalPrice, int numberOfProducts) {
        this.buyer = buyer;
        this.products = products;
        this.totalPrice = totalPrice;
        this.numberOfProducts = numberOfProducts;
    }

    // Getters and Setters
    public User Buyer {
        get { return buyer; }
        set { buyer = value; }
    }

    public Product[] Products {
        get { return products; }
        set { products = value; }
    }

    public int TotalPrice {
        get { return totalPrice; }
        set { totalPrice = value; }
    }

    public int NumberOfProducts {
        get { return numberOfProducts; }
        set { numberOfProducts = value; }
    }

    public void DisplayOrder(){
        this.buyer.DisplayUser();

    }

}    
