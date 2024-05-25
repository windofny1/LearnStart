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
    
        private string _name = string.Empty;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
   
    }
}
