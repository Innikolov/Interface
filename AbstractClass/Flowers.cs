using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Flowers : Plants
    {
        public string Name { get; set; }
        public override string Type
        {
            get
            {
                return "flower";
            }
        }

        public void WaterTheFlower()
        {
            Console.WriteLine($"You watered the {this.Name}, and it grew 1 cm. Now its {this.Size + 1} cm!");
        }
    }
}
