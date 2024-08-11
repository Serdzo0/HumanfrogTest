using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HFT.DataAccess.Data;
using HFT.DataAccess.Repository.IRepository;
namespace HFT.DataAccess.Repository
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly ApplicationDbContext _db;
		internal DbSet<T> Set;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
			this.Set = _db.Set<T>();
        }
        public void Add(T entity)
		{
			Set.Add(entity);
		}

		public void Delete(T entity)
		{
			Set.Remove(entity);
		}

		public void DeleteRange(IEnumerable<T> entities)
		{
			Set.RemoveRange(entities);
		}

		public IEnumerable<T> GetAll()
		{
			IQueryable<T> query = Set;
			return query.ToList();
		}

		public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
		{
			IQueryable<T> query = Set;
			query = query.Where(filter);
			return query.FirstOrDefault();
		}
	}
}
