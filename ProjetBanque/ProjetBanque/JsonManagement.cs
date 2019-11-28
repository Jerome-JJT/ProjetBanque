using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    /// <summary>
    /// Extract/insert data from json
    /// </summary>
    public class JsonManagement
    {
        /// <summary>
        /// Create json reader object
        /// </summary>
        public JsonManagement()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public JsonData ExtractData(string path)
        {
            StreamReader file = new StreamReader(path);

            JsonData jsonContent = JsonConvert.DeserializeObject<JsonData>(file.ReadToEnd());

            file.Close();

            return jsonContent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public void InsertData(string path, JsonData data)
        {
            StreamWriter file = new StreamWriter(path);

            file.Write(JsonConvert.SerializeObject(data));

            file.Close();
        }
    }
}
