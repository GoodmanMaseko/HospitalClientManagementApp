using HospitalClientManagementAPIService.DataService.Interfaces.Reposotory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClientManagementAPIService.DataService.Persistance.Repository
{
    public class Repository<TEntity>: IRepository<TEntity> where TEntity : class
    {
        protected static HospitalClientManagement_db _hospitalClientManagement_db;
        public Repository(HospitalClientManagement_db db_context)
        {
            _hospitalClientManagement_db = db_context;
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _hospitalClientManagement_db.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return _hospitalClientManagement_db.Set<TEntity>().Where(predicate);
        }

        public void Add(TEntity entity)
        {
            _hospitalClientManagement_db.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _hospitalClientManagement_db.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            _hospitalClientManagement_db.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _hospitalClientManagement_db.Set<TEntity>().RemoveRange(entities);
        }

        public Task<TEntity> GetAsync<T>(T Id)
        {
            return _hospitalClientManagement_db.Set<TEntity>().FindAsync(Id);
        }
    }
}
