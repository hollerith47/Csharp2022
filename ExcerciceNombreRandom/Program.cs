using System;

namespace ExcerciceNombreRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            var rand = new Random();
            var nb = rand.Next(1, 101);
            var compteur = 0;
            var userEntry = 0;

            while (userEntry != nb)
            {
                Console.Write("Entrez un nombre entre 1 et 100 : ");
                try
                {
                    userEntry = int.Parse(Console.ReadLine());
                    if (userEntry > nb)
                    {
                        Console.WriteLine($"{userEntry} est plus grand");
                        compteur++;
                    }
                    if (userEntry < nb)
                    {
                        Console.WriteLine($"{userEntry} est plus petit");
                        compteur++;
                    }
                }
                catch 
                {
                    Console.WriteLine("une erreur veillez recommencer svp...");
                }
            }
            compteur++;
            Console.WriteLine($"Bravo, vous avez gagne en {compteur} coup{((compteur>1) ? 's':'.')}.");
        }
    }
}