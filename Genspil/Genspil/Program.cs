namespace Genspil
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lager myLager = new Lager();

            myLager.AddSpil("Ludo");
            myLager.AddSpil("Skak");

            foreach (var spil in myLager.GetSpil())
            {
                Console.WriteLine(spil);
            }
        }
    }
}
