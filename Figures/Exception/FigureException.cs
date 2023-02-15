using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Exception
{
    public class FigureException : IOException
    {
        public FigureException(string message) : base(message) { }
    }
}
