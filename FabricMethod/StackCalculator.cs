using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricMethod.Command;
using FabricMethod.Exeptions;

namespace FabricMethod
{
    public class StackCalculator
    {
        private Stack<double> stack;
        private Dictionary<char, ICommand> operators;

        public StackCalculator()
        {
            stack = new Stack<double>();
            operators = new Dictionary<char, ICommand>
        {
            { '+', new AddCommand() },
            { '-', new SubtractCommand() },
            { '*', new MultiplyCommand() },
            { '/', new DivideCommand() }
        };
        }

        public double Calculate(string expression)
        {
            foreach (char token in expression)
            {
                if (char.IsDigit(token) || token == '.')
                {
                    double operand = double.Parse(token.ToString());
                    stack.Push(operand);
                }
                else if (operators.ContainsKey(token))
                {
                    try
                    {
                        operators[token].Execute(stack);
                    }
                    catch (CalculatorException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        break;
                    }
                }
                // Ignore other characters
            }

            if (stack.Count == 1)
                return stack.Pop();
            else
                throw new CalculatorException("Invalid expression");
        }
    }
}
