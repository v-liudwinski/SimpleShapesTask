using System;
using OOPShapesTask.Interface;

namespace OOPShapesTask.Entity
{
    public class Square : IShape
    {
        private readonly double _firstSide;
        
        protected double FirstSide
        {
            get => _firstSide;
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                _firstSide = value;
            }
        }

        public Square(double firstSide)
        {
            FirstSide = firstSide;
        }

        public double GetSquare() => FirstSide * FirstSide;

        public double GetPerimeter() => 4 * FirstSide;

        public override string ToString() => 
            $"Figure: {nameof(Square)} | First Side: {FirstSide} |" +
            $" Square: {GetSquare()} | Perimeter: {GetPerimeter()}";
    }
}