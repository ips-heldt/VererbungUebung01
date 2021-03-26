using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vererbung0.Model
{
    /// <summary>
    /// Diese Klasse repräsentiert nun ein ganz konkretes Fahrzeug, sie hat daher
    /// auch ganz konkrete Eigenschaften / Methoden und muss nun auch alle abstrakten
    /// Methoden implementieren.
    /// </summary>
    [Serializable]
    public class Hubschrauber : Luftfahrzeug
    {
        public int RotorDurchmesser { get; set; }

        public override void Ausgabe()
        {
            Console.WriteLine("Der Hubschrauber hat ein Gewicht von {0} Tonnen, die Farbe ist {1}.",
                Gewicht, Farbe);
            Console.WriteLine("Der Hubschrauber hat {0} Triebwerke und eine maximale Flughöhe von {1} Meter.",
                AnzahlTriebwerke, Flughoehe);
            Console.WriteLine("Der Rotodurchmesser beträgt {0}m.", RotorDurchmesser);
        }

        public new void Abheben()
        {
            Console.WriteLine("Der Hubschrauber hebt ab");
        }

        public override void Landen()
        {
            Console.WriteLine("Der Hubschrauber landet");
        }
    }
}
