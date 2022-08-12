using System;

namespace POO
{
    public class Chien : Animal
    {
        // attribut
        public int NrTatouge;
        
        // constructeur
        public Chien(string nom, int age, int nrTatouge) : base(nom, age)
        {
            this.NrTatouge = nrTatouge;
        }
        
        // methodes
        public void Parler()
        {
            Console.WriteLine("Wouf wouf");
        }

        public void Marcher()
        {
            Console.WriteLine($"{Nom} marche ...");
        }
        public override void AfficheInfos()
        {
            Console.WriteLine($"Je suis un chien, je me nomme {Nom}");
            Console.WriteLine($"J'ai {Age} an{((Age>1) ? "s.":'.')}");
        }
    }
}