using System;
using System.Collections.Generic;

namespace Labb_3_OOP__Polymorphism_
{
    public class Teckning
    {
        
        public virtual double Area()
        {
            return 0;
        }

        public virtual void output()
        {
            Console.WriteLine("Arean på formen är = ");
        }
    }




    public class Fyrkant : Teckning
    {
        public double Side { get; set; }

        public Fyrkant(double side)
        {
            this.Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override void output()
        {
            Console.WriteLine("Arean på fyrkanten är = " + this.Area());
        }
    }

    public class Rektangel : Teckning
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Rektangel(double length, double breadth)
        {
            this.Length = length;
            this.Breadth = breadth;
        }

        public override double Area()
        {
            return Length * Breadth;
        }

        public override void output()
        {
            Console.WriteLine("Arean på rektangeln är = " + this.Area());
        }
    }
    
    public class Cirkel : Teckning
    {
        public double Radius { get; set; }

        public Cirkel(double radius)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void output()
        {
            Console.WriteLine("Arean på cirkeln är = " + this.Area());
        }
    }
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Cirkel U1 = new Cirkel(4);
            U1.output();

            Rektangel U2 = new Rektangel(4,4);
            U2.output();

            Fyrkant U3 = new Fyrkant(5);
            U3.output();

            



            Console.ReadKey();
        }
    }
}
