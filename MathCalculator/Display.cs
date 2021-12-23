using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalculator
{
    public class Display
    {
        public void Show(Calculator calculator)
        {
            Console.WriteLine(calculator.ToString());
        }
    }
}
