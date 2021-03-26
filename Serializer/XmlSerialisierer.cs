using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vererbung0.Model;

namespace Vererbung0
{
    /// <summary>
    /// Spezialisierte Klasse für die XML Serialisierung
    /// </summary>
    class XmlSerialisierer : BaseSerialisierer
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public XmlSerialisierer() : this(new Type[] {typeof(Fahrzeug), typeof(Frachter), typeof(Flugzeug)}) { }
        public XmlSerialisierer(Type[] types)
        {
            serializer = new XmlSerializer(typeof(List<Fahrzeug>), types);
        }

        /// <summary>
        /// Implementiert die Methode zum Serialisieren, für den XML
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="fahrzeuge"></param>
        public override void Serialisiere(Stream stream, List<Fahrzeug> fahrzeuge)
        {
            (serializer as XmlSerializer).Serialize(stream, fahrzeuge);
        }

        /// <summary>
        /// Implementiert die Methode zum Deserialisieren, für den XML
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public override List<Fahrzeug> Deserialisiere(Stream stream)
        {
            return (serializer as XmlSerializer).Deserialize(stream) as List<Fahrzeug>;
        }
    }
}
