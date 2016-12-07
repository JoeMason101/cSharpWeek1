using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    class Car : Vehicle
    {
        //attributes
        //public string Make { get; set; }
        //public string Model { get; set; }
        //public int Price { get; set; }
        public bool Sold { get; set; }
        public string EngineSize { get; set; }
        public string Colour { get; set; }
        private int mileage;

        //fields
        public static int numberOfCars;
        private Boolean checkIsOn = false;
        public int Speed { get; set; }

        public int Mileage
        {
            get
            {
                return mileage;
            }
            set
            {
                if (value > 0)
                {
                    this.mileage = value;
                }
            }
        }

        public Car()
        {

        }

      

        //public Car(string make, string model, int price)
        //{
        //    this.Make = make;
        //    this.Model = model;
        //    this.Price = price;

        //}

        public void Accelerate (int increment)
        {
            if(!checkIsOn)
            {
                Console.WriteLine("You need to turn the car on");
            } else
            {
                Speed += increment;
            }
        
        }
        public void Decelerate (int decrement)
        {
            Speed -= decrement;
          
        }



    }


}
