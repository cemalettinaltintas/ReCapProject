using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //Car car1 = new Car();
            //car1.BrandId = 5;
            //car1.ColorId = 3;
            //car1.DailyPrice = 112;
            //car1.Descriptions = "Renault Fluence Business";
            //car1.ModelYear = 2011;
            //carManager.Add(car1);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Descriptions);
            }
        }
    }
}
