using LS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Application.Common.Interfaces.Services
{
    public interface IRectangleService
    {
        Rectangle Add(Rectangle rectangle);
        Rectangle Update(Rectangle rectangle);
        void Remove(Rectangle rectangle);
        Rectangle? GetById(Guid Id);
        string SerializeToString(Rectangle rectangle);
        Task SerializeToFile(Rectangle rectangle, string pathToFile);
        Rectangle? DeserializeFromString(string json);
        List<Rectangle> GetList(string name);
    }
}
