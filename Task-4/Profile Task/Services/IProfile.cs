using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task4.Services
{
    public interface IProfile<T>
    { 
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T t);
    }
}
    
