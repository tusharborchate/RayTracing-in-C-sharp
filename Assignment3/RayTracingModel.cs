using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class RayTracingModel
    {
        internal double angle;
        internal double[,] matrixR;
        internal double[,] matrixT;
        internal double[,] matrixRT;
        internal double[,] matrixTInv;
        internal double[,] matrixMCW;
        internal double[,] matrixRTranspose;
        internal double t;
        internal Vector v0;
        internal double fov=90;
        internal double polygondt;

        public double tpolygon { get; set; }
        public Vector pi { get; set; }
        public Sphere Sphere { get; set; }
        public Polygon Polygon { get; set; }
        public Vector VRP { get; set; }
        public Vector VPN { get; set; }
        public Vector VUP { get; set; }

        public double LightIntensity { get; set; }
        public char[,] Image { get; set; }
        public double Focal { get; set; }
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public double Ymin { get; set; }
        public double Ymax { get; set; }
        public Vector VectorP { get; set; }
        public Vector VectorL { get; set; }
        public Vector VectorO { get; set; }

        public Vector LRP { get; set; }
        public Vector LPN { get; set; }
        public Vector LUP { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }


        public Bitmap bitmap { get; set; }
        public int Color { get; internal set; }
        public double Ip { get; internal set; }
        public Vector VectorU { get; internal set; }
        public Vector VectorN { get; internal set; }
        public Vector VectorV { get; internal set; }
        public Vector VectorO1 { get; internal set; }
        public Vector VectorP1 { get; internal set; }
        public Vector VectorP0 { get; internal set; }
        public Vector L1 { get; internal set; }
        public Vector L2 { get; internal set; }
        public Vector N { get; internal set; }
        public double A { get; internal set; }
        public double B { get; internal set; }
        public double C { get; internal set; }
        public double D { get; internal set; }
    }


    public class Sphere
    {
        public Vector Center { get; set; }
        public double Radius { get; set; }
        public double Kd { get; set; }

    }

    
    public class Polygon
    {
        public Vector V0 { get; set; }
        public Vector V1 { get; set; }
        public Vector V2 { get; set; }
        public Vector V3 { get; set; }
        public Vector Normal { get; set; }
        public double Kd { get; set; }

    }

    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double W { get; set; }

        public Vector()
        {

        }
        public Vector(double a,double b,double c)
        {
            this.X = a;
            this.Y = b;
            this.Z = c;
        }
    }

}

