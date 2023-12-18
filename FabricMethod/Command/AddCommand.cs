using FabricMethod.Exeptions;

namespace FabricMethod.Command
{
    public class AddCommand : ICommand
    {
        public double Execute(double a, double b)
        {
            double result;
            try
            {
                result = a + b;
            }
            catch (CalculatorException e)
            {
                Console.WriteLine(e.Message);
                result = 0;
            }
            return result;
        }
    }
}
