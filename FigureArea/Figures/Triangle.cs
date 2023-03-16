using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea.Figures
{
    /// <summary>
    /// Тругольник.
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// Треугольник.
        /// </summary>
        /// <param name="side1">Сторона 1.</param>
        /// <param name="side2">Сторона 2.</param>
        /// <param name="side3">Сторона 3.</param>
        public Triangle(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        /// <summary>
        /// Сторона 1.
        /// </summary>
        public int Side1 { get; set; }
        /// <summary>
        /// Сторона 2.
        /// </summary>
        public int Side2 { get; set; }
        /// <summary>
        /// Сторона 3.
        /// </summary>
        public int Side3 { get; set; }

        public double GetArea()
        {
            var p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public bool IsRectangular()
        {
            var list = new List<double>{ Side1, Side2, Side3 };
            var max = list.Max();
            if (Math.Sqrt(list.Where(x => !(x != max)).Select(x => Math.Pow(x, 2)).Sum()) == max)
                return true;
            return false;
        }

        public override string ToString()
        {
            return $"Площадь треугольника со сторонами: {Side1}, {Side2}, {Side3}, равна";
        }
    }
}
