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
        private double operand;
        private Stack<double> operandStack;
        private Dictionary<char, ICommand> operators;

        public StackCalculator()
        {
            operand = 0;
            operandStack = new Stack<double>();
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
            string[] tokens = expression.Split(' ');

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double number))
                {
                    operandStack.Push(number);
                }
                else if (operators.ContainsKey(token[0]))
                {
                    try
                    {
                        PerformOperation(token[0]);
                    }
                    catch (CalculatorException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        break;
                    }
                }
            }

            if (operandStack.Count == 1)
                return operandStack.Pop();
            else
                throw new CalculatorException("Invalid expression");
        }
        private void PerformOperation(char op)
        {
            if (operandStack.Count < 2)
                throw new CalculatorException("Not enough operands for operation");

            double b = operandStack.Pop();
            double a = operandStack.Pop();

            operand = operators[op].Execute(a, b);
            operandStack.Push(operand);
        }
    }
}
