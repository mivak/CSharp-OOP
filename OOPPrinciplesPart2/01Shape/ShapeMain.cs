namespace Shape
{
    using System;

    public class ShapeMain
    {
        public static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Circle(4),
                new Triangle(3, 4),
                new Rectangle(3, 5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name + " " + shape.Width + " " + shape.Height + " " + shape.CalculateSurface());
            }
        }
    }
}