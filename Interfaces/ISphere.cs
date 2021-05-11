using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISphere
    {
        int X0 { get; set; }
        int Y0 { get; set; }
        int Z0 { get; set; }
        int R { get; set; }

        void SphereStats();

    }
}
