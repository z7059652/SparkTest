using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Spark.CSharp.Core;
using Microsoft.Spark.CSharp.Streaming;

namespace testSparkClr
{
    class Program
    {
        static void Main(string[] args)
        {
            var sparkContext = new SparkContext(new SparkConf().SetAppName("MobiusWordCount"));

            try
            {
                var file = "file:///D:/README.md";
                var lines = sparkContext.TextFile(file);
                var counts = lines
                    .FlatMap(x => x.Split(' '))
                    .Map(w => new KeyValuePair<string, int>(w, 1))
                    .ReduceByKey((x, y) => x + y);

                foreach (var wordcount in counts.Collect())
                {
                    Console.WriteLine("{0}: {1}", wordcount.Key, wordcount.Value);
                }
            }
            catch (Exception ex)
            {
                Console.Write("Error performing Word Count : " +  ex.Message);
            }

            sparkContext.Stop();
            return;
        }
    }
}
