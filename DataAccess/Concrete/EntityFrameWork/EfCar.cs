using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCar : ICarDal
    {
        public void Add(Entities.Concrete.Car entity)
        {

            using (NorthWindContext context = new NorthWindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
            
        
        }

        public void Delete(Entities.Concrete.Car entity)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Entities.Concrete.Car Get(Expression<Func<Car, bool>> filter)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);

            }
        }

        public List<Entities.Concrete.Car> GetAll(Expression<Func<Entities.Concrete.Car, bool>> filter = null)
        {
            using (NorthWindContext context=new NorthWindContext())
            {
                return filter == null 
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();

            }
        }

        public void Update(Entities.Concrete.Car entity)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
