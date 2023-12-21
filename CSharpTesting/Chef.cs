using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTesting
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("Making chimkin");
        }

        public virtual void SpecialDish()
        {
            Console.WriteLine("Making cheesy bread");
        }
    }
}
