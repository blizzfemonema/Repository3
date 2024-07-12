using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilizarea_Clasei_Statice
{
    class Test
    {
        static void Main()
        {
            string cod1 = Helper.GenerareCodUnic("A");
            string cod2 = Helper.GenerareCodUnic("B");
            string cod3 = Helper.GenerareCodUnic("C");

            Console.WriteLine($"Generare cod 1: {cod1}");
            Console.WriteLine($"Generare cod 2: {cod2}");
            Console.WriteLine($"Generare cod 3: {cod3}");
        }   
    }
}
