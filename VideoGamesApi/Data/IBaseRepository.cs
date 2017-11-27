using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGamesApi.Data
{
    interface IBaseRepository<T>
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Add(T item);
        void Delete(int id);
        void Update(int id, T item);
    }
}
