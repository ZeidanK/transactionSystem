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
        this.user = user;
        this.productArray = productArray;
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


    }
      

}    
