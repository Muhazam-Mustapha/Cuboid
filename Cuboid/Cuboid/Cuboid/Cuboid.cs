using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuboid
{
    partial class Cuboid : Shape3DCalculator
    {
        private double _height;
        private double _length;
        private double _width;

        public double height
        {
            set { _height = value; }
            get { return _height; }
        }
        public double length
        {
            set { _length = value; }
            get { return _length; }
        }
        public double width
        {
            set { _width = value; }
            get { return _width; }
        }

        // Default constructor gives all zero
        public Cuboid()
        {
            height = 0;
            length = 0;
            width = 0;
        }

        // Constructor that gives each value
        public Cuboid(double _height, double _length, double _width)
        {
            height = _height;
            length = _length;
            width = _width;
        }

        public void ShowAllProperties()
        {
            Console.WriteLine("Height={0}, Length={1}, Width={2}", height, length, width);
        }

        public double Volume()
        {
            return _height * _length * _width;
        }

        public double SurfaceArea()
        {
            return 2 * (_height * _width + _height * _length + _width * _length);
        }
    }
}
