using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static bool Prime(int x)
        {
            if (x == 1) return false;
            bool ok = true;
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    ok = false;
                }
            } return ok;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                int m = int.Parse(args[i]);
                if (Prime(m))
                {
                    Console.WriteLine(m);
                }

            }
        }
    }
}
