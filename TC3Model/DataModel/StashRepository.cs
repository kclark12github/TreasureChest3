using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using TC3Model.DataModel.Classes;
using TC3Model.Interfaces;

namespace TC3Model.DataModel
{
    public class StashRepository<TStash> where TStash : class, IDataEntity, IStash
    {
        internal TCContext _context;
        internal DbSet<TStash> _dbSet;
        internal DbSet<Image> Images;
        public StashRepository() {
            _context = new TCContext();
            InitContextStuff();
        }
        public StashRepository(TCContext context)
        {
            _context = context;
            InitContextStuff();
        }
        private void InitContextStuff()
        {
            _dbSet = _context.Set<TStash>();
            Images = _context.Set<Image>();
        }
        public IEnumerable<TStash> All() {
            return _dbSet.AsNoTracking().ToList();
        }
        public IEnumerable<TStash> AllInclude(params Expression<Func<TStash, object>>[] includeProperties) {
            return GetAllIncluding(includeProperties).ToList();
        }
        public IEnumerable<TStash> FindByInclude(Expression<Func<TStash, bool>> predicate,
                params Expression<Func<TStash, object>>[] includeProperties) {
            var query = GetAllIncluding(includeProperties);
            IEnumerable<TStash> results = query.Where(predicate).ToList();
            return results;
        }
        private IQueryable<TStash> GetAllIncluding(params Expression<Func<TStash, object>>[] includeProperties) {
            IQueryable<TStash> queryable = _dbSet.AsNoTracking();
            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }
        public IEnumerable<TStash> FindBy(Expression<Func<TStash, bool>> predicate) {
            IEnumerable<TStash> results = _dbSet.AsNoTracking()
                .Where(predicate).ToList();
            return results;
        }
        public TStash FindByKey(int id) {
            //Notes:
            //  This repository is intended for disconnected use, so our context will be discarded with each atomic 
            //  operation. The DbSet.Find method would search the set for cached data before going to the database,
            //  but since we're operating on a disconnected basis, that cache would be empty. Note that the Find method 
            //  is on the DbSet itself, and not available with AsNoTracking(), so using it here would cause our data to be
            //  cached, even though (disconnected as we are) it would only be discarded when the context goes out of scope.
            //  The Find method does handle determining which key to be used in finding the data we're looking for, and that
            //  may be worth the performance hits (minor as they may be) of these other issues.
            //return _dbSet.Find(id);   

            //After defining IEntity to enforce our TStash types will always have an Id property (assumed to be the 
            //primary key as a best practice), we can now use .AsNoTracking to do our Find...
            //However, if not all our TStash types implement the IEntity interface, this solution won't work...
            return _dbSet.AsNoTracking()
                .Include(e => e.Location)   //Eager Loading
                .SingleOrDefault(e => e.ID == id);
            
            //The BuildLambdaForFindByKey, as the name implies, builds a new lambda expression based on a <TStash>Id
            //naming convention rather than a hard-coded Id property...
            //Expression<Func<TStash, bool>> lambda = Utilities.BuildLambdaForFindByKey<TStash>(id);
            //return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        }
        public TStash FindByKeyWithImages(int id)
        {
            TStash stash = _dbSet.Include(s => s.Location)   //Eager Loading
                .SingleOrDefault(s => s.ID == id);
            //stash.Images = GetImages(stash);
            return stash;
        }
        public List<Image> GetImages(TStash stash)
        {
            string TableName = _context.TypeToTableName(stash.GetType().BaseType.Name);
            return Images.Where(s => s.TableName == TableName && s.RecordID == stash.ID).ToList();
        }
        public void InsertDisconnected(TStash entity) {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void UpdateDisconnected(TStash entity) {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteDisconnected(int id)
        {
            var entity = FindByKey(id);
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
}
