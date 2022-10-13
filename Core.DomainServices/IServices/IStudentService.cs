using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModels;

namespace Core.DomainServices.IServices
{
    public interface IStudentService
    {
        Student CreateNewStudent(
            string firstName,
            string lastName,
            DateOnly birthDate,
            string studentNumber,
            string emailAddress,
            CityEnum cityOfStudy,
            string phoneNumber
        );
    }
}
