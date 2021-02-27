using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Veritabanı işlemleri buraya yazılacak.
    public interface ICarDal
    {
        List<Car> GetAll();    //Tüm ürünleri listeleme
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetById(int Id);
    }
}
