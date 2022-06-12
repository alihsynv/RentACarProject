using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarDetailTest();
            //RentalTest();

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Add(new Rental()
            {
                CarId = 1,
                CustomerId = 1,
                ReturnDate = DateTime.Now,
            });
            Console.WriteLine(result.Message);

            foreach (var item in rentalManager.GetAll().Data)
            {
                Console.WriteLine(item.CarId);
            }
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.Name + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            }
        }
    }
}
