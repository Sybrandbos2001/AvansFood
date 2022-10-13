using Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices.IServices
{
    public interface IFoodPackageService
    {
        FoodPackage CreateNewFoodPackage(
         DateOnly PickUpDate,
         TimeOnly PickUpTime,
         double Price,
         MealTypeEnum TypeOfMeal, 
         Canteen Canteen, 
         Student ReservedBy, 
         FoodPackageCategory Category
        ); 
    }
}
