using System;

namespace RectangleExcercice
{
    public class Rectangle
    {
        private float _longueur;
        private float _largeur;
        private string _couleur;

        public string Couleur
        {
            get { return _couleur; }
        }
        
        // constructeur
        public Rectangle(float longueur, float largeurF)
        {
            this._longueur = longueur;
            this._largeur = largeurF;
        }
        
        public Rectangle(float longueur, float largeurF, string couleur)
        {
            this._longueur = longueur;
            this._largeur = largeurF;
            this._couleur = couleur;
        }

        public void Perimetre()
        {
            Console.WriteLine($"Le perimetre du rectange est: {2 * (_longueur + _largeur)} cm");
        }
        
        public float Aire()
        {
            return _longueur * _largeur;
        }

        public void CouleurRectangle()
        {
            if (_couleur != null)
            {
                Console.WriteLine($"la couleur du rectange est {_couleur}");
            }
            else
            {
                Console.WriteLine("le rectange n'a pas de couleur");
            }

        }

    }
}