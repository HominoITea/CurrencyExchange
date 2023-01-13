using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICommandData<T> where T : BaseEntity
    {
        Task UpdateAllAsync(List<T> entities);
        Task AddAllAsync(List<T> entities);
    }
}
