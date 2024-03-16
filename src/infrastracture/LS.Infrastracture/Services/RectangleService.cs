using LS.Application.Common.Interfaces.Repositories;
using LS.Application.Common.Interfaces.Services;
using LS.Domain.Entities;
using LS.Infrastracture.Services.Base;
using System;
using System.Collections.Generic;
 using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LS.Infrastracture.Services
{
    public class RectangleService :BaseService<Rectangle>,
        IRectangleService
    {
        private readonly IRectangleRepository _rectangleRepository;
        public RectangleService(IRectangleRepository rectangleRepository)
            :base(rectangleRepository)
        {
            _rectangleRepository= rectangleRepository;
        }       
        public List<Rectangle> GetList(string name)
        {
            return _rectangleRepository.
                GetList(name);
        }
    }
}
