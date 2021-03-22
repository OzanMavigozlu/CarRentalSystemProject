using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarBrandManager : ICarBrandService
    {
        ICarBrandDal _carBrandDal;
        public CarBrandManager(ICarBrandDal carBrandDal)
        {
            _carBrandDal = carBrandDal;
        }


        public List<CarBrand> GetAll()
        {
            return _carBrandDal.GetAll();
        }

        public void Add(CarBrand carBrand)
        {
            _carBrandDal.Add(carBrand);
        }

        public void Delete(CarBrand carBrand)
        {
            _carBrandDal.Delete(carBrand);
        }

        

        public void Update(CarBrand carBrand)
        {
            _carBrandDal.Update(carBrand);
        }
    }
}
