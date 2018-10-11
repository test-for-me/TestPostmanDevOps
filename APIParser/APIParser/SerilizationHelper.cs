using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace APIParser
{
    public class SerilizationHelper
    {
        public static T DeserilizeToModel<T>(String dataInput)
        {
            T data = JsonConvert.DeserializeObject<T>(dataInput);
            return data;
        }
        public static String SerailizeModelToString<T>(T dataInput, bool indentation=true)
        {
            if(indentation)
                return JsonConvert.SerializeObject(dataInput, Formatting.Indented);
            return JsonConvert.SerializeObject(dataInput);
        }
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {

            using (StreamWriter writer = new StreamWriter(filePath))
            using (JsonTextWriter jsonWriter = new JsonTextWriter(writer))
            {
                JsonSerializer ser = new JsonSerializer();
                ser.Serialize(jsonWriter, objectToWrite);
                jsonWriter.Flush();
            }
        }
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                using (JsonTextReader jsonReader = new JsonTextReader(reader))
                {
                    JsonSerializer ser = new JsonSerializer();
                    return ser.Deserialize<T>(jsonReader);
                }
            }
            catch (FileNotFoundException ex)
            {
                File.Create(filePath).Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            return default(T);
        }
    }


}
