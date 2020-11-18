using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyWeb.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync(string url, int id);
        Task<IEnumerable<T>> GetAllAsync(string url);
        Task<bool> CreateAsync(String url, T objCreate);
        Task<bool> UpdateAsync(String url, T objUpdate);
        Task<bool> DeleteAsync(String url, int Id);

    }
}
