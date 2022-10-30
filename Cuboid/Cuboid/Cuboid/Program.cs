using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuboid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuboid aCuboid = new Cuboid();

            aCuboid.ShowAllProperties();

            aCuboid.height = 10;
            aCuboid.width = 40;

            aCuboid.ShowAllProperties();

            Cuboid cuboid2 = new Cuboid(30, 40, 55);
            cuboid2.ShowAllProperties();
            cuboid2.width = 50;
            cuboid2.ShowAllProperties();

            Console.WriteLine("Volume of cuboid2 = {0}", cuboid2.Volume());
            Console.WriteLine("Surface area of cuboid2 = {0}", cuboid2.SurfaceArea());

            Console.ReadKey();
        }
    }

    interface Shape3DCalculator
    {
        double Volume();
        double SurfaceArea();
    }
}
