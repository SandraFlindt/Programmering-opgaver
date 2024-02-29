using Calculator;
namespace Lommeregner
{
    internal class Program
    {
        static void TestAllMethods()
        {
            Calculator.Calculator MyCalculator = new Calculator.Calculator();
            int result = MyCalculator.Add(2,2);
            Console.WriteLine("Addition is " + result);  
            Console.WriteLine("Subtract is " +  MyCalculator.Subtract(3,2));
            Console.WriteLine("Multiply is " + MyCalculator.Multiply(3, 3));
            Console.WriteLine("Divition is " + MyCalculator.Divide(10, 2));
            
        }
        static void Main(string[] args)
        {
            TestAllMethods();
        }   
    }
}
