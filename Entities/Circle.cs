using System;
using OOPShapesTask.Interface;

namespace OOPShapesTask.Entity
{
    public class Circle : IShape
    {
        private const double Pi = Math.PI;
        private readonly double _radius;
        
        private double Radius
        {
            get => _radius;
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                _radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetSquare() => Math.Round(Pi * Math.Pow(Radius, 2), 2);

        public double GetPerimeter() => Math.Round(2 * Pi * Radius, 2);
        
        public override string ToString() => 
            $"Figure: {nameof(Circle)} | Radius: {Radius} |" +
            $" Square: {GetSquare()} | Perimeter: {GetPerimeter()}";
    }
}