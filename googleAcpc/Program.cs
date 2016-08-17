using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AdCenter.BI.UET.Schema;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using Microsoft.AdCenter.BI.UET.Common.Helpers;
using Microsoft.BI.CFR;
using SparkSchema;
using Microsoft.Bond;

namespace googleAcpc
{

    class Program
    {
        //static void test()
        //{
        //    var a = new KeyValuePair<string, int>("a", 1);
        //    var b = new KeyValuePair<string, int>("a", 1);
        //    if(a == b)

        //}
        private const string SearchClickLimit = "-1";
        private const string PaidSearchstr = "PaidSearch";
        private static string[] para = new string[2] { SearchClickLimit, PaidSearchstr };
        static void Main(string[] args)
        {
            string brfile = @"D:\UserAdActivity\summaryBinary";
            TestClickSummary scs = new TestClickSummary();
            scs.Start();
            return;
            Inputer input = null;
            Inputer resInput = null;
//            try
            {
                string KPIIView = @"D:\ClickUserAdActivity_2016071800\KPIIView.csv";
                string filename = @"D:\ClickUserAdActivity_2016071800_res\Click_UETUserId_UserAdActivitySummary_2016071800_Cosmos.csv";
                string filenameRes = @"D:\ClickUserAdActivity_2016071800_res\Click_UETUserId_UserAdActivitySummary_2016071800_Spark.csv";//UserAd
                string UserIdRecord = @"D:\ClickUserAdActivity_2016071800_res\UserAd.csv";//
                string outfilename = @"D:\UserAdActivity\str.txt";
                string saClickview = @"D:\UserAdActivity\SAClickView.csv";//
                Dictionary<Guid, string> dic = new Dictionary<Guid, string>();
                string sstr = "CgXk1aq+CSTYnwNE55UBZoy1/9qUvNrHQgApIGVjZDA4ZTdhYjE2NDQyMDBiOGVmYTI1MjExNDZiYjkyUYCGhrq+ptfTEWprDrkFCAAAAPtv3/v3//8PYwAUEHAbDwAgNzYzMzBlN2VjMTJkNDVlMjlhZDMxODAzYTgxZjIyOGEA/////////////////////xJTKQCAwaDzma7TCAAAAAAAAAAAAACTgcDoAQAgaHR0cDovL3d3dy5qZ28uY29tLmhrL2NvdXJzZS9pZmEAAAAAAAAAABBNYXhfVGltZV9FbGFwc2VkC0NsaWNrIEZyYXVkAQECgcqKVycAAAB7AwAAAAAAAAAAAAAAAAAAD0hLMlNDSDAxMDE4MTUzMwHeklySGgAAAL0bBwAgREU2NzQ2RkI2QTkyQTg5OEI1NDlENEI4RUUxQTYwMUMgNGRjM2VjNDlhNTkxZTAwMDkyOTFhYmNiZGIxYzUyMDkgMDliN2E4ZWRjNGYzYmIwMTQyZjEzOTMxYzQ5MmZlZjQQAAAAio0/1wAAAAAAgCt2nq7TCIDBoPOZrtMIwQFodHRwOi8vMjcwODI0Mi5yLm1zbi5jb20vP2xkPUJ2Qm9GLTZ5a2J2OGJQZHBJVEtJYVlOVFZVQ1V4aEc2cG1wOWdKVnFaeGNObm12Y0taN1FLQzAwUUZNRjhNc3I2MEFjV1kxMkhzcXdTYjBIT0FxTWk4X3lBdGt3a25US2RkOTJBZzduZUlXT2d5blZKX2k0RDc2VTZ0NXVZUnVSZzMxSXdTZ2cmdT13d3cuamdvLmNvbS5oay9jb3Vyc2UvaWZhAAAAAAAAAAAACAAAAAIAAADu++77P01vemlsbGEvNS4wIChjb21wYXRpYmxlOyBNU0lFIDkuMDsgV2luZG93cyBOVCA2LjE7IFRyaWRlbnQvNS4wKQAA+O7JM7MEiEQbS7fvqvknRKp4ckRGALcuCA2oMKJXOHqe+q0LrEnVcjx4X8EKb00p2y9aTjqdJkqr8I7zdrrV/IsO2gICAAAA/x8AEDcDAAAcODIyOzgxNTs4MDM7ODE1OzgxNTsxLjExLjAuMP8OLTE7LTE7LTE7LTE7LTHQABMyMDg7MjA4OzIwODsyMDg7MjA4AAAOAOYB5wEJBlMGlgahBkEHoQfPB9oH2wfmB+cH+AcDMjA4EzIwODsyMDg7MjA4OzIwODsyMDgAAAAAAADwv8kBLTE7LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8LTF8OTk4M3w5OTE2fC0xfC0xfC0xfC0xfC0xfC0xfC0xfC0xfC0xfC0xOy0xOy0xOy0xAAA=";

                byte[] bt = Convert.FromBase64String("hello,world");
                string sbt = Convert.ToBase64String(bt);
                GUID gu = new GUID(Guid.Empty);
                if (gu.MemberwiseCompare(new GUID(Guid.Empty)) == true)
                    Console.WriteLine("no equal");
                SAClickSpark CS = sstr.DeserializeObject<SAClickSpark>();
                Console.WriteLine(CS.ToString());
                input = new Inputer(saClickview);
                var output = new Outputer(outfilename);
                string data = "";
                int count = 0;
                PaidSearchSpark pss = new PaidSearchSpark();
                var sac = new SAClick();
                while((data = input.ReadLine()) != null)
                {
                    if (data.StartsWith("#"))
                        continue;
                    string[] values = data.Split('\t');
                    sac.RGUID = values[0];
                    sac.ClickId = values[1];
                    sac.Timestamp = DateTime.Parse(values[2]);
                    sac.PageView = PageViewRecord.Deserialize(Convert.FromBase64String(values[3]));
                    sac.AdImpression = AdImpressionRecord.Deserialize(Convert.FromBase64String(values[4]));
                    sac.ClickRecord = ClickRecord.Deserialize(Convert.FromBase64String(values[5]));
                    sac.FraudInfo = FraudInfoRecord.Deserialize(Convert.FromBase64String(values[6]));

                    break;
                    // Set the SearchClickDetail output column
                    var scd = new SearchClickDetailSpark();

                    // Set the PSCFRClickData property of the SearchClickDetail
                    var pageView = (PageViewRecord)sac.PageView;
                    var adImpression = (AdImpressionRecord)sac.AdImpression;
                    var clickRecord = (ClickRecord)sac.ClickRecord;
                    var fir = (FraudInfoRecord)sac.FraudInfo;

                    var bPV = pageView.Serialize();
                    var bClick = clickRecord.Serialize();
                    var bAdImpression = adImpression.Serialize();
                    byte[] bFraudInfo = null;

                    var cfrSearchObjects = new PSCFRData()
                    {
                        Click = new Microsoft.Bond.BondBlob(bClick),
                        AdImpression = new Microsoft.Bond.BondBlob(bAdImpression),
                        FraudInfo = null,
                        PageView = new Microsoft.Bond.BondBlob(bPV)
                    };

                    var sccd = new SearchClickDetail();
                    sccd.PSCFRClickData = cfrSearchObjects;

                    var cfs = new PSCFRSpark()
                    {
                        Click = new Microsoft.Bond.BondBlob(bClick),
                        AdImpression = new Microsoft.Bond.BondBlob(bAdImpression),
                        FraudInfo = new Microsoft.Bond.BondBlob(bFraudInfo),
                        PageView = new Microsoft.Bond.BondBlob(bPV)
                    };

                    scd.PSCFRClickData = cfs;

                    PageViewRecord psfdsfsfsa = PageViewRecord.Deserialize(cfrSearchObjects.PageView.Data.Array);
                    PaidSearch ps = new PaidSearch();
                    ps.ClickDateTime = sac.Timestamp;
                    ps.UETUserId = Guid.Parse(sac.RGUID);
                    ps.UetUserIdType = UETUserIdType.AnalyticsGUID;
                    ps.SeaClickDetail = sccd;

                    string ss = JsonConvert.SerializeObject(ps);

                    pss.ClickDateTime = sac.Timestamp.Ticks;
                    var guid = CommonUtils.ParseGuid(sac.RGUID);
                    pss.UETUserId = new Microsoft.Bond.GUID(guid.Value);

                    pss.UetUserIdType = UETUserIdTypeSpark.AnalyticsGUID;
                    pss.SeaClickDetail = scd;

                    string res = pss.SerializeObject();

                    var tst = res.DeserializeObject<PaidSearchSpark>();

                    
                    
                    string ans = tst.SerializeObject();

                 }
                var sacs = sac.Convert2Spark();
                output.WriteLine(sacs.SerializeObject(),1000);
                byte[] result;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CompactBinaryProtocolWriter compactBinaryProtocolWriter = new CompactBinaryProtocolWriter(memoryStream))
                    {
                        ((IBondSerializable)sacs).Write(compactBinaryProtocolWriter);
                        result = memoryStream.ToArray();
                    }
                }
                SaveFile(result,result.Length,1000);
                int num = 10000;
                //TimeCost(num, sac);
                //TimeCost(num, sacs);

