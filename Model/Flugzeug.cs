using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung0.Model
{
    [Serializable]
    public class Flugzeug : Luftfahrzeug
    {
        public int Spannweite { get; set; }

        public override void Ausgabe()
        {
            Console.WriteLine("Das Flugzeug hat ein Gewicht von {0} Tonnen, die Farbe ist {1}.",
                Gewicht, Farbe);
            Console.WriteLine("Das Flugzeug hat {0} Triebwerke und eine maximale Flughöhe von {1} Meter.",
                AnzahlTriebwerke, Flughoehe);
            Console.WriteLine("Die Spannweite beträgt {0}m.", Spannweite);
        }

        public override void Abheben()
        {
            Console.WriteLine("Das Flugzeug hebt ab");
        }

        public override void Landen()
        {
            Console.WriteLine("Das Flugzeug landet");
        }
    }
}
