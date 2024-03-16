using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Application.Common.Interfaces.Services.Base
{
    public interface IBaseService<T>
    {
        T Add(T entity);
        T Update(T entity);
        void Remove(T entity);
        T? GetById(Guid Id);
        string SerializeToString(List<T> entity);
        Task SerializeToFile(List<T> entity, string pathToFile);
        List<T>? DeserializeFromString(string json);
        Task<List<T>?> DeserializeFromFile(string pathToFile);
    }
}
