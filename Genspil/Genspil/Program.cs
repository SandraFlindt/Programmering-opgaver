namespace Genspil
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lager myLager = new Lager();
            var mySpil = new Spil("Ludo", "", "", 0);
            myLager.AddSpil(mySpil);

            mySpil = new Spil("Skak", "", "", 0);
            myLager.AddSpil(mySpil);
           
            foreach (var spil in myLager.GetSpil())
            {
                Console.WriteLine(spil.Getname());
            }
        }
    }
}
