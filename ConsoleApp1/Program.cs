using ClassiDellaLampadina;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampadina l = new Lampadina();
            bool fineCiclo = false;
            do
            {
                Console.WriteLine("Che operazione vuoi fare? (Click/Descrizione/Termina)");
                string risposta = Console.ReadLine();
                if (risposta == "Click")
                {
                    l.Click();
                    Console.WriteLine("Cliccato");
                }
                if (risposta == "Descrizione")
                {
                    Console.WriteLine(l.StatoAttuale());
                }
                if (risposta == "Termina")
                {
                    fineCiclo = true;
                    Console.WriteLine("Premi invio per terminare");
                }
            } while (fineCiclo == false);
            Console.ReadLine();
        
    }
    }
}
