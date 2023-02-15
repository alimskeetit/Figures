using Figures.Exception;
using Figures.Interfaces;

namespace Figures.Implementations
{
    public class Triangle : Figure
    {
        public double First { get; private set; }
        public double Second { get; private set; }
        public double Third { get; private set; }
        public override string Type => "Triangle";

        public override double Square()
        {
            var p = (First + Second + Third) / 2.0;
            return Math.Sqrt(p * (p - First) * (p - Second) * (p - Third));
        }

        public Triangle( double first, double second, double third)
        {
            First = first;
            Second = second;
            Third = third;
            IsCorrect();
        }

        public bool IsRightTriangle()
        {
            //!!!For floating point numbers there is the need to set the accuracy of the error!!!
            return First* First + Second* Second == Third * Third;
        }

        protected override bool IsCorrect()
        {
            if (First <= 0 || Second <= 0 || Third <= 0)
                throw new FigureException("One of the sides less or equals 0");

            if (!(First + Second > Third && Second + Third > First && Third + First > Second))
                throw new FigureException("There is no triangle with such sides");

            return true;
        }
    }
}
