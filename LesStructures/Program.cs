using System;

namespace LesStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne pers = new Personne();
            pers.nom = "Toto";
            pers.Parler();
        }
    }
}