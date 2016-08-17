using Microsoft.AdCenter.BI.UET.Schema;
using Microsoft.Bond;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace googleAcpc
{
    [Serializable]
    public class KPIIView
    {
        public string RGUID;
        public DateTime Delta;
        public string ClientIP;
        public string ClientIPv6;
        public string SurrogateKey;
        public string UserId;
        public string AnalyticsGUID;
        public string QueryPhrase;
        public string NonNormalizedQueryString;
        public string ClickId;
        public string Latitude;
        public string Longitude;
        public string ClientId;
        public string AnonymousId;
        public string DATASET;
        public Guid CID;
        public Guid MUID;
        public Guid MUIDAutoGen;
        public KPIIView()
        {

        }
        public KPIIView(string data)
        {
//            data = data.Substring(1, data.Length - 2);
            string[] values = data.Split('\t');
            this.RGUID = values[0];
            this.Delta = DateTime.Parse(values[1]);
            this.ClientIP = values[2];
            this.ClientIPv6 = values[3];
            this.SurrogateKey = values[4];
            this.UserId = values[5];
            this.AnalyticsGUID = values[6];
            this.QueryPhrase = values[7];
            this.NonNormalizedQueryString = values[8];
            this.ClickId = values[9];
            this.Latitude = values[10];
            this.Longitude = values[11];
            this.ClientId = values[12];
            this.AnonymousId = values[13];
            this.DATASET = values[14];
            this.CID = Guid.Parse(values[15]);
            this.MUID = Guid.Parse(values[16]);
            this.MUIDAutoGen = Guid.Parse(values[17]);
        }
    }

    [Serializable()]
    public class IStringSerialize
    {
        public IStringSerialize()
        { 
        }
        public virtual string SerializeObject()
        {
            return JsonConvert.SerializeObject(this);
        }

        public virtual IStringSerialize DeserializeObject(string line)
        {
            Type types = this.GetType();
            return (IStringSerialize)JsonConvert.DeserializeObject(line, types);
        }
    }

    [Serializable()]
    public static class IExtend
    {
        public static T DeserializeObject<T>(this string line) where T : IBondSerializable, new()
        {
            T a = new T();
            var payload = Convert.FromBase64String(line);
            using (var ms = new MemoryStream(payload))
            {
                //ms.Seek(12, SeekOrigin.Begin);
                using (var protocolReader = new MafiaBinaryProtocolReader(ms))
                {
                    a.Read(protocolReader);
                }
            }
            return a;
            
            //return (T)a.DeserializeObject(line);
        }
        public static T DeserializeObject<T>(this byte[] line) where T : IBondSerializable, new()
        {
            T a = new T();
            using (var ms = new MemoryStream(line))
            {
                using (var protocolReader = new CompactBinaryProtocolReader(ms))
                {
                    a.Read(protocolReader);
                }
            }
            return a;

            //return (T)a.DeserializeObject(line);
        }
        public static string SerializeObject(this IBondSerializable value)
        {
            byte[] result;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CompactBinaryProtocolWriter compactBinaryProtocolWriter = new CompactBinaryProtocolWriter(memoryStream))
                {
                    ((IBondSerializable)value).Write(compactBinaryProtocolWriter);
                    result = memoryStream.ToArray();
                }
            }
            string str = Convert.ToBase64String(result);
            return str;
        }

    }

    public class PaidSearch : IStringSerialize
    {
        public Guid UETUserId;
        public UETUserIdType UetUserIdType;

        [JsonConverter(typeof(MyConvert))]
        public List<UserAdActivityDetail> UserAdActivities;
        public DateTime ClickDateTime;

        [JsonConverter(typeof(MyConvert))]
        public SearchClickDetail SeaClickDetail;

        public PaidSearch()
        { 
        }

    }

    public class MyConvert: JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IBondSerializable);
        }


        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.String)
                return null;
            var payload = Convert.FromBase64String(reader.Value.ToString());
            IBondSerializable scd = (IBondSerializable)Activator.CreateInstance(objectType);
            using (var ms = new MemoryStream(payload))
            {
                using (var protocolReader = new CompactBinaryProtocolReader(ms))
                {
                    scd.Read(protocolReader);
                }
            }
            return scd;
        }


        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if(value == null)
            {
                writer.WriteNull();
                return; 
            }
            byte[] result;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CompactBinaryProtocolWriter compactBinaryProtocolWriter = new CompactBinaryProtocolWriter(memoryStream))
                {
                    ((IBondSerializable)value).Write(compactBinaryProtocolWriter);
                    result = memoryStream.ToArray();
                }
            }
            string str = Convert.ToBase64String(result);
            writer.WriteValue(str); 
        }
    }

}
