using LS.Application.Common.Interfaces.Services;
using LS.Presentation.Utilities;
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
            await BuildMenu(); 
        }
        private async Task BuildMenu()
        {
            while (true)
            {
                Console.WriteLine("Выберите пункт меню для начала:");
                Console.WriteLine("1 - Добавить объект");
                Console.WriteLine("2 - Получить объект");
                var key = Console.ReadKey();
                Console.Clear();
                switch (key.KeyChar)
                {
                    case '1':
                        Console.WriteLine("Укажите имя объекта: ");
                        var newRect = RectangleUtilities.Create(Console.ReadLine() ?? "");
                        Console.WriteLine($"Создан прямоугольник Id: {newRect.Id}, Name= {newRect.Name}");
                        _rectangleService.Add(newRect);
                        //var rectStr = _rectangleService.SerializeToString(newRect);
                        //Console.WriteLine(rectStr);
                        //await _rectangleService.SerializeToFile(newRect, "rectangle.txt");
                        //var getRect = _rectangleService.DeserializeFromString(rectStr);
                        break;
                    case '2':
                        Console.WriteLine("Пожалуйста, введите имя объекта:");

                        var resultList = _rectangleService.GetList(Console.ReadLine() ?? "");
                        resultList.ForEach(rectangle => Console.WriteLine($"Прямоугольник - {rectangle.Name}"));
                        if (resultList.Count > 0)
                        {
                            _rectangleService.GetById(resultList[0].Id);
                        }
                        break;
                    default:
                        break;

                }
            }
        }

    public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Task.Delay(1);
        }
}
}
