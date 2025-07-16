using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_OOP04
{
    internal class Circle : ICircle
    {
        public double Radius {  get; set; }
        public double Area =>  Math.PI * Radius*Radius;

        double IShape.Area { get => Area; set => throw new NotImplementedException(); }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

       public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape: Circle");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {Area:F2}");
        }


    }
}
