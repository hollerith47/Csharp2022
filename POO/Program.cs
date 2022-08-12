using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Animal chien = new Animal("Check", 12);
           Animal chat = new Animal("Rocky", 1);

           chien.AfficheInfos();
           chat.AfficheInfos();*/
           Chien chien1 = new Chien("Rocky", 3, 1245);
           chien1.AfficheInfos();
           chien1.Parler();
           chien1.Marcher();

           Poisson poisson1 = new Poisson("Tilapia", 6, true);
           poisson1.AfficheInfos();
           poisson1.Nager();
           poisson1.Parler();

           Animal a1 = new Chien("Hm", 3, 14540);
           a1.AfficheInfos();
        }
    }
}