using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Lepton.Data.Storage
{
    public interface IRepository<T> where T : TableEntity
    {
        Task<IEnumerable<T>> List(CancellationToken cancellationToken);
        Task<IEnumerable<T>> List(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);
        Task<bool> Upsert(T entity, CancellationToken cancellationToken);
        Task<bool> Delete(T entity, CancellationToken cancellationToken);
        Task<T> Get(string entityId, CancellationToken cancellationToken);
    }
}
