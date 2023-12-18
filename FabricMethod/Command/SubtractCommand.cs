using FabricMethod.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Command
{
    public class SubtractCommand : ICommand
    {
      public double Execute(double a, double b)
        {
            double result;
            try
            {
                result = a - b;
            }
            catch (CalculatorException ex)
            {
                Console.WriteLine(ex.Message);
                result = default;
            }
            return result;
        }
    }

}
