using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vererbung0
{
    public enum SerializerTyp
    {
        Xml,
        Soap,
        Binary
    }

    /// <summary>
    /// Die Definition eines Standard Serialisierers, der nur 2 Methoden
    /// zum Serialisieren und Deserialisieren beinhaltet. Das heißt, alle
    /// von ihm abgeleiteten Klassen müssen diese Methode implementieren
    /// und auf die jeweilige spezielle Art umsetzen.
    /// </summary>
    abstract class BaseSerialisierer
    {
        protected object serializer = null;

        public abstract void Serialisiere(Stream stream, List<Fahrzeug> fahrzeuge);
        public abstract List<Fahrzeug> Deserialisiere(Stream stream);
    }
}
