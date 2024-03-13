using LS.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Domain.Entities
{
    /// <summary>
    /// Окружность
    /// </summary>
    public class Circle:Shape
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public int R { get; set; }
    }
}
