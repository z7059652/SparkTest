using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AdCenter.BI.UET.Schema;
using System.IO;
using Microsoft.Bond;
using SparkSchema;

namespace googleAcpc
{
    class TestClickSummary
    {
        private string filename = @"D:\UserAdActivity\UETUserId_SearchClickActivitySummary_20160811Binary.csv";

        public List<IBondSerializable> Start()
        {
            Inputer input = new Inputer(filename);
            string data;
            List<IBondSerializable> vec = new List<IBondSerializable>();
            while((data = input.ReadLine()) != null)
            {
                if (data.StartsWith("#"))
                    continue;
                string[] arr = data.Split('\t');
                if(arr.Length != 2)
                    break;
                Guid uetId = Guid.Parse(arr[0]);
                UserSearchClickSummary uss = new UserSearchClickSummary();
                var payload = Convert.FromBase64String(arr[1]);
                using (var ms = new MemoryStream(payload))
                {
                    using (var protocolReader = new CompactBinaryProtocolReader(ms))
                    {
                        uss.Read(protocolReader);
                    }
                }
                vec.Add(uss);
                IBondSerializable val = uss;
                UserSearchClickSummarySpark uscs = (UserSearchClickSummarySpark)val;
            }
            return vec;
        }

        public UserAdActivitySummary getUserAdSummary(string filename)
        {
            BinaryRead br = new BinaryRead();
            var payload = br.read(filename);
            UserAdActivitySummary uss = new UserAdActivitySummary();
            using (var ms = new MemoryStream(payload))
            {
                using (var protocolReader = new CompactBinaryProtocolReader(ms))
                {
                    uss.Read(protocolReader);
                }
            }
            return uss;
        }
    }
}
