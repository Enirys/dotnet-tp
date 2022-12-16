using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Brique : Forme
    {
        public double largeur;
        public double longueur;
        public double hauteur;

        public Brique(Point3D centre, double largeur, double longueur, double hauteur)
        {
            this.centre = centre;
            this.largeur = largeur;
            this.longueur = longueur;
            this.hauteur = hauteur;
        }

        public override void Bouger(double x, double y, double z)
        {
            centre.Bouger(x, y, z);
        }

        public override double CalculerSurface()
        {
            double surface = 2 * (largeur * longueur + largeur * hauteur + longueur * hauteur);
            return surface;
        }

        public override double CalculerVolume()
        {
            double volume = largeur * hauteur * longueur;
            return volume;
        }

        public override string ToString()
        {
            string informations = base.ToString() + $"largeur: {this.largeur}\nlongueur: {this.longueur}\nhauteur: {this.hauteur}\n]";
            return informations;
        }
    }
}
