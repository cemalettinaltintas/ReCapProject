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
            //UserTest();
            //CustomerTest();
            //CarTest();
            //BrandTest();
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
           //userManager.Add(new User {FirstName = "Emre", LastName = "Altıntaş", Email = "emre@gmail.com", Password = "123" });
            var result = userManager.GetAll();
            foreach (var user in result.Data)
            {
                Console.WriteLine(user.Id + " / " + user.FirstName + " / " + user.LastName + " / " + user.Email);
            }

        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //customerManager.Add(new Customer { UserId = 1, CompanyName = "Altıntaşlar AŞ" });
            var silinecek = customerManager.GetById(1).Data;
            customerManager.Delete(silinecek);
            var result = customerManager.GetAll();
            //if (result.Success)
            //{
            //    foreach (var customer in result.Data)
            //    {
            //        Console.WriteLine(customer.Id + " - " + customer.UserId + " - " + customer.CompanyName);
            //    }
            //}
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { Name = "Tofas" });
            //brandManager.Delete(brandManager.GetById(6));
            foreach (var brand in brandManager.GetAll().Data)
            {
                if (brand.Id == 6)
                {
                    brand.Name = "Toyota";
                }

                Console.WriteLine(brand.Id + " - " + brand.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "-" + car.ColorName + "-" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
