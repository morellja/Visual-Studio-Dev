using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.ToString());
            Console.OpenStandardOutput();
            Console.WriteLine("Jerrycakes");
            Console.WriteLine(args.ToString());

            System.Threading.Thread.Sleep(4000);
        }
    }
}
