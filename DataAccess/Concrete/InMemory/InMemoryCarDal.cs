using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    // GetById, GetAll, Add, Update, Delete 
    public class InMemoryCarDal : ICarDal
    {   
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id=1, BrandId=5, ColorId=19, ModelYear="2003", DailyPrice=5500, Description="araba1" },
                new Car{ Id=2, BrandId=5, ColorId=18, ModelYear="2007", DailyPrice=5600, Description="araba2" },
                new Car{ Id=3, BrandId=8, ColorId=15, ModelYear="2006", DailyPrice=5800, Description="araba22" },
                new Car{ Id=4, BrandId=9, ColorId=12, ModelYear="2005", DailyPrice=5900, Description="araba3"},
                new Car{ Id=5, BrandId=10, ColorId=22, ModelYear="2002", DailyPrice=8000, Description="araba5" }
            };
        }
    
    
   
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }
        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
