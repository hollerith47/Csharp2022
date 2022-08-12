using System;

namespace LesInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = new Operation();
            op.Nb1 = 25;
            op.Nb2 = 45;
            op.Addition();
            op.Soustraction();
        }
    }
}