using System;

namespace LesInterfaces
{
    public class Operation : IAddition, ISoustraction
    {
        public int Nb1 { get; set; }
        public int Nb2 { get; set; }
        public int Nb3 { get; set; }
        
        public void Addition()
        {
            Console.WriteLine(Nb1 + Nb2);
        }
        
        public void Soustraction()
        {
            Console.WriteLine(Nb1 - Nb2);

        }
    }
}