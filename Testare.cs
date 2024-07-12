using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatii_student
{
    class Testare
    {
        static void Main()
        {
            Student studentOriginal = new Student("Ana Georgescu", 21, "Electrical Engineering");
            Student studentCopie = new Student(studentOriginal);

            Console.WriteLine("Informatiile despre primul student: ");
            studentOriginal.AfisareDetalii();

            Console.WriteLine("Copierea informatiilor primului student: ");
            studentCopie.AfisareDetalii();
        }
    }
}
