using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, f;
            x = Convert.ToDouble(Console.ReadLine());
            f = 3 * Math.Sin(x + 2);
            Console.WriteLine(f);
        }
    }
}
