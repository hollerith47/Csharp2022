using System;

namespace POO
{
    public abstract class Animal
    {
        // Attribut
        private string _nom;
        private int _age;
        
        // proprietes
        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                Console.WriteLine("Le nom ne peut etre changer.");
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("L'age doit etre superieur a zero");
                }
            }
        }
        
        // Constructeur par defaut
        public Animal()
        {
            Console.WriteLine("Execution du constructeur");
        }

        public Animal(string nom, int age)
        {
            this._nom = nom;
            this._age = age;
        }
        
        // Methode de classe
        public virtual void AfficheInfos()
        {
            Console.WriteLine($"Je suis un animal, je me nomme {_nom}");
            Console.WriteLine($"J'ai {_age} an{((_age>1) ? "s.":'.')}");
        }
    }
}