using FigureArea;
using FigureArea.Figures;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Площадь круга димаметром 5.
            IFigure сircle = new Circle(5);
            Console.WriteLine(сircle.ToString() + сircle.GetArea());
            IFigure triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.ToString() + triangle.GetArea());
            Triangle triangle1 = new Triangle(3, 4, 5);
            Console.WriteLine(triangle1.IsRectangular());

            // Запрос из второго вопроса.
            var query = "select p.productName, c.category from product p left outer join category c on c.id = p.id";
        }
    }
}
