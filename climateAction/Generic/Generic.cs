using climateAction.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.Generic
{
    public class Generic<T> : IGeneric<T> where T : class
    {
        private readonly context context;
        public Generic(context _context)
        {
            context = _context;
        }
        public void insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }
        public void update(T obj)
        {
            context.Set<T>().Attach(obj);
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            T obj = context.Set<T>().Find(id);
            context.Set<T>().Remove(obj);
            context.SaveChanges();
        }
        public T loadId(int id)
        {
            T obj = context.Set<T>().Find(id);
            return obj;
        }
        public List<T> loadAll()
        {
            List<T> li = context.Set<T>().ToList();
            return li;
        }
    }
}
