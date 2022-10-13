using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices.IRepos
{
    public interface IRepo<T> where T : class
    {
        // Index
        Task<IQueryable<T>> GetAllAsync();
        // Create
        Task<bool> CreateEntityAsync(T entity);
        // Read
        Task<T> GetByIdAsync(int id);
        // Update
        Task<bool> UpdateByIdAsync(T entity);
        // Delete
        Task<bool> DeleteByIdAsync(int id);
    }
}
