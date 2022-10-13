using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainModels
{
    public class FoodPackageCategory
    {
        [Key]
        public int Id { get; set; }
        public string  Name { get; set; }
        public List<Product> ProductList { get; set; } = new List<Product>();
        public bool ContainsAlcohol { get; set; }
    }
}
