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

        public Fyrkant()
        {
            this.Side = 6;
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
        public double Width { get; set; }

        public Rektangel()
        {
            this.Length = 4;
            this.Width = 5;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override void output()
        {
            Console.WriteLine("Arean på rektangeln är = " + this.Area());
        }
    }
    
    public class Cirkel : Teckning
    {
        public double Radius { get; set; }

        public Cirkel()
        {
            this.Radius = 2;
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
            Cirkel U1 = new Cirkel();
            U1.output();

            Rektangel U2 = new Rektangel();
            U2.output();

            Fyrkant U3 = new Fyrkant();
            U3.output();

            



            Console.ReadKey();
        }
    }
}
