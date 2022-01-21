using System.Collections.Generic;

namespace WebApplication1.services
{
    public interface IDBProvider<T>
    {
        void Add(T data);
        List<T> GetAll();
    }
}