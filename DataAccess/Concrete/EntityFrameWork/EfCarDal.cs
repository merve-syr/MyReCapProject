using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
           
                using (NorthwindContext context = new NorthwindContext())
                {
                    var result = from p in context.Cars
                                 join c in context.Colors
                                 on p.ColorId equals c.ColorId
                                 select new CarDetailDto
                                 {
                                     Id = p.Id,
                                     ColorId = p.ColorId,
                                     Description = p.Description,
                                     DailyPrice = p.DailyPrice
                                 };
                    return result.ToList();
                }
           
        }
    }
}
