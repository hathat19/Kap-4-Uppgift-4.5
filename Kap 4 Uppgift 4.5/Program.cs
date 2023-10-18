using System;
namespace Uppgift4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentNr = 0;
            int newNr = 0;

            Console.WriteLine("Skriv en ett heltal:");
            string userNr = Console.ReadLine();

            for (int i = 0; i < userNr.Length; i++) 
            {
                currentNr = int.Parse(userNr[i].ToString()); //Aktuella siffran

                newNr = currentNr == 9 ? currentNr - 1 : currentNr + 1; //Ny siffra
                
                if (i == 0) //första loopen
                {
                    Console.WriteLine("Här är ditt nya tal:");
                }

                Console.Write(newNr); //skriv ut ny siffra
            }
        }
    }
}