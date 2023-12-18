using FabricMethod.Exeptions;

namespace FabricMethod
{
    class Program
    {
        static void Main()
        {
            StackCalculator calculator = new StackCalculator();

            try
            {
                double result = calculator.Calculate("5 3 4 * + 7 +");
                Console.WriteLine($"Result: {result}");
            }
            catch (CalculatorException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}