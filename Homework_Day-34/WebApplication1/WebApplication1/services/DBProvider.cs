using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.services
{
    public class DBProvider<T> : IDBProvider<T>
    {

        private List<T> myList { get; set; }

        public DBProvider()
        {
            myList = new List<T>();
        }

        public void Add(T data)
        {
            myList.Add(data);
        }

        public List<T> GetAll()
        {
            return myList;
        }
    }
}
