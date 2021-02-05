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
            _cars = new List<Car> {
                new Car{Id = 1, BrandId=21, ColorId=31,  ModelYear=2012, DailyPrice = 58, Description = "AUDİ"},
                new Car{Id = 2, BrandId=22, ColorId=32,  ModelYear=2020, DailyPrice = 75, Description = "RANGE ROVER"},
                new Car{Id = 3, BrandId=23, ColorId=33,  ModelYear=2019, DailyPrice = 54, Description = "MERCEDES"},
                new Car{Id = 4, BrandId=24, ColorId=34,  ModelYear=2018, DailyPrice = 556, Description = "FİAT"},
                new Car{Id = 5, BrandId=25, ColorId=35,  ModelYear=2016, DailyPrice = 896, Description = "WOLKSVAGEN"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }




        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;

        }
    }
}
