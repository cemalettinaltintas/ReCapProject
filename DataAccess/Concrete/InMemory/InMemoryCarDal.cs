using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
             _cars= new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=200,Descriptions="Beyaz Fluence",ModelYear=2011},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=210,Descriptions="Siyah Fluence",ModelYear=2012},
                new Car{Id=3,BrandId=2,ColorId=1,DailyPrice=250,Descriptions="Beyaz Opel",ModelYear=2016},
                new Car{Id=4,BrandId=2,ColorId=2,DailyPrice=300,Descriptions="Siyah Opel Astra",ModelYear=2020},
                new Car{Id=5,BrandId=2,ColorId=2,DailyPrice=220,Descriptions="Opel Corsa",ModelYear=2018},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
