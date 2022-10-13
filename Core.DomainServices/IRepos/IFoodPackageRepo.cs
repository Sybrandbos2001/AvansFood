using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModels;

namespace Core.DomainServices.IRepos
{
    public interface IFoodPackageRepo : IRepo<FoodPackage>
    {
        Task<bool> AddProductAsync(Product product);
        Task<bool> DeleteProductAsync(int productId);
        Task<IQueryable<FoodPackage>> GetAllFoodPackagesFromStudent(int studentId);
    }
}
