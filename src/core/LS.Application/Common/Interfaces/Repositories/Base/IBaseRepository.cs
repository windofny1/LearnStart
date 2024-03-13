using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Application.Common.Interfaces.Repositories.Base
{
    public interface IBaseRepository<T>
    {
        T Add(T rectangle);
        T Update(T rectangle);
        void Remove(T rectangle);
        T? GetById(Guid Id);
    }
}
