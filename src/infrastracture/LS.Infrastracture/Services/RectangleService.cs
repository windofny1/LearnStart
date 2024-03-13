using LS.Application.Common.Interfaces.Repositories;
using LS.Application.Common.Interfaces.Services;
using LS.Domain.Entities;
using System;
using System.Collections.Generic;
 using System.Linq;
using System.Text;
using System.Text.Json;
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
        public string SerializeToString(Rectangle rectangle)
        {
            return JsonSerializer.Serialize(rectangle, new JsonSerializerOptions()
            {
                WriteIndented = true
            });
        }
        public Rectangle? DeserializeFromString(string json)
        {
            return JsonSerializer.Deserialize<Rectangle>(json);
        }
        public async Task SerializeToFile(Rectangle rectangle, string pathToFile)
        {
            await using FileStream createStream = File.Create(pathToFile);
            await JsonSerializer.SerializeAsync(createStream, rectangle);
        }

        public List<Rectangle> GetList(string name)
        {
            return _rectangleRepository.GetList(name);
        }
    }
}
