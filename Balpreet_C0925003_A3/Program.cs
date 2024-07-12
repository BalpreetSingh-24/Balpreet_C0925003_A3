using System;
using System.Collections.Generic;

namespace Balpreet_C0925003_A3 {
    class Address{
        // Data fields
        private string street;
        private string city;
        private string province;
        private string zipCode;

        // No-arg constructor 
        public Address()
        {
            street = "";
            city = "";
            zipCode = "";
            province = "";
        }

        // Constructor that creates an address with street, city, province, and zipCode
        public Address(string street, string city, string province, string zipCode)
        {
            this.street = street;
            this.city = city;
            this.province = province;
            this.zipCode = zipCode;
        }

        public override string ToString()
        {
            return $"\nThe Address Is \nStreet: {street}\nCity: {city}\nProvince: {province}\nZipCode: {zipCode}\n";
        }
    }

    class Residence
    {
        // Data fields
        private double price;
        private double squareFeet;
        private int yearBuilt;
        private Address address;

        // No-arg constructor 
        public Residence()
        {
            price = 0;
            squareFeet = 0;
            yearBuilt = 0;
            address = new Address();
        }

        // Constructor that creates  Residence with bedrooms, bathrooms, price, squareFeet, yearBuilt, and address
        public Residence(double price, double squareFeet, int yearBuilt, Address address)
        {
            this.price = price;
            this.squareFeet = squareFeet;
            this.yearBuilt = yearBuilt;
            this.address = address;
        }

        // Calculate and Returns the commission amount.
        public double CalculateCommission()
        {
            return price * 0.028;
        }

        public override string ToString()
        {
            return $"\nResidence  \nPrice: $ {price}\nSquare Feet: {squareFeet}\nYear Built: {yearBuilt}\n{address}";
        }
    }

    class Program
    {
        public static void Main(string[ ] args){

            //Prompts the user to enter the street name, city, province, zip code.
            Console.Write("Enter Address \n");
            Console.Write("Enter Street Name: ");
            string street = Console.ReadLine();

            Console.Write("Enter City Name: ");
            string city = Console.ReadLine();

            Console.Write("Enter Province Name: ");
            string province = Console.ReadLine();

            Console.Write("Enter ZipCode Name: ");
            string zipcode = Console.ReadLine();

            //Creating instance
            Address Address_line = new Address(street, city, province, zipcode);

            //Displays this information using ToString().
            Console.WriteLine(Address_line);

            //prompting to enter the numbers of bedrooms, bathrooms, price, square Feet and year built.
            Console.Write("Enter House Details \n");
            
            Console.Write("Enter years built: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter square feet: ");
            double sqft = double.Parse(Console.ReadLine());

            //Creating instance
            Residence residence = new Residence(price, sqft, year, Address_line);

            //Display the information
            Console.WriteLine(residence);
            Console.WriteLine("Commission Is $ " + residence.CalculateCommission().ToString());

            Console.ReadLine();
        }
    }
}