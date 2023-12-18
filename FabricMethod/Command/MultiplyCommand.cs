using FabricMethod.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Command
{
    public class MultiplyCommand : ICommand
    {
        public double Execute(double a, double b)
        {
            double result;
            try
            {
                result = a * b;
            }
            catch(CalculatorException e)
            {
                Console.WriteLine(e.Message);
                result = default;
            }
            return result;
        }
    }
}
