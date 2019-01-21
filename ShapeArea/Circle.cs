using System;

namespace ShapeArea
{
    internal class Circle : Shape
    {
        private readonly double _radius;

        internal Circle(double radius)
        {
            _radius = radius;

            Valid = radius >= 0.0;
        }

        protected override double CalculateArea() { return Math.PI * _radius * _radius; }
    }
}
