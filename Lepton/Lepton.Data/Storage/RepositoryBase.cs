using Lepton.Data.Infrastructure;
using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Lepton.Data.Storage
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : TableEntity, new()
    {
        protected SemaphoreSlim TableLock { get; set; } = new SemaphoreSlim(1, 1);

        protected readonly CloudStorageAccount _account;
        protected CloudTableClient TableClient => _account.CreateCloudTableClient();

        public RepositoryBase(StorageSettings settings)
        {
            settings ??= StorageSettings.DefaultSettings;
            _account = CloudStorageAccount.Parse(settings.ConnectionString);
        }

        protected async Task<CloudTable> GetTableReference(CancellationToken cancellationToken)
        {
            var table = TableClient.GetTableReference(typeof(T).Name);
            await table.CreateIfNotExistsAsync(cancellationToken);
            return table;
        }

        public async Task<T> Get(string entityId, CancellationToken cancellationToken)
        {
            var table = await GetTableReference(cancellationToken);
            var query = table.CreateQuery<T>().FirstOrDefault(e => e.RowKey == entityId);
            return query;
        }

        public async Task<bool> Upsert(T entity, CancellationToken cancellationToken)
        {
            var table = await GetTableReference(cancellationToken);

            await TableLock.WaitAsync();

            try
            {
                cancellationToken.ThrowIfCancellationRequested();

                var result = await table.ExecuteAsync(TableOperation.InsertOrMerge(entity), cancellationToken);

                cancellationToken.ThrowIfCancellationRequested();

                return true;
            }
            catch (OperationCanceledException)
            {
                return false;
            }
            finally
            {
                TableLock.Release();
            }
        }

        public async Task<bool> Delete(T entity, CancellationToken cancellationToken)
        {
            var table = await GetTableReference(cancellationToken);

            await TableLock.WaitAsync();

            try
            {
                cancellationToken.ThrowIfCancellationRequested();

                var result = await table.ExecuteAsync(TableOperation.Delete(entity), cancellationToken);

                cancellationToken.ThrowIfCancellationRequested();

                return true;
            }
            catch (OperationCanceledException)
            {
                return false;
            }
            finally
            {
                TableLock.Release();
            }
        }

        public async Task<IEnumerable<T>> List(CancellationToken cancellationToken)
        {
            try
            {
                var query = new TableQuery<T>();
                var items = EnumerateEntitiesAsync(query, cancellationToken);
                var list = new List<T>();
                await foreach (var item in items)
                {
                    list.Add(item);
                }

                return list;
            }
            catch (OperationCanceledException)
            {
                return null;
            }
        }

        public async Task<IEnumerable<T>> List(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
        {
            try
            {
                var query = new TableQuery<T>().Where(expression) as TableQuery<T>;
                var items = EnumerateEntitiesAsync(query, cancellationToken);
                var list = new List<T>();
                await foreach (var item in items)
                {
                    list.Add(item);
                }

                return list;
            }
            catch (OperationCanceledException)
            {
                return null;
            }
        }

        private async IAsyncEnumerable<T> EnumerateEntitiesAsync(TableQuery<T> query, [EnumeratorCancellation] CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var table = await GetTableReference(cancellationToken);

            TableContinuationToken token = null;

            do
            {
                var result = await table.ExecuteQuerySegmentedAsync(query, token, cancellationToken);

                foreach (T entity in result.Results)
                {
                    yield return entity;
                }

                token = result.ContinuationToken;
                cancellationToken.ThrowIfCancellationRequested();
            } while (token != null);
        }
    }
}
