using Calculator;
namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.Calculator MyCalculator = new Calculator.Calculator();
            int result = MyCalculator.Add(2,2);
            Console.WriteLine("Result is " + result);    
        }   
    }
}
