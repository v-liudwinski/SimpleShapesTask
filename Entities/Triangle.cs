using OOPShapesTask.Interface;
using System;

namespace OOPShapesTask.Entity
{
    public class Triangle : IShape
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;
        
        private double FirstSide
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

        private double SecondSide
        {
            get => _secondSide;
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                _secondSide = value;
            }
        }
        
        private double ThirdSide
        {
            get => _thirdSide;
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                _thirdSide = value;
            }
        }

        private double GetSemiPerimeter() => (FirstSide + SecondSide + ThirdSide) / 2;
        
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
        
        public double GetSquare()
        {
            var sqr = Math.Sqrt(
                GetSemiPerimeter() * (GetSemiPerimeter() - FirstSide) * (GetSemiPerimeter() - SecondSide) * 
                (GetSemiPerimeter() - ThirdSide)
                );

            return Math.Round(sqr, 2);
        }

        public double GetPerimeter() => FirstSide + SecondSide + ThirdSide;
        
        public override string ToString() => 
            $"Figure: {nameof(Triangle)} | First Side: {FirstSide} | Second Side: {SecondSide} | Third Side: {ThirdSide} |" +
            $" Square: {GetSquare()} | Perimeter: {GetPerimeter()}";
    }
}