using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteTesting
{
    class Testing
    {
        static void Main()
        {
            Carte carte = new Carte("The girl on the train", "Paula Hawkins", 2015, 395);
            carte.AfisareDetalii();
        }
    }
}
