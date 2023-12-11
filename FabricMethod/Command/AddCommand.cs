using FabricMethod.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Command
{
    public class AddCommand : ICommand
    {
        public void Execute(Stack<double> stack)
        {
            if (stack.Count < 2)
                throw new CalculatorException("Not enough operands for addition");
            double b = stack.Pop();
            double a = stack.Pop();
            stack.Push(a + b);
        }
    }
}
