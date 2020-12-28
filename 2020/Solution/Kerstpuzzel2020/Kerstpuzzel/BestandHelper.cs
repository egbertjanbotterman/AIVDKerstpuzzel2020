using System.IO;
using Newtonsoft.Json;

namespace Kerstpuzzel
{
    public static class BestandHelper
    {
        public static string ApplicationPath => @"D:\Temp";

        private static string filefullPath(string filename)
        {
            return Path.Combine(ApplicationPath, filename + ".txt");
        }

        public static void SaveObject<T>(T obj, string filename)
        {
            File.WriteAllText(filefullPath(filename), JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }));
        }

        public static T LoadObject<T>(string filename)
        {
            var settings = new JsonSerializerSettings();
            T obj = JsonConvert.DeserializeObject<T>(
                File.ReadAllText(filefullPath(filename)), settings);

            return obj;
        }

        public static void AddToFile(string fileName, string line)
        {

            using (StreamWriter sw = File.AppendText(filefullPath(fileName)))
            {
                sw.WriteLine(line);
            }


        }
    }
}
