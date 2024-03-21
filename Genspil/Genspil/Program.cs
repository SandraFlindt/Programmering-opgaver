namespace Genspil
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<String> SpilListe = new List<String>();

         Lager myLager = new Lager("Ludo");

       
            SpilListe.Add(myLager.spilNavn);

            Console.WriteLine(myLager.spilNavn);

        }
    }
}
