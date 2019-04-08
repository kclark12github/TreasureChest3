using SharedKernel;
using SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SharedKernel.Data.ReusableGenericRepository
{
    public class DisconnectedGenericRepository<TEntity> where TEntity : class, IEntity
    {
        internal DbContext _context;
        internal DbSet<TEntity> _dbSet;
        public DisconnectedGenericRepository(DbContext context) {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public IEnumerable<TEntity> All() {
            return _dbSet.AsNoTracking().ToList();
        }
        public IEnumerable<TEntity> AllInclude(params Expression<Func<TEntity, object>>[] includeProperties) {
            return GetAllIncluding(includeProperties).ToList();
        }
        public IEnumerable<TEntity> FindByInclude(Expression<Func<TEntity, bool>> predicate,
                params Expression<Func<TEntity, object>>[] includeProperties) {
            var query = GetAllIncluding(includeProperties);
            IEnumerable<TEntity> results = query.Where(predicate).ToList();
            return results;
        }
        private IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties) {
            IQueryable<TEntity> queryable = _dbSet.AsNoTracking();
            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }
        public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate) {
            IEnumerable<TEntity> results = _dbSet.AsNoTracking()
                .Where(predicate).ToList();
            return results;
        }
        public TEntity FindByKey(int id) {
            //Notes:
            //  This repository is intended for disconnected use, so our context will be discarded with each atomic 
            //  operation. The DbSet.Find method would search the set for cached data before going to the database,
            //  but since we're operating on a disconnected basis, that cache would be empty. Note that the Find method 
            //  is on the DbSet itself, and not available with AsNoTracking(), so using it here would cause our data to be
            //  cached, even though (disconnected as we are) it would only be discarded when the context goes out of scope.
            //  The Find method does handle determining which key to be used in finding the data we're looking for, and that
            //  may be worth the performance hits (minor as they may be) of these other issues.
            //return _dbSet.Find(id);   

            //After defining IEntity to enforce our TEntity types will always have an Id property (assumed to be the 
            //primary key as a best practice), we can now use .AsNoTracking to do our Find...
            //However, if not all our TEntity types implement the IEntity interface, this solution won't work...
            return _dbSet.AsNoTracking().SingleOrDefault(e=>e.ID==id);
            
            //The BuildLambdaForFindByKey, as the name implies, builds a new lambda expression based on a <TEntity>Id
            //naming convention rather than a hard-coded Id property...
            //Expression<Func<TEntity, bool>> lambda = Utilities.BuildLambdaForFindByKey<TEntity>(id);
            //return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        }
        public void Insert(TEntity entity) {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void Update(TEntity entity) {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = FindByKey(id);
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
}
