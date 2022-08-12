using System;

namespace Serialisation_object_Json
{
    public class Client
    {
        private string _nom;
        private string _prenom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public Client(string nom, string prenom)
        {
            this._nom = nom;
            this._prenom = prenom;
        }
        
        public Client(){}

        public void Information()
        {
            Console.WriteLine($"Bonjour, je suis {_nom} {_prenom}");
        }
    }
}