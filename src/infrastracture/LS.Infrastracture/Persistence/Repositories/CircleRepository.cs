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
    public class CircleRepository: 
        BaseRepository<Circle>, ICircleRepository
    {
        
    }
}
