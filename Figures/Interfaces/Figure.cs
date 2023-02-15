using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Interfaces
{
    public abstract class Figure
    {

        abstract public double Square();
        abstract public string Type { get; }
        abstract protected bool IsCorrect();
    }
}
