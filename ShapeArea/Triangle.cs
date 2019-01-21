using System;

namespace ShapeArea
{
    internal class Triangle : Shape
    {
        private double _side1;
        private double _side2;
        private double _side3;

        internal Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;

            Valid = (_side1 < (_side2 + _side3)) && (_side2 < (_side1 + _side3)) && (_side3 < (_side1 + _side2));
        }

        protected override double CalculateArea()
        {
            PushMaxSide();

            if (IsRightAngled())
            {
                return _side1 * _side2 * 0.5;
            }

            double halfPerimeter = (_side1 + _side2 + _side3) / 2.0;
            double areaSqr =
                halfPerimeter * (halfPerimeter - _side1) * (halfPerimeter - _side2) * (halfPerimeter - _side3);
            return Math.Sqrt(areaSqr);
        }

        private bool IsRightAngled()
        {
            return Math.Abs(_side3 * _side3 - _side2 * _side2 - _side1 * _side1) <= double.Epsilon;
        }

        private void PushMaxSide()
        {
            if (_side1 > _side3)
            {
                Swap(ref _side1, ref _side3);
            }

            if (_side2 > _side3)
            {
                Swap(ref _side2, ref _side3);
            }
        }

        private static void Swap(ref double a, ref double b)
        {
            a += b;
            b = a - b;
            a = a - b;
        }
    }
}
