using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
                if (i <= 10)
                {
                    Console.WriteLine((n + " " + "x" + " " + i + " " + "=") + " " + n * i);
                }
            }
        }
    }
}
