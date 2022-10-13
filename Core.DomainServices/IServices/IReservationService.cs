using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModels;

namespace Core.DomainServices.IServices
{
    public interface IReservationService
    {
        bool CreateReservation(
            Student student,
            FoodPackage foodPackage
        );
    }
}
