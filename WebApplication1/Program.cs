using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;



namespace ConsoleApp1//the name of the project that contains the namespace information must be the same as the project name
{
    internal class Program{  
        public bool AddBuyer(){return false;}
        public bool AddSeller(){return false;}
        public bool AddProductToSeller(){return false;}
        public bool AddProductToCart(){return false;}
        public bool PayForOrder(){return false;}
        public bool DisplayAllBuyers(){return false;}
        public bool DisplayAllSellers(){return false;}
        public bool DisplayAllProducts(){return false;}
        public bool DisplayAllProductsInSeller(){return false;}
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
        public  bool RunInput(){
            int Input=PrintMenu();
            bool res;
            switch (Input){
                case 1:{
                    res=(bool)AddBuyer();

                    break;
                }
                case 2:{
                    res=AddSeller();

                    break;
                }
                case 3:{
                    res=AddProductToSeller();

                    break;
                }
                case 4:{


                    break;
                }
                case 5:{


                    break;
                }
                case 6:{


                    break;
                }
                case 7:{


                    break;
                }
                case 8:{
                    return false;

                    break;
                }
                





            }


            return true;
        }

    }

        

}    