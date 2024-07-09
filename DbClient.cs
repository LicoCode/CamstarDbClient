using CamstarDb.Entities;
using CamstarDb.Context;
using Microsoft.EntityFrameworkCore;

namespace CamstarDb
{
    public class DbClient : IDisposable
    {
        public CamstarDbContext context;

        public DbClient()
        {
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

        public T? GetNameSubentityByName<T>(string name) where T : NamedSubentity
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

        public List<T>? GetNameSubentitiesByName<T>(List<string> names) where T : NamedSubentity
        {
            var namedSubentitys = context.Set<T>().Where(e => names.Contains(e.Name));
            if (namedSubentitys != null)
            {
                return namedSubentitys.ToList();
            }
            else
            {
                return null;
            }
        }


        public List<T>? GetNDOList<T>() where T : NamedDataObject
        {
            return context.Set<T>().ToList();

        }

        public List<T>? GetRDOList<T>() where T : RevisionedObject
        {
            return context.Set<T>().ToList();

        }

        public T? GetRDOByNameVersion<T>(string name, string revision) where T : RevisionedObject
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

        public T? GetRDOByName<T>(string name) where T : RevisionedObject
        {
            var revisionedObjects = context.Set<T>().Where(e => e.Base.Name == name);
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

        /// <summary>
        /// 查询批次
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Container? GetContainerByNameAndSerialNumber(string containerName)
        {
            var containers = context.Containers.Where(p => p.Name == containerName || p.ES_PrimarySerialNumber == containerName || p.ES_SerialNumber2 == containerName || p.ES_SerialNumber3 == containerName);
            if (containers != null)
            {
                return containers.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 查询批次
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Container? GetContainerByES_PrimarySerialNumber(string name)
        {
            var containers = context.Containers.Where(e => e.ES_PrimarySerialNumber == name);
            if (containers != null)
            {
                return containers.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 查询批次
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Container? GetContainerByES_SerialNumber2(string name)
        {
            var containers = context.Containers.Where(e => e.ES_SerialNumber2 == name);
            if (containers != null)
            {
                return containers.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 查询批次
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Container? GetContainerByES_SerialNumber3(string name)
        {
            var containers = context.Containers.Where(e => e.ES_SerialNumber3 == name);
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
