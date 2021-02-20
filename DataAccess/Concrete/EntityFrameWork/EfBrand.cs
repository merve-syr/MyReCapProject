
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfBrand : ICarDal
    {
        public void Add(Entities.Concrete.Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entities.Concrete.Car entity)
        {
            throw new NotImplementedException();
        }

        public Entities.Concrete.Car Get(Expression<Func<Entities.Concrete.Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Concrete.Car> GetAll(Expression<Func<Entities.Concrete.Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Entities.Concrete.Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
