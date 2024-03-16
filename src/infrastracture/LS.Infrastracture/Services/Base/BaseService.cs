using LS.Application.Common.Interfaces.Repositories;
using LS.Application.Common.Interfaces.Repositories.Base;
using LS.Application.Common.Interfaces.Services.Base;
using LS.Domain.Entities;
using LS.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LS.Infrastracture.Services.Base
{
    public class BaseService<T>:IBaseService<T>
         where T : Shape
    {
        private readonly IBaseRepository<T> _baseRepository;
        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public T Add(T entity)
        { 
            return _baseRepository.Add(entity);
        }

        public T? GetById(Guid Id)
        {
            return _baseRepository.GetById(Id);
        }

        public void Remove(T entity)
        {
            _baseRepository.Remove(entity);
        }

        public T Update(T entity)
        {
            return _baseRepository.Update(entity);
        }
        public string SerializeToString(List<T> data)
        {
            return JsonSerializer.Serialize(data, new JsonSerializerOptions()
            {
                WriteIndented = true
            });
        }
        public List<T>? DeserializeFromString(string json)
        {
            return JsonSerializer.Deserialize<List<T>>(json);
        }
        public async Task<List<T>?> DeserializeFromFile(string pathToFile)
        {
            if (!File.Exists(pathToFile)) { return new List<T>(); }
            using FileStream readStream = File.OpenRead(pathToFile);
            return await JsonSerializer.DeserializeAsync<List<T>>(readStream);
        }
        public async Task SerializeToFile(List<T> data, string pathToFile)
        {
            using FileStream createStream = File.Create(pathToFile);
            await JsonSerializer.SerializeAsync(createStream, data);
        }

        
    }
}
