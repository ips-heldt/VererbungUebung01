using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung0.Model
{
    [Serializable]
    public class Frachter : Wasserfahrzeug
    {
        public int Ladevolumen { get; set; }

        public override void Ausgabe()
        {
            Console.WriteLine("Der Frachter hat ein Gewicht von {0} Tonnen, die Farbe ist {1}.",
                Gewicht, Farbe);
            Console.WriteLine("Der Frachter hat einen Tiefgang von {0}m und verdrängt {1} BRT.",
                Tiefgang, Brt);
            Console.WriteLine("Das Ladevolumen beträgt {0}m³.", Ladevolumen);
        }

        public override void Ablegen()
        {
            Console.WriteLine("Der Frachter legt ab");
        }

        public override void Anlegen()
        {
            Console.WriteLine("Der Frachter legt an");
        }
    }
}
