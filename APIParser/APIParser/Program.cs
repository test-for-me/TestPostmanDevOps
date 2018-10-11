using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace APIParser
{
    class Program
    {
        static void Main(string[] args)
        {
            String filePath = string.Empty;
            if (args.Length > 0)
            {
                filePath = args[0];
            }
            else
            {
                filePath = ConfigurationManager.AppSettings["FilePath"];
                
            }
            ReadFile(filePath);
        }

        public static void ReadFile(string location)
        {
            var dt =SerilizationHelper.ReadFromBinaryFile<PostmanModel>(location);
            if (dt == null)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Format("Total Success:{0} Total Failed:{1} Total TestCase:{2}", dt.Run.Stats.Assertions.Total- dt.Run.Stats.Assertions.Failed,
                    dt.Run.Stats.Assertions.Failed, dt.Run.Stats.Assertions.Total));
            }
            Console.WriteLine("finsihed");
            Console.ReadKey();
        }
    }
}
