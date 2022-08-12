using System;
using System.IO;

namespace Persistances_des_donnees
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\herma\\Desktop\\Learning\\C#\\test.txt";
            
            // creation du fichier txt
            /*using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("1ere ligne");
            }*/
            
            // ajouter de ligne sans ecraser les precedents
            /*
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Ligne 2");
            }*/
            
            // lecture du fichier txt ligne par ligne
            /*
            using (StreamReader sr = new StreamReader(path))
            {
                string line = null;
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }*/
            
            // lire l'integralite du fichier d'un coup
            using (StreamReader sr = new StreamReader(path))
            {
                string file = sr.ReadToEnd();
                Console.WriteLine(file);
            }
        }
    }
}