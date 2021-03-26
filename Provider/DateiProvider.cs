using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung0
{
    class DateiProvider : BaseProvider
    {
        public static string FileName = null;

        public DateiProvider(string fileName)
        {
            FileName = Environment.CurrentDirectory + @"\" + fileName;
        }

        public override void Close()
        {
            stream.Close();
        }

        public override void Open()
        {
            stream = new FileStream(FileName, FileMode.OpenOrCreate);
        }
    }
}
