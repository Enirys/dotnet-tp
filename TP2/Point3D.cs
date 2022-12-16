using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Point3D
    {
        double x, y, z;
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Bouger(double vx, double vy, double vz)
        {
            x = x + vx;
            y = y + vy;
            z = z + vz;
        }

        public double GetX() { return x; }
        public double GetY() { return y; }
        public double GetZ() { return z; }

        public void SetX(double v) {  x = v; }
        public void SetY(double v) { y = v; }
        public void SetZ(double v) { z = v; }
        public void SetXYZ(double v1, double v2, double v3) { x = v1; y = v2; z = v3; }
    
        public Boolean Egal(Point3D p)
        {
            return (x == p.x && y == p.y && z == p.z);
        }

        public override string ToString()
        {
            return "[Point3D x: " + x + " ,y:" + y + " ,z:" + z + "]\n";
        }
    }
}
