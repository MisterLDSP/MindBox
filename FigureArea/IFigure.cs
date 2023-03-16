using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    /// <summary>
    /// Свойства фигур.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Получить площадь фигуры.
        /// </summary>
        public double GetArea();
    }
}
