using LS.Application.Common.Interfaces.Repositories;
using LS.Application.Common.Interfaces.Services;
using LS.Domain.Entities;
using System;
using System.Collections.Generic;
 using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Infrastracture.Services
{
    public class RectangleService : IRectangleService
    {
        private readonly IRectangleRepository _rectangleRepository;
        public RectangleService(IRectangleRepository rectangleRepository)
        {
            _rectangleRepository = rectangleRepository;
        }
        public Domain.Entities.Rectangle Add(Rectangle rectangle)
        {
           if (rectangle.Height < 0)
            {
                throw new Exception("Высота не может иметь отрицательное значение");
            }
           return _rectangleRepository.Add(rectangle); 
        }

        public Rectangle? GetById(Guid Id)
        {
            return _rectangleRepository.GetById(Id);
        }

        public void Remove(Rectangle rectangle)
        {
            _rectangleRepository.Remove(rectangle);
        }

        public Rectangle Update(Rectangle rectangle)
        {
           return _rectangleRepository.Update(rectangle);
        }
    }
}
