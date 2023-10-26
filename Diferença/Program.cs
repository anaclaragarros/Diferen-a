using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diferença
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                int d = Convert.ToInt32(Console.ReadLine());
                string diferenca = $"DIFERENCA = {(a * b - c * d)}";
                Console.WriteLine(diferenca);

            }
        }
}
