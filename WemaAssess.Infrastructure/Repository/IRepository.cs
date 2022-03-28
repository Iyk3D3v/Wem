using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WemaAssess.Infrastructure.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        Task<bool> AddAsync(T t);

        Task<IEnumerable<T>> GetAllAsync();

        Task<List<T>> GetByAsync(Expression<Func<T, bool>> predicate);
    }
}
