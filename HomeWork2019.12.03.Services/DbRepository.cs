using HomeWork2019._12._03.AbstractModels;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HomeWork2019._12._03.Services
{
    public class DbRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet _dbSet;
        public DbRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public void Delete(T item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _dbSet.Find(id);
            _dbSet.Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<T> Get()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T item)
        {
            _dbSet.Remove(item);
            _dbSet.Add(item);
            _context.SaveChanges();
        }
    }
}
