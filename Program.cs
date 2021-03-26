using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vererbung0.Model;

namespace Vererbung0
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Daten
            Flugzeug flugzeug = new Flugzeug()
            {
                Gewicht = 23,
                Farbe = "weiß",
                Spannweite = 34
            };
            Hubschrauber hubschrauber = new Hubschrauber()
            {
                Gewicht = 3.5m,
                Farbe = "grün",
                RotorDurchmesser = 8
            };
            Frachter frachter = new Frachter()
            {
                Gewicht = 34000,
                Farbe = "schwarz",
                Brt = 48000,
                Tiefgang = 3.5M,
                Ladevolumen = 30000
            };
            #endregion Daten

            // Eine Fahrzeugliste erzeugen
            List<Fahrzeug> fahrzeugs = new List<Fahrzeug>()
            {
                flugzeug, hubschrauber, frachter
            };

            // binär
            DataHandler data = new DataHandler(new DateiProvider("liste.dat"), new BinarySerialisierer());
            data.SetData(fahrzeugs);
            fahrzeugs = data.GetData();
            Ausgabe(fahrzeugs, SerializerTyp.Binary);

            // xml
            data = new DataHandler(new DateiProvider("liste.xml"), new XmlSerialisierer());
            data.SetData(fahrzeugs);
            fahrzeugs = data.GetData();
            Ausgabe(fahrzeugs, SerializerTyp.Xml);

            // soap
            data = new DataHandler(new DateiProvider("liste.soap"), new BinarySerialisierer());
            data.SetData(fahrzeugs);
            fahrzeugs = data.GetData();
            Ausgabe(fahrzeugs, SerializerTyp.Soap);

            Console.ReadKey();
        }

        static void Ausgabe(List<Fahrzeug> fahrzeugs, SerializerTyp typ)
        {
            Console.WriteLine("{0}\n{1} Liste\n{2}", new String('-', 45), typ, new String('-', 45));
            foreach(Fahrzeug fahrzeug in fahrzeugs)
            {
                fahrzeug.Ausgabe();
            }
        }
    }
}
