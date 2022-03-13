using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_class2.Models
{
    class Car: Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        public Car()
        {

        }
        public Car(string Brand,string Model,int year,double FuelCapacity,double FuelFor1Km):base(year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1Km = FuelFor1Km;
            
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand}  Model:{Model}  Year{year}  FullCapacity{FuelCapacity}  FullFor1km:{FuelFor1Km}");
        }
        public void Drive(double FuelFor1Km, double CurrentFuel, double km)
        {
            if (km*FuelFor1Km<=CurrentFuel)
            {
                CurrentFuel = CurrentFuel - (km * FuelFor1Km);
                Console.WriteLine($"The remaining fuel in the tank:{CurrentFuel} ");
            }
            else
            {
                Console.WriteLine("There is not that much fuel");
            }
        }
    }

}
