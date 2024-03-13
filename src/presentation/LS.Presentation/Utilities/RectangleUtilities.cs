using LS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Presentation.Utilities
{
    public static class RectangleUtilities
    {
        public static Rectangle Create(string name)
        {
            return     new Domain.Entities.Rectangle()
            {
                X = 0,
                Y = 0,
                Width = 100,
                Height = 100,
                Id = Guid.NewGuid(),
                Name = name
            };
        }
    }
}
