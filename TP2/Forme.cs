using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public abstract class Forme
    {
        public Point3D centre;

        public abstract void Bouger(double x, double y, double z);
        public abstract double CalculerSurface();
        public abstract double CalculerVolume();
        public override String ToString() {
            string informations = $"[{this.GetType().Name}\ncentre de gravité: {centre.ToString()}\n";
            return informations;
        }
    }
}
