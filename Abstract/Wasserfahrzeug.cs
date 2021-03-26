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
    [XmlInclude(typeof(Frachter))]
    public abstract class Wasserfahrzeug : Fahrzeug
    {
        public decimal Tiefgang { get; set; }
        public int Brt { get; set; }

        // Methode kann in abgeleiteten Klassen überschieben werden
        // oder es kann diese verwendet werden
        public virtual void Ablegen()
        {
            Console.WriteLine("Das Wasserfahrzeug legt ab");
        }

        // Methode kann in abgeleiteten Klassen überschieben werden
        // oder es kann diese verwendet werden
        public virtual void Anlegen()
        {
            Console.WriteLine("Das Wasserfahrzeug legt an");
        }
    }
}
