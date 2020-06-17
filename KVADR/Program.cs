using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVADR
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("a=");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("b=");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("c=");
                double c = double.Parse(Console.ReadLine());
                kv kv2 = new kv(a, b, c);
                Console.WriteLine(kv2.ToString());
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
