using LS.Application.Common.Interfaces.Services;
using LS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Infrastracture.Services
{
    public class RectangleBadService : IRectangleService
    {
        public Rectangle Add(Rectangle rectangle)
        {
            throw new NotImplementedException();
        }

        public Rectangle? DeserializeFromString(string json)
        {
            throw new NotImplementedException();
        }

        public Rectangle? GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<Rectangle> GetList(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(Rectangle rectangle)
        {
            throw new NotImplementedException();
        }

        public Task SerializeToFile(Rectangle rectangle, string pathToFile)
        {
            throw new NotImplementedException();
        }

        public string SerializeToString(Rectangle rectangle)
        {
            throw new NotImplementedException();
        }

        public Rectangle Update(Rectangle rectangle)
        {
            throw new NotImplementedException();
        }
    }
}
