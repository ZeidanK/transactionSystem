using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;



namespace ConsoleApp1//the name of the project that contains the namespace information must be the same as the project name
{
    internal class Program{  
        public static Address GetAddressFromUser()
    {
        Console.Write("Enter Street: ");
        string street = Console.ReadLine();

        Console.Write("Enter City: ");
        string city = Console.ReadLine();

        Console.Write("Enter Building Number: ");
        int buildingNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Country: ");
        string country = Console.ReadLine();

        return new Address(street, city, buildingNumber, country);
    }

        public static Buyer GetBuyerFromUser() {
        User user = GetUserFromUser();

        Console.Write("Enter number of products: ");
        int numProducts = Convert.ToInt32(Console.ReadLine());

        Product[] cartArray = new Product[numProducts];
        for (int i = 0; i < numProducts; i++) {
            Console.WriteLine($"Enter information for product {i + 1}:");
            cartArray[i] = GetProductFromUser();
        }

        return new Buyer(user, cartArray);
    }
        public static User GetUserFromUser()
    {
        Console.Write("Enter User Name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        Console.WriteLine("Enter Address Information: ");
        Address address = GetAddressFromUser();

        return new User(userName, password, address);
    }
        public static Seller GetSellerFromUser() {
            User user = GetUserFromUser();
            Console.Write("Enter number of products: ");
            int numProducts = Convert.ToInt32(Console.ReadLine());

            Product[] productArray = new Product[numProducts];
            for (int i = 0; i < numProducts; i++) {
                Console.WriteLine($"Enter information for product {i + 1}:");
                productArray[i] = GetProductFromUser();
            }

            return new Seller(user, productArray);
        }
        public static Product GetProductFromUser() {
        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Product Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Product Quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Product Category (office, kids, clothing, electronics): ");
        string category = Console.ReadLine();

        return new Product(name, price, quantity, category);
    }
        
        public static Seller[] AddSellerToArray(Seller[] sellers, Seller newSeller) {
        Seller[] newSellers = new Seller[sellers.Length + 1];
        for (int i = 0; i < sellers.Length; i++) {
            newSellers[i] = sellers[i];
        }
        newSellers[sellers.Length] = newSeller;
        return newSellers;
    }
        public static int ChooseSeller(Seller[] sellers) {
            for (int i = 0; i < sellers.Length; i++) {
                Console.Write($"{i + 1}. ");
                sellers[i].DisplaySeller();
            }

            Console.Write("Enter the number of the seller you choose: ");
            int chosenSellerIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            return chosenSellerIndex;
        }
        public static Buyer[] AddBuyerToArray(Buyer[] buyers, Buyer newBuyer) {
        Buyer[] newBuyers = new Buyer[buyers.Length + 1];
        for (int i = 0; i < buyers.Length; i++) {
            newBuyers[i] = buyers[i];
        }
        newBuyers[buyers.Length] = newBuyer;
        return newBuyers;
    }
        public static bool AddBuyer(ref Buyer[] buyers){
            Buyer buyer=GetBuyerFromUser();
            buyers=AddBuyerToArray(buyers,buyer);
            return true;
            }
        public static bool AddSeller(ref Seller[] sellers){
            Seller seller=GetSellerFromUser();
            sellers=AddSellerToArray(sellers,seller);
            return true;        
}
        public static bool AddProductToSeller(ref Seller seller) {
            Product newProduct = GetProductFromUser();
             Product[] newProductArray = new Product[seller.ProductArray.Length + 1];
            for (int i = 0; i < seller.ProductArray.Length; i++) {
                newProductArray[i] = seller.ProductArray[i];
            }
            newProductArray[newProductArray.Length - 1] = newProduct;
            seller.ProductArray = newProductArray;

            return true;   
        }
        public static bool AddProductToCart(){return false;}
        public static bool AddProductToCart(ref Buyer buyer) {
    Product newProduct = GetProductFromUser();

    // Create a new array with an extra slot for the new product
    Product[] newCart = new Product[buyer.Cart.Length + 1];

    // Copy the old cart to the new cart
    for (int i = 0; i < buyer.Cart.Length; i++) {
        newCart[i] = buyer.Cart[i];
    }

    // Add the new product to the last slot of the new cart
    newCart[newCart.Length - 1] = newProduct;

    // Replace the old cart with the new cart
    buyer.Cart = newCart;

    return true;
}
        public static bool PayForOrder(){return false;}
        public static bool DisplayAllBuyers(){return false;}
        public static bool DisplayAllSellers(){return false;}
        public static bool DisplayAllProducts(){return false;}
        public static bool DisplayAllProductsInSeller(){return false;}
        public static int  PrintMenu(){

            System.Console.WriteLine("Welcome to the Program ");
            System.Console.WriteLine("1) Add Buyer ");
            System.Console.WriteLine("2) add seller ");
            System.Console.WriteLine("3) Add Prucuct to seller ");
            System.Console.WriteLine("4) Add product to Buyer Cart ");
            System.Console.WriteLine("5) Pay for Order in Cart ");
            System.Console.WriteLine("6) Display All Buyers");
            System.Console.WriteLine("7) Display all Sellers ");
            System.Console.WriteLine("8) Exit ");
            return(int.Parse(Console.ReadLine()));
            
        }
        public  static bool RunInput(ref Buyer[] buyers, ref Seller[] sellers){
            int Input=PrintMenu();
            bool res;
            switch (Input){
                case 1:{
                    res=(bool)AddBuyer(ref buyers);

                    break;
                }
                case 2:{
                    res=AddSeller(ref sellers);

                    break;
                }
                case 3:{
                    res=AddProductToSeller(ref sellers[ChooseSeller(sellers)]);

                    break;
                }
                case 4:{

                    res=AddProductToCart();
                    break;
                }
                case 5:{
                    res=PayForOrder();

                    break;
                }
                case 6:{

                    res=DisplayAllBuyers();
                    break;
                }
                case 7:{

                    res=DisplayAllSellers();
                    break;
                }
                case 8:{
                    return false;

                    break;
                }
                





            }


            return true;
        }


        public static void Main(string[] args)
        {
            Buyer[] buyers = new Buyer[0];
            Seller[] sellers = new Seller[0];

        
            bool res=true;
            while(res){
                res=RunInput(ref buyers,ref sellers);
            }
        }

        
    }

        

}    