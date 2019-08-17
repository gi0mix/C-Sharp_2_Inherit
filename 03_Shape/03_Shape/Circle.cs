using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Shape
{
    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Circle {0} is getting Drawed", PetName);
        }
    }
}
