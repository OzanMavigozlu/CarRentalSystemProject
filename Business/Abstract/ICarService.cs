using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Cars car);
        void Delete(Cars car);
        void Update(Cars car);
        List<Cars> GetAll();
    }
}
