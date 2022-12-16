using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Boule : Forme
    {
        public double rayon;

        public Boule(Point3D centre, double rayon)
        {
            this.centre = centre;
            this.rayon = rayon;
        }

        public override void Bouger(double x, double y, double z)
        {
            centre.Bouger(x, y, z);
        }

        public override double CalculerSurface()
        {
            double surface = 4 * Math.PI * Math.Pow(rayon, 2);
            return surface;
        }

        public override double CalculerVolume()
        {
            double volume = (4 / 3) * Math.PI * Math.Pow(rayon, 3);
            return volume;
        }

        public Boolean Egale(Boule b)
        {
            bool isEqual = (b.centre.Egal(this.centre) && b.rayon == this.rayon);
            return isEqual;
        }

        public override string ToString()
        {
            string informations = base.ToString() + $"rayon: {this.rayon}\n]";
            return informations;
        }
    }
}
