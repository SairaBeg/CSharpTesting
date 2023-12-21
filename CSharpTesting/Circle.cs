using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTesting
{
    
    public class Circle
    {
        double radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }


        public double area()
        {
            return 3.14 * Math.Pow(radius,2);
            
        }




    }
}
