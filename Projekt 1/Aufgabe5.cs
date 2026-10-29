namespace Projekt_1
{
    internal class Aufgabe5
    {
        static void Main(string[] args)
        {
            Console.Write("Wie viele Km möchtest du Rennen? ");
            int AnzahlKm = Convert.ToInt32(Console.ReadLine());

            double n = (AnzahlKm / 0.4);

            if (AnzahlKm > 42)
                Console.WriteLine("Das schaffst du nicht!");

            else
                Console.WriteLine("Das sind " + n + " Runden bist du Bereit?"); 



            
                
        }
    }
}
