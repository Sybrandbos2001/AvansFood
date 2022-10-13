using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainModels
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ContainsAlcohol { get; set; }
        public List<FoodPackageCategory> FoodPackageCategories { get; set; } = new List<FoodPackageCategory>();
    }
}
