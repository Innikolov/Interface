using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Plants : IComparable<Plants>
    {
        public abstract string Type { get; }
        public int Size { get; set; }

        public int CompareTo(Plants other)
        {
            return this.Size.CompareTo(other.Size);
        }

        public override string ToString()
        {
            string ThisString = "This Plant is a/an " + this.Type + " and is " + this.Size + " cm big!";
            return base.ToString();
        }
    }
}
