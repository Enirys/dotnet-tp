using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public sealed class Cube: Brique
    {
        public Cube(Point3D centre, double largeur, double longueur, double hauteur) : base(centre, largeur, longueur, hauteur)
        {
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
