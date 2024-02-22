using LS.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Domain.Entities
{
    /// <summary>
    /// Класс, описывающий прямоугольник
    /// </summary>
    public class Rectangle:Shape
    { 
        /// <summary>
        /// Ширина прямоугольника
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Высота прямоугольника
        /// </summary>
        public int Height { get; set; }
    }
}
