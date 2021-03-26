using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung0
{
    /// <summary>
    /// Spezialisierte Klasse für die binäre Serialisierung
    /// </summary>
    class BinarySerialisierer : BaseSerialisierer
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public BinarySerialisierer()
        {
            serializer = new BinaryFormatter();
        }

        /// <summary>
        /// Implementiert die Methode zum Serialisieren, für die binäre Serialisierung
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="fahrzeuge"></param>
        public override void Serialisiere(Stream stream, List<Fahrzeug> fahrzeuge)
        {
            (serializer as BinaryFormatter).Serialize(stream, fahrzeuge);
        }

        /// <summary>
        /// Implementiert die Methode zum Deserialisieren, für die binäre Serialisierung
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public override List<Fahrzeug> Deserialisiere(Stream stream)
        {
            return (serializer as BinaryFormatter).Deserialize(stream) as List<Fahrzeug>;
        }
    }
}
