using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainModels
{
    public class FoodPackage
    {
        [Key]
        public int Id { get; set; }
        public DateOnly PickUpDate { get; set; }
        public TimeOnly PickUpTime { get; set; }
        public double Price { get; set; }
        public MealTypeEnum TypeOfMeal { get; set; }
        public Canteen Canteen { get; set; }
        public Student ReservedBy { get; set; }
        public FoodPackageCategory Category { get; set; }
    }
}
