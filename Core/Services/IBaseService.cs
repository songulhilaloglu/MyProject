using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IBaseService<TModel> : IDisposable where TModel : BaseEntity
    {
        IQueryable<TModel> Query();

        Task AddAsync (TModel model);
        Task DeleteAsync (TModel model);
        Task UpdateAsync(TModel model);

    }
}
