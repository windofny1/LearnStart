using LS.Application.Common.Interfaces.Repositories;
using LS.Domain.Entities;
using LS.Infrastracture.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Infrastracture.Persistence.Repositories
{
    public class RectangleRepository : 
        BaseRepository<Rectangle>,
        IRectangleRepository
    {
         
        public List<Rectangle> GetList(string name)
        { 
            
            //LINQ
            return _objectList.
                Where(rectangle => rectangle.
            Name.ToLower().StartsWith((name ?? "").ToLower())).ToList();
        }
    }
}
