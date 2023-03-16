using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea.Figures
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус окружности.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        public Circle(int radius)
        {
            Radius = radius;
        }
        /// <summary>
        /// Радиус.
        /// </summary>
        public int Radius { get; set; }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Площадь круга диаметром {Radius} = ";
        }
    }
}
