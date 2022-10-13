using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModels;
using Core.DomainServices.IServices;

namespace Core.DomainServices.Services
{
    public class FoodPackageService : IFoodPackageService
    {
        public FoodPackage CreateNewFoodPackage(DateOnly pickUpDate, TimeOnly pickUpTime, double price, MealTypeEnum typeOfMeal, Canteen canteen, Student reservedBy, FoodPackageCategory category)
        {
            if (!ValidatePackagePickupDate(pickUpDate)) throw new ArgumentException("ValidatePackagePickupDate: Pickup date package should not be in the past or more then 2 days in the future.");
            var newFoodPackage = new FoodPackage
            {
                PickUpDate = pickUpDate,
                PickUpTime = pickUpTime,
                Price = price,
                TypeOfMeal = typeOfMeal,
                Canteen = canteen,
                ReservedBy = reservedBy,
                Category = category
            };
            return newFoodPackage;
        }
        public bool ValidatePackagePickupDate(DateOnly date)
        {
            DateOnly today = new(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            return date <= today.AddDays(+2) && date >= today;
        }
    }
}
