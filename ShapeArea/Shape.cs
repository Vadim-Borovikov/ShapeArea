namespace ShapeArea
{
    internal abstract class Shape
    {
        private double? _area;

        protected bool Valid;

        protected abstract double CalculateArea();

        internal double GetArea()
        {
            if (!_area.HasValue)
            {
                _area = Valid ? CalculateArea() : double.NaN;
            }

            return _area.Value;
        }
    }
}
