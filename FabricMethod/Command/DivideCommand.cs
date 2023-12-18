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
                result = a / b;
                if (a == 0 || b == 0)
                {
                    throw new CalculatorException("Some operand is null");
                }
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
