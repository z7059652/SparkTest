using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace googleAcpc
{
    class BinaryRead
    {
        public byte[] read(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            return br.ReadByteArray();
        }
    }
}
