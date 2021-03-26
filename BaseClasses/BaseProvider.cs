using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung0
{
    abstract class BaseProvider
    {
        protected FileStream stream = null;

        public FileStream Stream
        {
            get
            {
                if (stream == null)
                    Open();
                else
                    stream.Seek(0, SeekOrigin.Begin);
                return stream;
            }
        }

        public abstract void Close();
        public abstract void Open();
    }
}
