using System;

namespace ShapeArea
{
    internal class Triangle : Shape
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        internal Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;

            Valid = (_side1 < (_side2 + _side3)) && (_side2 < (_side1 + _side3)) && (_side3 < (_side1 + _side2));
        }

        protected override double CalculateArea()
        {
            double halfPerimeter = (_side1 + _side2 + _side3) / 2.0;
            double areaSqr =
                halfPerimeter * (halfPerimeter - _side1) * (halfPerimeter - _side2) * (halfPerimeter - _side3);
            return Math.Sqrt(areaSqr);
        }
    }
}
