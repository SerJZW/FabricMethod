using FabricMethod.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Command
{
    public class DivideCommand : ICommand
    {
        public void Execute(Stack<double> stack)
        {
            if (stack.Count < 2)
                throw new CalculatorException("Not enough operands for division");
            double b = stack.Pop();
            if (b == 0)
                throw new CalculatorException("Division by zero");
            double a = stack.Pop();
            stack.Push(a / b);
        }
    }
}
