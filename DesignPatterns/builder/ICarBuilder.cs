using DesignPatterns.builder;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace DesignPatterns.Builder

{
    internal interface ICarBuilder
    {
        ICarBuilder SetEngine(string engine);
        ICarBuilder SetColor(string color);
        ICarBuilder SetWheels(int wheels);
        ICarBuilder SetSeats(int seats);
        Car Build();

    }

}

