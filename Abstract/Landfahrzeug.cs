using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung0
{
    [Serializable]
    public abstract class Landfahrzeug : Fahrzeug
    {
        public bool Allrad { get; set; }
        public int Achsen { get; set; }

        // Methode kann in abgeleiteten Klassen überschieben werden
        // oder es kann diese verwendet werden
        public virtual void Losfahren()
        {
            Console.WriteLine("Das Landfahrzeug fährt los");
        }

        // Methode kann in abgeleiteten Klassen überschieben werden
        // oder es kann diese verwendet werden
        public virtual void Anhalten()
        {
            Console.WriteLine("Das Landfahrzeug hält an");
        }
    }
}
