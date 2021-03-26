using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung0
{
    class DataHandler
    {
        private BaseSerialisierer serialisierer;
        private BaseProvider provider;

        public BaseSerialisierer Serialisierer
        {
            get => default(BaseSerialisierer);
            set => serialisierer = value;
        }

        public BaseProvider Provider
        {
            get => default(BaseProvider);
            set => provider = value;
        }

        public DataHandler(BaseProvider provider, BaseSerialisierer serialisierer)
        {
            this.provider = provider;
            this.serialisierer = serialisierer;
        }

        public List<Fahrzeug> GetData()
        {
            return serialisierer.Deserialisiere(provider.Stream);
        }

        public void SetData(List<Fahrzeug> fahrzeuge)
        {
            serialisierer.Serialisiere(provider.Stream, fahrzeuge);
        }
    }
}
