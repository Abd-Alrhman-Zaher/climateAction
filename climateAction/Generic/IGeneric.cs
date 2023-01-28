using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.Generic
{
    public interface IGeneric<T> where T : class
    {
        void insert(T obj);
        void update(T obj);
        void Delete(int id);
        T loadId(int id);
        List<T> loadAll();
    }
}
