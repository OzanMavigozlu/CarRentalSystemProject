using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI1
{
    class Program
    {
        public static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());


            foreach (var c in carManager.GetAll())
            {

                Console.WriteLine("Araba Adı : " + c.CarName +" | "+ "Günlük Kiralma Fiyatı : " + c.DailyPrice);
            }

            //carManager.Add(new Cars { CarId = 11, CarBrandId = 7, ColorId = 5, ModelYear = 1959, DailyPrice = 100, Description = "xd", CarName = "Ford", Stock = 4 });

        }
    }
}
