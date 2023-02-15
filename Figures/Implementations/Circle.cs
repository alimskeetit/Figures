using Figures.Exception;
using Figures.Interfaces;
using Figures.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Implementations
{
    public class Circle : Figure
    {
        public override string Type => "Circle";
        public double Radius { get; }



        public Circle(double radius)
        {
            Radius = radius;
            IsCorrect();
        }

        public override double Square()
        {
            return Constants.Constants.Pi * Radius * Radius;
        }

        protected override bool IsCorrect()
        {
            if (Radius <= 0)
                throw new FigureException("Radius is less or equals 0");
            
            return true;
        }
    }
}
