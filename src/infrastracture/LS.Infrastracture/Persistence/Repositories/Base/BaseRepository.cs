using LS.Application.Common.Interfaces.Repositories.Base;
using LS.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Infrastracture.Persistence.Repositories.Base
{
    public class BaseRepository<T>:IBaseRepository<T>
        where T:Shape 
    {
        protected static List<T> _objectList = new List<T>();
        public T Add(T rectangle)
        {
            _objectList.Add(rectangle);
            return rectangle;
        }

        public T? GetById(Guid Id)
        {
            //LINQ
            return _objectList.
                Where(m => m.Id == Id).FirstOrDefault();
        }

        public void Remove(T rectangle)
        {
            _objectList.Remove(rectangle);
        }

        public T Update(T rectangle)
        {
            var index = _objectList.IndexOf(rectangle);
            if (index >= 0)
            {
                return _objectList[index] = rectangle;
            }
            return rectangle;
        }
        
    }
}
