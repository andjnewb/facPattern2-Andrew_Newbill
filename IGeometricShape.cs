using System;
using System.Collections.Generic;
using System.Text;

namespace facPattern2_Andrew_Newbill_
{
    public interface IGeometricShape
    {
        void draw();
    }

    public class Line : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("-------------------------");
        }
    }

    public class Circle : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("        . -- ~~~ -- .");
            Console.WriteLine("     .-~               ~-.");
            Console.WriteLine("   /                         \\");
            Console.WriteLine("  /                           \\");
            Console.WriteLine(" |                             |");
            Console.WriteLine(" |                             |");
            Console.WriteLine(" |                             |");
            Console.WriteLine(" \\                            /");
            Console.WriteLine("  \\                          /");
            Console.WriteLine("   \\                        /");
            Console.WriteLine("    `-.                   .-'");
            Console.WriteLine("        ~- . ___ . -~");


        }
    }

    public class Rectangle : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
        }
    }

}
