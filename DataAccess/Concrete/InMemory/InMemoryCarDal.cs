using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ CarId=1,BrandId=1,ColorId=1,ModelYear=2005,DeilyPrice=100000,Description="Açıklama yapıldı 1"},
                new Car{ CarId=2,BrandId=2,ColorId=1,ModelYear=2019,DeilyPrice=250000,Description="Açıklama yapıldı 2"},
                new Car{ CarId=3,BrandId=3,ColorId=5,ModelYear=2022,DeilyPrice=2500000,Description="Açıklama yapıldı 3"},
                new Car{ CarId=4,BrandId=3,ColorId=2,ModelYear=2009,DeilyPrice=175000,Description="Açıklama yapıldı 4"},
                new Car{ CarId=5,BrandId=4,ColorId=3,ModelYear=2013,DeilyPrice=45000,Description="Açıklama yapıldı 5"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.FirstOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DeilyPrice = car.DeilyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
