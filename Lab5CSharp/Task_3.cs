using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
namespace Task_3
{
    public class Task_3
    {
        abstract class Function
        {
            abstract public double Count(double x);
        }

        class Line : Function
        {
            protected float a;
            protected float b;

            public Line(float a, float b)
            {
                this.a = a; this.b = b;
            }

            public override double Count(double x) //перевизначення абстрактного методу
            {
                return a * x + b;
            }


        }

        class Quadratic : Function
        {
            protected float a;
            protected float b;
            protected float c;

            public Quadratic(float a, float b, float c)
            {
                this.a = a; this.b = b; this.c = c;
            }

            public override double Count(double x) //перевизначення абстрактного методу
            {
                return a * Math.Pow(x, 2) + b * x + c;
            }
        }

        class Hyperbola : Function
        {
            protected float k;

            public Hyperbola(float k)
            {
                this.k = k;
            }

            public override double Count(double x) //перевизначення абстрактного методу
            {
                return k / x;
            }
        }
        public void main3()
        {
        Line line1 = new Line(3, 4);
            Console.WriteLine(line1.Count(8));

            Quadratic quadratic1 = new Quadratic(2, 3, 4);
            Console.WriteLine(quadratic1.Count(4.2));

            Hyperbola hyperbola1 = new Hyperbola(16);
            Console.WriteLine(hyperbola1.Count(3.2));
        }
    }
}