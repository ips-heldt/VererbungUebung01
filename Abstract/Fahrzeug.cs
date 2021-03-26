using System;

namespace Vererbung0
{
    /// <summary>
    /// Dies ist die Basisklasse aller Fahrzeuge, sie besitzt alle im Kontext
    /// notwendigen Eigenschaften und Methoden. Sie ist abstract definiert, da
    /// es von Ihr keine eigenständige Instanz geben darf.
    /// </summary>
    [Serializable]
    public abstract class Fahrzeug
    {
        public decimal Gewicht { get; set; }
        public string Farbe { get; set; }

        // alle abgeleiteten Klassen müssen diese Methode implementieren
        public abstract void Ausgabe();
    }
}