                input.Close();
             }
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //output.Close();
            input.Close();
            resInput.Close();
        }
        static void SaveFile(byte[] data,int len,int repeat = 1)
        {
            FileStream fs = new FileStream(@"D:\UserAdActivity\binary", FileMode.Create, FileAccess.Write, FileShare.None);
            while(repeat-- != 0)
                fs.Write(data, 0, len);
            fs.Close();
        }
        static void TimeCost(int num, SAClick sac)
        {
            int i = 0;
            System.Diagnostics.Stopwatch oTime = new System.Diagnostics.Stopwatch();
            oTime.Start();
            while(i < num)
            {
                string res = JsonConvert.SerializeObject(sac);
                var ar = JsonConvert.DeserializeObject<SAClick>(res);
                i++;
            }
            oTime.Stop();
            Console.WriteLine(string.Format("run time: {0} ms, Num: {1}", oTime.ElapsedMilliseconds,i));
        }
        static void TimeCost(int num, SAClickSpark sac)
        {
            int i = 0;
            System.Diagnostics.Stopwatch oTime = new System.Diagnostics.Stopwatch();
            oTime.Start();
            while (i < num)
            {
                string res = sac.SerializeObject();
                var ar = res.DeserializeObject<SAClickSpark>();
                i++;
            }
            oTime.Stop();
            Console.WriteLine(string.Format("run time: {0} ms, Num: {1}", oTime.ElapsedMilliseconds, i));
        }
    }
}
