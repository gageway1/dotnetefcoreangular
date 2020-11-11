using LegacyData.Dal.EfStructures;
using LegacyData.Models.Models.Base;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LegacyData.Dal.Repos.Interfaces.Base
{
    public abstract class RepoBase<T> : IRepo<T> where T : EntityBase, new()
    {
        protected const int SpeedwayOperatorId = 1;
        private bool _isDisposed;
        public DbSet<T> Table { get; }
        public LegacyDataContext Context { get; }
        private readonly bool _disposeContext;

        protected RepoBase(LegacyDataContext context)
        {
            Context = context;
            Table = Context.Set<T>();
            _disposeContext = false;
        }

        protected RepoBase(DbContextOptions<LegacyDataContext> options) : this(new LegacyDataContext(options))
        {
            _disposeContext = true;
        }

        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed)
            {
                return;
            }

            if (disposing && _disposeContext)
            {
                Context.Dispose();
            }
            _isDisposed = true;
        }

        ~RepoBase()
        {
            Dispose(false);
        }
        public T Find(int? id) => Table.Find(id);

        public T FindAsNoTracking(int id) => Table.Where(x => x.Id == id).AsNoTracking().FirstOrDefault();
        public T FindIgnoreQueryFilters(int id) => Table.IgnoreQueryFilters().FirstOrDefault(x => x.Id == id);
        public virtual IEnumerable<T> GetAll() => Table;

        public virtual async Task<IEnumerable<T>> GetAllAsync() => await Table.ToListAsync();

        public virtual IEnumerable<T> GetAll(Expression<Func<T, object>> orderBy)
            => Table.OrderBy(orderBy);

        public virtual async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, object>> orderBy)
            => await Table.OrderBy(orderBy).ToListAsync();

        public IEnumerable<T> GetRange(IQueryable<T> query, int skip, int take)
            => query.Skip(skip).Take(take);

        public virtual int Add(T entity, bool persist = true)
        {
            Table.Add(entity);
            return persist ? SaveChanges() : 0;
        }

        public virtual int AddRange(IEnumerable<T> entities, bool persist = true)
        {
            Table.AddRange(entities);
            return persist ? SaveChanges() : 0;
        }

        public virtual async Task<int> AddRangeAsync(IEnumerable<T> entities, bool persist = true)
        {
            await Table.AddRangeAsync(entities);
            return persist ? await SaveChangesAsync() : 0;
        }

        public virtual int Update(T entity, bool persist = true)
        {
            Table.Update(entity);
            return persist ? SaveChanges() : 0;
        }

        public virtual int UpdateRange(IEnumerable<T> entities, bool persist = true)
        {
            Table.UpdateRange(entities);
            return persist ? SaveChanges() : 0;
        }

        public virtual int Delete(T entity, bool persist = true)
        {
            Table.Remove(entity);
            return persist ? SaveChanges() : 0;
        }

        public virtual int DeleteRange(IEnumerable<T> entities, bool persist = true)
        {
            Table.RemoveRange(entities);
            return persist ? SaveChanges() : 0;
        }

        public int SaveChanges()
        {
            //TODO Implement exceptions
            try
            {
                return Context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                //A concurrency error occurred
                //Should log and handle intelligently
                //throw new MySpeedwayConcurrencyException("A concurrency error happened.", ex);
                throw new NotImplementedException();
            }
            catch (RetryLimitExceededException ex)
            {
                //DbResiliency retry limit exceeded
                //Should log and handle intelligently
                //throw new MySpeedwayRetryLimitException("There is a problem with you connection.", ex);
                throw new NotImplementedException();

            }
            catch (DbUpdateException ex)
            {
                //Should log and handle intelligently
                if (ex.InnerException is SqlException sqlException)
                {
                    if (sqlException.Message.Contains("FOREIGN KEY constraint", StringComparison.OrdinalIgnoreCase))
                    {
                        // throw thing
                    }
                }

                //throw new MySpeedwayException("An error occurred updating the database", ex);
                throw new NotImplementedException();

            }
            catch (Exception ex)
            {
                throw new NotImplementedException();

            }
        }

        public async Task<int> SaveChangesAsync()
        {
            //try
            //{
            //    return await Context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException ex)
            //{
            //    //A concurrency error occurred
            //    //Should log and handle intelligently
            //    //TODO Implement exceptions
            //    //throw new MySpeedwayConcurrencyException("A concurrency error happened.", ex);
            //}
            //catch (RetryLimitExceededException ex)
            //{
            //    //DbResiliency retry limit exceeded
            //    //Should log and handle intelligently
            //    throw new MySpeedwayRetryLimitException("There is a problem with you connection.", ex);
            //}
            //catch (DbUpdateException ex)
            //{
            //    //Should log and handle intelligently
            //    if (ex.InnerException is SqlException sqlException)
            //    {
            //        if (sqlException.Message.Contains("FOREIGN KEY constraint", StringComparison.OrdinalIgnoreCase))
            //        {
            //            //Todo
            //        }
            //    }

            //    throw new MySpeedwayException("An error occurred updating the database", ex);
            //}
            //catch (Exception ex)
            //{
            //    //Should log and handle intelligently
            //    throw new MySpeedwayException("An error occurred updating the database", ex);
            //}
            throw new NotImplementedException();
        }
    }
}
