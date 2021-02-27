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
        List<Car> _car; //Global değişken _ ile verilir
        public InMemoryCarDal()  //Constructor ctor
        {
            _car = new List<Car> {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=100, Description="1.Model", ModelYear=1995},
                new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=200, Description="2.Model", ModelYear=2000},
                new Car{Id=3, BrandId=3, ColorId=3, DailyPrice=300, Description="3.Model", ModelYear=2005},
                new Car{Id=4, BrandId=3, ColorId=3, DailyPrice=400, Description="4.Model", ModelYear=2010},
                new Car{Id=5, BrandId=4, ColorId=4, DailyPrice=500, Description="5.Model", ModelYear=2015}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
