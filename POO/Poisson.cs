using System;

namespace POO
{
    public class Poisson : Animal
    {
        // attribut
        public bool eauFroide;
        
        // constructeur
        public Poisson(string nom, int age, bool eauFroide) : base(nom, age)
        {
            this.eauFroide = eauFroide;
        }
        
        // methodes
        public void Parler()
        {
            Console.WriteLine("Gloup wouf");
        }

        public void Nager()
        {
            Console.WriteLine($"le poisson {Nom} nage");
        }
        
        public override void AfficheInfos()
        {
            Console.WriteLine($"Je suis un poisson, je me nomme {Nom}");
            Console.WriteLine($"J'ai {Age} an{((Age>1) ? "s.":'.')}");
        }
        
    }
}