using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntuacion
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("inserte la puntuacion");
            int p=int.Parse(Console.ReadLine());
            if (p >= 100 )

            {
                System.Console.WriteLine("Tu puntuacion es alta");
            }
            else
            {
                System.Console.WriteLine("Tu puntuacion es menor");
            }
             Console.ReadKey();
        }
    }
}
