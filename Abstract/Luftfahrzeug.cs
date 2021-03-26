using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vererbung0.Model;

namespace Vererbung0
{
    [Serializable]
    [XmlInclude(typeof(Flugzeug)), XmlInclude(typeof(Hubschrauber))]
    public abstract class Luftfahrzeug : Fahrzeug
    {
        public int Flughoehe { get; set; }
        public int AnzahlTriebwerke { get; set; }

        // Methode kann in abgeleiteten Klassen überschieben werden
        // oder es kann diese verwendet werden
        public virtual void Abheben()
        {
            Console.WriteLine("Das Luftfahrzeug hebt ab");
        }

        // Methode kann in abgeleiteten Klassen überschieben werden
        // oder es kann diese verwendet werden
        public virtual void Landen()
        {
            Console.WriteLine("Das Luftfahrzeug landet");
        }
    }
}
