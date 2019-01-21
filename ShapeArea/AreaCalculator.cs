namespace ShapeArea
{
    public static class AreaCalculator
    {
        public static double CalculateCircleArea(double radius)
        {
            var circle = new Circle(radius);
            return circle.GetArea();
        }

        public static double CalculateTriangleArea(double side1, double side2, double side3)
        {
            var triangle = new Triangle(side1, side2, side3);
            return triangle.GetArea();
        }
    }
}
