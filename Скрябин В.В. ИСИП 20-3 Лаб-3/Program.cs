using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 9;
            int z = 20;
            int v = 200;

            min(x, y);

            min(z + x + y, v);

            Console.ReadLine();
        }

        public static void min(int a, int b)
        {
            Console.WriteLine(a > b ? $"{a} больше чем {b}" : $"{a} меньше чем {b}");
        }
    }
}
