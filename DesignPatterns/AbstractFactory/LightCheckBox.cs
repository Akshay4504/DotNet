using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class LightCheckBox :ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a light-themed checkbox");
        }
    }
}
