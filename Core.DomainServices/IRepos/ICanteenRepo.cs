using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModels;

namespace Core.DomainServices.IRepos
{
    public interface ICanteenRepo : IRepo<Canteen>
    {
        Task<bool> AddPackageAsync(FoodPackage package);
        Task<bool> DeletePackageAsync(FoodPackage package);
        Task<bool> AddCanteenEmployeeAsync(CanteenEmployee employee);
        Task<bool> DeleteCanteenEmployeeAsync(CanteenEmployee employee);
    }
}
