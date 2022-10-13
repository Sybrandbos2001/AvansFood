using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainModels
{
    public class Canteen
    {
        [Key]
        public int Id { get; set; }
        public CityEnum City { get; set; }
        public LocationEnum Location { get; set; }
        public bool HotMeals { get; set; }
    }
}
