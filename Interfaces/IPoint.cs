using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPoint
    {
        int X { get; set; }
        int Y { get; set; }
        int Z { get; set; }

        void PointCoordinates();
    }
}
