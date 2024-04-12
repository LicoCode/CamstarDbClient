using CamstarDbClient.CamstarEntities;
using CamstarDbClient.Context;
using CamstarDbClient.CamstarEntities;
using Microsoft.EntityFrameworkCore;

namespace CamstarDbClient
{
    /// <summary>
    /// 访问Camstar数据库的客户端
    /// </summary>
    public class DbClient : IDisposable
    {
        public CamstarDbContext context;
        public DbClient() {
            context = new CamstarDbContext();
        }

        public IQueryable<TEntity> SqlQuery<TEntity>(string sql, object param) where TEntity : class
        {
            return context.Set<TEntity>().FromSqlRaw(sql, param);
        }

        public void Dispose()
        {
            ((IDisposable)context).Dispose();
        }

        public T? GetNDOByName<T>(string name) where T : NamedDataObject
        {
            var namedObjects = context.Set<T>().Where(e => e.Name == name);
            if (namedObjects != null)
            {
                return namedObjects.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        public T? GetRDOByName<T>(string name, string revision) where T : RevisionedObject
        {
            var revisionedObjects = context.Set<T>().Where(e => e.Base.Name == name && e.Revision == revision);
            if (revisionedObjects != null)
            {
                return revisionedObjects.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        public T? GetContainerByName<T>(string name) where T : Container
        {
            var containers = context.Set<T>().Where(e => e.Name == name);
            if (containers != null)
            {
                return containers.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }
    }
}
