using System;

namespace LesStructures
{
    struct Personne
    {
        public string nom;
        public string prenom;
/*
        public Personne(string _nom, string _prenom)
        {
            nom = _nom;
            prenom = _prenom;
        }
        */

        public void Parler()
        {
            Console.WriteLine($"{nom} parle...");
        }
    }
}