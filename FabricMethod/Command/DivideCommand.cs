using FabricMethod.Exeptions;

namespace FabricMethod.Command
{
    public class DivideCommand : ICommand
    {
        public double Execute(double a, double b)
        {
            double result;
            try
            {
                if (b == 0)
                {
                    throw new CalculatorException("Division by zero is not allowed");
                }
                result = a / b;
            }
            catch (CalculatorException e)
            {
                Console.WriteLine(e.Message);
                result = default;
            }
            return result;
        }
    }
}
