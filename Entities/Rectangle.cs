using OOPShapesTask.Interface;

namespace OOPShapesTask.Entity
{
    public class Rectangle : IShape
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        
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

        protected double SecondSide
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

        public Rectangle(double firstSide, double secondSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
        }

        public double GetSquare() => FirstSide * SecondSide;

        public double GetPerimeter() => 2 * (FirstSide + SecondSide);

        public override string ToString() => 
            $"Figure: {nameof(Rectangle)} | First Side: {FirstSide} | Second Side: {SecondSide} |" +
            $" Square: {GetSquare()} | Perimeter: {GetPerimeter()}";
    }
}