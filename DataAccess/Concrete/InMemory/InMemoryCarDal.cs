using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Cars> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Cars>
            {
                new Cars{CarId=1,CarBrandId=1,ColorId=1,CarName="Dodge Challenger R/T Plus",ModelYear=2015,DailyPrice=28000,Stock=3,Description="Engine Type = 8-cyl, Gas, 5.7L / Transmission = Manual"},
                new Cars{CarId=2,CarBrandId=1,ColorId=3,CarName="Dodge Challenger SXT",ModelYear=2019,DailyPrice=28000,Stock=5,Description="Engine Type = 6-cyl, Gas, 3.6L / Transmission = Automatic"},
                new Cars{CarId=3,CarBrandId=2,ColorId=4,CarName="Chevrolet Corvette Stingray",ModelYear=2015,DailyPrice=45000,Stock=2,Description="Engine Type = 8-cyl, Gas, 6.2L / Transmission = Automatic"},
                new Cars{CarId=4,CarBrandId=2,ColorId=1,CarName="Chevrolet Camaro LT1 ",ModelYear=2020,DailyPrice=36000,Stock=1,Description="Engine Type = 8-cyl, Gas, 6.2L / Transmission = Automatic"},
                new Cars{CarId=5,CarBrandId=3,ColorId=2,CarName="Ford Mustang GT",ModelYear=2020,DailyPrice=35000,Stock=3,Description="Engine Type = 8-cyl, 5.0L / Transmission = Automatic"},

            };
        }



        public void Add(Cars cars)
        {
            _cars.Add(cars);
        }

        

        public List<Cars> GetAll()
        {
            return _cars;
        }

        public List<Cars> GetAllByCarBrand(int carBrandId)
        {
            return _cars.Where(c => c.CarBrandId == carBrandId).ToList();
        }



        public void Update(Cars cars)
        {
            Cars carsToDelete = _cars.SingleOrDefault(c=>c.CarId==cars.CarId);
            _cars.Remove(carsToDelete);
        }

        public void Delete(Cars cars)
        {
            Cars carsToUpdate = _cars.SingleOrDefault(c => c.CarId == cars.CarId);
            carsToUpdate.CarId = cars.CarId;
            carsToUpdate.CarBrandId = cars.CarBrandId;
            carsToUpdate.ColorId = cars.ColorId;
            carsToUpdate.CarName = cars.CarName;
            carsToUpdate.ModelYear = cars.ModelYear;
            carsToUpdate.DailyPrice = cars.DailyPrice;
            carsToUpdate.Stock = cars.Stock;
            carsToUpdate.Description = cars.Description;
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Cars Get(Expression<Func<Cars, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
