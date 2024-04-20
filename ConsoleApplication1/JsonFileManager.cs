using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace ConsoleApplication1
{
    public static class JsonFileManager
    {
        // writing to json file
        public static async Task Write<T>(string path, T obj)
        {
            var options = new JsonSerializerOptions{ WriteIndented = true };
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                await JsonSerializer.SerializeAsync<T>(fs, obj, options);
                Console.WriteLine("Data has been saved to file");
            }
        }
        // reading to json file
        public static async Task<T> Read<T>(string path)
        {
            T obj;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                obj = await JsonSerializer.DeserializeAsync<T>(fs);
                
            }
            return obj;
        }
    }
}
