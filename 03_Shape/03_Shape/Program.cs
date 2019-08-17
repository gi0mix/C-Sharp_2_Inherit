using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Polymorphic Exercise");
            Hexagon hex = new Hexagon("Beth");
            hex.Draw();

            Circle cir = new Circle("Cindy");
            //Calls base class Implementation!
            cir.Draw();
            Console.ReadLine();

            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Micky"), new Circle("Mike") };

            foreach(Shape s in myShapes)
            {
                s.Draw();
            }

            Console.ReadLine();

            ThreeDCircle o = new ThreeDCircle();
            o.Draw();

            ((Circle)o).Draw();
            Console.WriteLine();
        }
    }
}
