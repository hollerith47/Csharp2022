using System;
using System.Collections.Generic;
using System.Xml;

namespace premier_programme
{
    class Program
    {
        static void Main(string[] args)
        {
            // un commentaire
            // 1. les variables
            /*
            Console.WriteLine("Variables");
            string prenom = "Herman";
            Console.WriteLine(prenom);
            
            int age = 25;
            Console.WriteLine(age);
            
            // float
            float taille = 1.70f;
            Console.WriteLine(taille);
            Console.WriteLine();
            
            // concatenation
            Console.WriteLine("Concatenation");
            
            // first method
            Console.WriteLine("first method");
            string concatenation = "je suis " + prenom + " j'ai " + age + " ma taille est : " + taille +" cm";
            Console.WriteLine(concatenation);
            
            // second method
            Console.WriteLine("second method");
            Console.WriteLine("je suis " + prenom+ "j'ai " + age);

            // third method
            Console.WriteLine("third method");
            Console.WriteLine("Je suis {0}, j'ai {1} ans, ma taille {2} cm", prenom, age, taille);
            Console.WriteLine();

            // fourth method $the best
            Console.WriteLine("fourth method $the best");
            Console.WriteLine($"Je suis {prenom}, j'ai {age} ans et je mesure {taille} cm");
            */
            // Console.WriteLine();
            // Console.WriteLine("Hello World! This is Herman with C Sharp");
            // Console.WriteLine("Jetbrains le meilleur des outils");
            // Console.WriteLine(10*10);
            // Console.ReadKey();
            
            // 2. les operateurs arithmetiques
            /*
            // Console.WriteLine();
            // Console.WriteLine("les operateurs arithmetiques");
            // // Console.WriteLine(5+2);
            // int nombre, resultat;
            // nombre = 25;
            // resultat = nombre * 2;
            // Console.WriteLine(resultat);
            // Console.Read();*/
            
            // 3. les if condition
            /*
            int age = 11;
            // age++;
            if (age >= 18)
            {
                Console.WriteLine("condition verifie");
            }
            else
            {
                Console.WriteLine("Mineur ...");
            }*/
            
            // 4. les switch condition
            /*
            Console.Write("Entrez votre prenom : ");
            var firstName = Console.ReadLine();
            // firstName = "Hollerith";

            switch (firstName)
            {
                case "Herman":
                    Console.WriteLine($"Bonjour {firstName}");
                    break;
                
                case "Hmak":
                    Console.WriteLine($"Bonjour {firstName}");
                    break;
                
                case "Hollerith":
                    Console.WriteLine($"Bonjour {firstName}");
                    break;
                
                default:
                    Console.WriteLine($"Hello {firstName}!");
                    break;
            }

            int moyenne = 15;

            switch (moyenne)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                {
                    Console.WriteLine("Mediocre");
                    break;
                }

                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Non-Admis");
                    break;
                
                default:
                    Console.WriteLine("Admis");
                    break;
            }
            */
            
            // 5. Les tableaux
            /*
            string[] tabMois =
            {
                "Janvier",
                "Fevrier",
                "Mars",
                "Avril",
                "Mai",
                "Juin"
            };
            Console.WriteLine($"Longuer du tableau est {tabMois.Length}");
            Console.WriteLine(tabMois[1]);
            */
            
            // 6. Les boucles
            // 6.1 La boucle for
            /*
            const int nb = 10;
            Console.WriteLine($"Table de multiplication par {nb}");
            
            for (var i = 1; i <=10; i++)
            {
                Console.Write($" {i} * {nb} = {i * nb} ");
                Console.WriteLine(i.GetType());
            }

            string[] tPrenoms = { "Herman", "Alliance", "Ingrid", "Coach", "Joyce", "Jorel" };
            Console.WriteLine($" Indice   Valeur");
            // boucle for
            for (var i = 0; i < tPrenoms.Length; i++)
            {
                Console.WriteLine($"    {i}     {tPrenoms[i]}");
            }
            */
            
            // 6.2 boucle foreach
            /*
            foreach (var prenom in tPrenoms)
            {
                Console.WriteLine(prenom);
            }
            */
            
            // 6.3 boucle while
            /*
            int compteur = 0;
            while (compteur < 10)
            {
                Console.WriteLine($"Valeur de i {compteur}");
                compteur++;
            }
            */
            // 6.4 boucle do while
            /*
            compteur = 2;
            do
            {
                Console.WriteLine($"Valeur de i {compteur}");
                compteur++;
            } while (compteur>10);
            */
            
            // 7 Conversion des types, cast ou casting ou encore transtypage
            // 7.1 float en int
            /*
            float nb = 15.6f;
            Console.WriteLine(nb);
            int nb1 = (int)nb;
            Console.WriteLine(nb1);
            */
            
            // 7.2 string en int
            /*
            Console.Write("Entrer un nombre: ");
            var nbString = Console.ReadLine();
            int resultat;
            if (int.TryParse(nbString, out resultat))
            {
                resultat = int.Parse(nbString) * 2;
                Console.WriteLine(resultat);
            }
            */
            
            // 8. Les listes
            /*
            List<string> lstPrenom = new List<string>();
            // ajout d'element dans la liste 
            lstPrenom.Add("Herman");
            lstPrenom.Add("Hmak");
            lstPrenom.Add("Hollerith");
            lstPrenom.Add("Mak");
            
            // deuxieme method de declarations d'une liste
            List<string> lstHmak = new List<string>
            {
                "Hollerith",
                "Html",
                "JavaScript",
                "css",
                "C#"
            };

            // suppression d'element dans la liste'
            // lstPrenom.Remove("Hollerith");
            // lstPrenom.RemoveAt(0);
            // lstPrenom.RemoveRange(0,3);
            // lstPrenom.Clear(); // supprimer tout les elements de la liste

            // parcourir la liste
            foreach (var item in lstPrenom)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(lstPrenom.Count);
            Console.WriteLine();
            
            foreach (var item in lstHmak)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(lstHmak.Count);
*/
            
            // 9. Les dictionaires
            /*
            Dictionary<string, string> dicoExt = new Dictionary<string, string>();
            dicoExt.Add("bmp", "paint");
            dicoExt.Add("txt", "notepad");
            dicoExt.Add("docx", "word");
            dicoExt.Add("doc", "wordpad");
            
            Console.WriteLine(dicoExt.Count);
            Console.WriteLine(dicoExt["bmp"]);

            for (int i = 0; i < dicoExt.Count; i++)
            {
                Console.Write("Entrer le nom de l'extension: ");
                var extension = Console.ReadLine();

                if (dicoExt.ContainsKey(extension))
                {
                    Console.WriteLine(dicoExt[extension]);
                }
                else
                {
                    Console.WriteLine("cle absente ...");
                } 
            }*/
            
            // 10. personnaliser la console
            /*
            Console.Title = "Mon premier programme C#";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hello world. "); 
            Console.WriteLine(); */
            
            // jeu de mot aleatoire
            // Console.Write("Entrer un nombre entre 0 et 100 : ");
            // var userEntry = Console.ReadLine();
           
            // 11. Les methodes et les fonctions
            // 11.1 Methodes
            // AffichageErreur();
            /*
            void AffichageErreur()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***************************");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Une erreur est survenue");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***************************");
                Console.ForegroundColor = ConsoleColor.White;
            }

            void tableMult(int nb = 2)
            {
                Console.WriteLine($"Table de Multiplication par {nb}");
                for (int i = 1; i <=12 ; i++)
                {
                    Console.WriteLine($"{i} * {nb} = {i * nb}");
                }
            }
            tableMult(10);
            */
            
            // 11.2 fonctions
            /*
            int Somme3(int nb1, int nb2)
            {
                return nb1 + nb2;
            }
            // fonction pour definir si un nombre et plus grand, plus petit ou est egal a 10
            string pgq10(int nb)
            {
                if (nb > 10) return "Plus grand que 10";
                if (nb < 10) return "Plus grand que 10";
                return "Est egal a 10";
            }
            Console.WriteLine();
            Console.WriteLine(Somme3(10,15));
            Console.WriteLine(pgq10(15));
*/      
            // 12. Action deleguee
            /*
            Action<string> print = str => Console.WriteLine(str);

            print("toto");
            print("Herman is playing with C#");
            */
            
            // 13. Date & heure
            DateTime maintenant = DateTime.Now;
            Console.WriteLine(maintenant);
            
            Console.WriteLine(maintenant.ToString("H:mm:ss zz"));

            DateTime myBirthDay = new DateTime(1996, 11, 17);
            DateTime m = DateTime.Now;

            TimeSpan diffDate = m - myBirthDay;
            Console.WriteLine($"j'ai {diffDate.Days} jours sur terre.");

            DateTime dixMille = myBirthDay.AddDays(10000);
            Console.WriteLine(dixMille);
            Console.WriteLine();

            Console.WriteLine();
            var x = 10;
            int y = 2;
 
            somme(x, y);
 
            int somme(int nb1, int nb2)
            {
                return nb1 + nb2;
            }
            Console.ReadLine(); 

        }
    }
}