using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung0
{
    /// <summary>
    /// Spezialisierte Klasse für die SOAP Serialisierung
    /// </summary>
    class SoapSerialisierer : BaseSerialisierer
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public SoapSerialisierer()
        {
            serializer = new SoapFormatter();
        }

        /// <summary>
        /// Implementiert die Methode zum Serialisieren, für den SOAP
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="fahrzeuge"></param>
        public override void Serialisiere(Stream stream, List<Fahrzeug> fahrzeuge)
        {
            (serializer as SoapFormatter).Serialize(stream, ListToArray(fahrzeuge));
        }

        /// <summary>
        /// Implementiert die Methode zum Deserialisieren, für den SOAP
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public override List<Fahrzeug> Deserialisiere(Stream stream)
        {
            return ArrayToList((serializer as SoapFormatter).Deserialize(stream)) as List<Fahrzeug>;
        }

        /// <summary>
        /// Wandelt einen List Typ in ein Array um. Wird benötigt, da der SOAP keine
        /// Listen serialisieren kann.
        /// </summary>
        /// <param name="objectList"></param>
        /// <returns></returns>
        private object[] ListToArray(List<Fahrzeug> objectList)
        {
            object[] result = new object[objectList.Count];

            for (int i = 0; i < objectList.Count; i++) result[i] = objectList[i];

            return result;
        }

        /// <summary>
        /// Wandelt ein Array in eine Liste von Typ List<Fahrzeug> um.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private List<Fahrzeug> ArrayToList(object array)
        {
            List<Fahrzeug> fahrzeugs = new List<Fahrzeug>();

            foreach (object o in (array as object[])) { fahrzeugs.Add((Fahrzeug)o); }

            return fahrzeugs;
        }
    }
}
