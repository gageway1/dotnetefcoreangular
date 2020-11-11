using LegacyData.Dal.EfStructures;
using LegacyData.Models.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LegacyData.Dal.Repos.Interfaces.Base
{
    //todo remove duplicate code from irepo 
    public interface IRepo<T> : IDisposable where T : EntityBase, new()
    {
        DbSet<T> Table { get; }
        LegacyDataContext Context { get; }
        T Find(int? id);
        T FindAsNoTracking(int id);
        T FindIgnoreQueryFilters(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, object>> orderBy);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, object>> orderBy);
        IEnumerable<T> GetRange(IQueryable<T> query, int skip, int take);
        int Add(T entity, bool persist = true);
        int AddRange(IEnumerable<T> entities, bool persist = true);
        Task<int> AddRangeAsync(IEnumerable<T> entities, bool persist = true);
        int Update(T entity, bool persist = true);
        int UpdateRange(IEnumerable<T> entities, bool persist = true);
        int Delete(T entity, bool persist = true);
        int DeleteRange(IEnumerable<T> entities, bool persist = true);
        int SaveChanges();
        Task<int> SaveChangesAsync();


    }
}
