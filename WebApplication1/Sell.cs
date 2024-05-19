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
    internal class Seller{  
        User user;
        Product[] productArray;
        

    public Seller(User user, Product[] productArray) {
        this.productArray=new Product[0]    ;//just moving bug
        
        this.user = user;
        this.SetProductArray(productArray);
    }
    bool SetProductArray(Product[] productArray){
        this.productArray=productArray;
        return true;
    }
    public Product[] GetProductArray(){
        return this.productArray;
    }
    public User GetUser() {
        return this.user;
    }
    
    public void AddProduct(Product newProduct) {
        // Create a new array with an extra slot for the new product
        Product[] newProductArray = new Product[productArray.Length + 1];

        // Copy the old product array to the new array
        for (int i = 0; i < productArray.Length; i++) {
            newProductArray[i].CopyFrom(productArray[i]);
        }

        // Add the new product to the last slot of the new array
        newProductArray[newProductArray.Length - 1].CopyFrom(newProduct);

        // Replace the old product array with the new array
        productArray = newProductArray;
    }
    

    // Getters and Setters
    public User User {
        get { return user; }
        set { user = value; }
    }

    public Product[] ProductArray {
        get { return productArray; }
        set { productArray = value; }
    }
    public void DisplaySeller(){
        this.user.DisplayUser();
    }
    public void DisplayProducts(){
        if(productArray.Length==0)
            Console.WriteLine("No products to display");      
        foreach(Product product in productArray)
            Console.WriteLine("Product Name: "+product.GetName());
        


    }
      
    }
}    
