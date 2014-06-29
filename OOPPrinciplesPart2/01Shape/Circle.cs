namespace Shape
{
    using System;

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius) : base(radius, radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            private set
            {
                this.radius = value;
            }
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * this.radius * this.radius;
            return surface;
        }
    }
}