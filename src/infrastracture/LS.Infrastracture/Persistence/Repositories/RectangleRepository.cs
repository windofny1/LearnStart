using LS.Application.Common.Interfaces.Repositories;
using LS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Infrastracture.Persistence.Repositories
{
    public class RectangleRepository : IRectangleRepository
    {
        private static List<Rectangle> _rectangleList=new List<Rectangle>();
        public Rectangle Add(Rectangle rectangle)
        {
            _rectangleList.Add(rectangle);
            return rectangle;
        }

        public Rectangle? GetById(Guid Id) 
        {
            //LINQ
            return _rectangleList.
                Where(m => m.Id == Id).FirstOrDefault();
        }

        public void Remove(Rectangle rectangle)
        {
            _rectangleList.Remove(rectangle);
        }

        public Rectangle Update(Rectangle rectangle)
        {
            var index = _rectangleList.IndexOf(rectangle);
            if (index >= 0) {
              return  _rectangleList[index] = rectangle;
            }
            return rectangle;
        }
        public List<Rectangle> GetList(string name)
        { 
            if (string.IsNullOrEmpty(name))
            {
                return new List<Rectangle>();
            }
            //LINQ
            return _rectangleList.Where(rectangle => rectangle.
            Name.ToLower().StartsWith(name.ToLower())).ToList();
        }
    }
}
