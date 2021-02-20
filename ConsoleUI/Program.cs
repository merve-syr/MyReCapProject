using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCar());
            foreach (var car in carManager.GetAll())
            {
              
                Console.WriteLine(car.ColorId);
            }

        }
    }
}
