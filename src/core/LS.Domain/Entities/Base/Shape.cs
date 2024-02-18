using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Domain.Entities.Base
{
    /// <summary>
    /// Базовый класс фигуры
    /// </summary>
    public class Shape
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Координата X
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Координата Y
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Название фигуры
        /// </summary>
        public string Name { get; set; } = string.Empty; 
    }
}
