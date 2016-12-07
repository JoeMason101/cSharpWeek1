using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    class Vehicle
    {
        //attributes
        public string Brand { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }

        public static int numberOfVehicles;

        public Vehicle()
        {

        }

        public Vehicle(string brand, string make, string model, int price)
        {
            this.Brand = brand;
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }
    }
}
