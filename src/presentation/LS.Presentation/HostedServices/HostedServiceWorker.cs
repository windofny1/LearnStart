using LS.Application.Common.Interfaces.Services;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Presentation.HostedServices
{
    public class HostedServiceWorker : IHostedService
    {
        private readonly IRectangleService _rectangleService;
        public HostedServiceWorker(IRectangleService rectangleService)
        {
            _rectangleService = rectangleService;
        }        
        public async Task StartAsync(CancellationToken cancellationToken)
        { 
            await Task.Delay(1);
            BuildMenu(); 
        }
        private void BuildMenu()
        {
            Console.WriteLine("Выберите пункт меню для начала:");
            Console.WriteLine("1 - Добавить объект");
            Console.WriteLine("2 - Получить объект");
            var key = Console.ReadKey();
            Console.Clear();
            switch (key.KeyChar)
            {
                case '1':
                    var newRect = new Domain.Entities.Rectangle()
                    {
                        X = 0,
                        Y = 0,
                        Width = 100,
                        Height = 100,
                        Id = Guid.NewGuid(),
                        Name = $"Прямоугольник от {DateTime.Now.ToString()}"
                    };
                    Console.WriteLine($"Создан прямоугольник Id: {newRect.Id}, Name= {newRect.Name}");
                    _rectangleService.Add(newRect);
                    break;
                case '2':
                    break;
                default:
                    break;

            }
        }

    public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Task.Delay(1);
        }
}
}
