using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Cars:IEntity
    {
         [Key]
        public int CarId { get; set; }
        public int CarBrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
        public string CarName { get; set; }
        public int Stock { get; set; }
    }
}
