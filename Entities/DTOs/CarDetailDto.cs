
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs 
{
    //CarName, BrandName, ColorName, DailyPrice.
    public class CarDetailDto:IDto 
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int CarName { get; set; }
        public int BrandName { get; set; }
        public int ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

    }
    
}
