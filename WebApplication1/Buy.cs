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
    internal class Buyer{  
        User user;
        Product[] cartArray;
        Order[] orderArray;

    public Buyer(User user, Product[] cartArray):this() {
        this.SetCartArray(cartArray);
        this.SetUser(user);
        this.SetOrderArray(orderArray);
        
    }
    public Buyer(User user):this() {
        this.SetUser(user);
    }
    public Buyer() {
        this.user = new User();
        this.cartArray = new Product[0];
        this.orderArray = new Order[0];
    }

    public Order[] GetOrderArray(){
        return this.orderArray;
    }
    public bool SetOrderArray(Order[] orderArray){
        this.orderArray=orderArray;
        return true;
    }

    public User GetUser() {
        return this.user;
    }

    public void SetUser(User user) {
        this.user = user;
    }

    public Product[] GetCartArray() {
        return this.cartArray;
    }

    public void SetCartArray(Product[] cartArray) {
        this.cartArray = cartArray;
    }
    public void DisplayBuyer(){
        this.user.DisplayUser();
    }
public void AddProductToCart(Product newProduct) {
        // Create a new array with an extra slot for the new product
        Product[] newCartArray = new Product[cartArray.Length + 1];

        // Copy the old cart array to the new array
        for (int i = 0; i < cartArray.Length; i++) {
            newCartArray[i] = cartArray[i];
        }

        // Add the new product to the last slot of the new array
        newCartArray[newCartArray.Length - 1] = newProduct;

        // Replace the old cart array with the new array
        cartArray = newCartArray;
    }
    public bool AddOrder(Order newOrder){
        Order[] newOrderArray = new Order[orderArray.Length + 1];
        for (int i = 0; i < orderArray.Length; i++) {
            newOrderArray[i] = orderArray[i];
        }
        newOrderArray[newOrderArray.Length - 1] = newOrder;
        orderArray = newOrderArray;
        return true;
    }
    public Order SubmitOrder(User buyer, Product[] products, double totalPrice, int numberOfProducts) {
        Order newOrder = new Order(buyer, products, totalPrice, numberOfProducts);
        AddOrder(newOrder);
        return newOrder;
    }
    public double CalculateTotalPrice(Product[] products) {
        double totalPrice = 0;
        for (int i = 0; i < products.Length; i++) {
            totalPrice += products[i].GetPrice();

        }
        return totalPrice;
    }
    public int CalculateNumberOfProducts(Product[] products) {
        return products.Length;
    }
    public bool ArchiveOrder(){
        return(AddOrder(SubmitOrder(this.GetUser(), this.GetCartArray(), CalculateTotalPrice(this.GetCartArray()), CalculateNumberOfProducts(this.GetCartArray()))));
    }








    }

      

}    
