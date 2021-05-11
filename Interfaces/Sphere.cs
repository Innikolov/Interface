using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Sphere : ISphere
    {
        public int X0 { get; set; }
        public int Y0 { get; set; }
        public int Z0 { get; set; }
        public int R { get; set; }

        public void SphereStats() 
        {
            Console.WriteLine($"This sphere's center coordinates are: ({this.X0},{this.Y0},{this.Z0}) and its radius is {this.R}");
        }
    }
}
