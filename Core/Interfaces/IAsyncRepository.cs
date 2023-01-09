using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IAsyncRepository<T> where T: BaseEntity
    {
        Task<IReadOnlyList<T>> ListAllAsync();

        Task<IReadOnlyList<T>> ListByPeriodAsync(int year, int month);

        Task UpdateAllAsync(List<T> entities);
        Task AddAllAsync(List<T> entities);
    }
}
