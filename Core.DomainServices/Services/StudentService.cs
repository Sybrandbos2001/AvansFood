using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModels;
using Core.DomainServices.IServices;

namespace Core.DomainServices.Services
{
    internal class StudentService : IStudentService
    {
        public Student CreateNewStudent(string firstName, string lastName, DateOnly birthDate, string studentNumber, string emailAddress, CityEnum cityOfStudy, string phoneNumber)
        {
            if (!ValidateBirthDate(birthDate)) throw new ArgumentException();
            var newStudent = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                StudentNumber = studentNumber,
                EmailAddress = emailAddress,
                CityOfStudy = cityOfStudy,
                PhoneNumber = phoneNumber
            };
            return newStudent;
        }

        private static bool ValidateBirthDate(DateOnly date)
        {
            var today = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (date > today || date >= today.AddYears(-16))
            {
                throw new ArgumentException("ValidateBirthDate: Student should be 16 year or older.");
            }
            return true;
        }
    }
}
