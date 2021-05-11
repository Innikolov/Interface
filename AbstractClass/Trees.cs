using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Trees : Plants
    {
        public string TreeType { get; set; }

        public virtual void SitAndRelax()
        {
            Console.WriteLine("Its a hot summer day, pull a chair and read a book under the shadow of the trees!");
        }
    }
}
