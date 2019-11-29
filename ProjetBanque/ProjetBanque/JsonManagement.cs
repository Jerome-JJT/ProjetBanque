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
        private string fullPath;

        /// <summary>
        /// Create json reader object
        /// </summary>
        public JsonManagement()
        {
            string path = $"{Environment.GetEnvironmentVariable("appdata")}/BankProfile";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            fullPath = $"{path}\\bankProfile.json";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public JsonData ExtractData()
        {
            StreamReader file = new StreamReader(fullPath);

            JsonData jsonContent = JsonConvert.DeserializeObject<JsonData>(file.ReadToEnd());

            file.Close();

            return jsonContent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public void InsertData(JsonData data)
        {
            StreamWriter file = new StreamWriter(fullPath);

            file.Write(JsonConvert.SerializeObject(data));

            file.Close();
        }
    }
}
