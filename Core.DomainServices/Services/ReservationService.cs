using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModels;
using Core.DomainServices.IRepos;
using Core.DomainServices.IServices;

namespace Core.DomainServices.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IFoodPackageRepo _foodPackageRepository;
        public bool CreateReservation(Student student, FoodPackage foodPackage)
        {
            if (foodPackage.Category.ContainsAlcohol == true)
            {
                if (!StudentIsAllowedToBuyAlcohol(student)) throw new ArgumentException("ValidateBirthDate: Student must be 18 year or older to buy alcohol.");
            }
            if (!FoodPackageIsNotReserved(foodPackage)) throw new ArgumentException("Package is already reserved.");
            if (!StudentHasNoReservationOnSameDate(student.Id, foodPackage.PickUpDate)) throw new ArgumentException("You can only reserve one pickup for a package per day.");

            foodPackage.ReservedBy = student;

            return true;
        }
        private static bool StudentIsAllowedToBuyAlcohol(Student student)
        {
            var today = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (student.BirthDate > today || student.BirthDate >= today.AddYears(-18))
            {
                throw new ArgumentException("ValidateBirthDate: Student must be 18 year or older to buy alcohol.");
            }
            return true;
        }

        private static bool FoodPackageIsNotReserved(FoodPackage foodPackage)
        {
            return foodPackage.ReservedBy is null;
        }

        private bool StudentHasNoReservationOnSameDate(int studentId, DateOnly foodPackageDate)
        {
            var foodPackagesStudent = _foodPackageRepository.GetAllFoodPackagesFromStudent(studentId).Result;
            foreach (var foodPackageStudent in foodPackagesStudent)
            {
                if (foodPackageStudent.PickUpDate == foodPackageDate)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
