using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1//the name of the project that contains the namespace information must be the same as the project name
{
    public class Address{
        public string Street;
        public string City;       
        public int BuildingNumber;
        public string Country;
        public bool setStreet { get; set; }
        public Address(string street, string city , int BuildingNumber, string Country){
            this.Street=street;
            this.City=city;
            this.BuildingNumber=BuildingNumber;
            this.Country=Country;
        }
    }
    internal class User{  
        
        string UserName;
        string Password;
        protected Address UserAddress;
        
        bool SetUserName(string name){this.UserName=name;return true;}
        bool SetPassword(string password){this.Password=password;return true;}
        bool SetUserAddress(Address address){this.UserAddress=new Address(address.Street,address.City,address.BuildingNumber,address.Country);return true;}

        public string getUserName(){return this.UserName;}
        public string getPassword(){return this.Password;}
        public Address getUserAddress(){return this.UserAddress;}

        public User(string name, string password, Address address){//no error checking
            this.SetUserName(name);
            this.SetPassword(password);
            this.SetUserAddress(address);
        }


    }
       

}    
