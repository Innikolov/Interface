using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Point : IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public void PointCoordinates()
        {
            Console.WriteLine($"This point's coordinates are: ({this.X},{this.Y},{this.Z}).");
        }
    }
}
