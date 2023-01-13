using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IQueryData<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> ListAllAsync();

        Task<IList<T>> ListByPeriodAsync(int year, int month);
    }
}
