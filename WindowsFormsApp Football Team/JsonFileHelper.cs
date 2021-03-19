using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace WindowsFormsApp_Football_Team
{
    public static class JsonFileHelper
    {
        #region JSON        

        public static void JSONSerialization(List<Coordinate> coordinates, string fileName)
        {            
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter($"Coordinates/{fileName}.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, coordinates);
                }
            }            
        }
        public static void JSONDeSerialization(ref List<Coordinate> coordinates, string fileName)
        {            
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader($"Coordinates/{fileName}.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    coordinates = serializer.Deserialize<List<Coordinate>>(jr);
                }
            }            
        }

        #endregion       
    }
}
