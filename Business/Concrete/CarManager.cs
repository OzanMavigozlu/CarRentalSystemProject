using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public List<Cars> GetAll()
        {
            return _carDal.GetAll();
        }


        public void Add(Cars car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 500)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Arabanin ismi 2 karakterden fazla olmalı ve arabanın günlük kirası 500'den büyük olmalı");
            }
        }

        public void Delete(Cars car)
        {
            _carDal.Delete(car);
        }

        public void Update(Cars car)
        {
            _carDal.Update(car);
        }


        public List<Cars> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Cars> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.CarBrandId == id);
        }

    }
}
