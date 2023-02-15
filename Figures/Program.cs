using Figures;
using Figures.Implementations;
using Figures.Interfaces;

Figure figure = new Circle(3);

Console.WriteLine($"It's {figure.Type} and its square is {figure.Square()}");

figure = new Triangle(3, 4, 5);

Console.WriteLine($"It's {figure.Type} and its square is {figure.Square()}");
