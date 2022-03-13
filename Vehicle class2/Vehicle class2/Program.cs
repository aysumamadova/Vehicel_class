using System;
using Vehicle_class2.Models;

namespace Vehicle_class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car = new Car("BMW","X5",2022,100,0.2);
            Car.ShowInfo();
            Car.Drive(0.1, 55, 100);
        }
    }
}
