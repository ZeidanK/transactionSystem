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
        Product[] CartArray;


    public Buyer(User user, Product[] cartArray) {
        this.user = user;
        this.CartArray = cartArray;
    }

    public User GetUser() {
        return this.user;
    }

    public void SetUser(User user) {
        this.user = user;
    }

    public Product[] GetCartArray() {
        return this.CartArray;
    }

    public void SetCartArray(Product[] cartArray) {
        this.CartArray = cartArray;
    }
    public void DisplayBuyer(){
        this.user.DisplayUser();
    }










    }

      

}    
