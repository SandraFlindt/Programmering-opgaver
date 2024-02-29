namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Number1 = 0;
            double Number2 = 0;
            Console.WriteLine("Type a number:");
            Number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type a new number");
            Number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type 1 for '+' type 2 for '-' type 3 for '/' type 4 for '*'");
            
            //Switch statement for the math
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Your result = {Number1} + {Number2} = " + (Number1 + Number2));
                    break;
                case "2":
                    Console.WriteLine($"Your result = {Number1} - {Number2} = " + (Number1 - Number2)); 
                    break;
                case "3":
                    Console.WriteLine($"Your result = {Number1} / {Number2} = " + (Number1 / Number2));
                    break;
                case "4":
                    Console.WriteLine($"Your result = {Number1} * {Number2} = " + (Number1 * Number2));
                    break;
            }    
        }   
    }
}
