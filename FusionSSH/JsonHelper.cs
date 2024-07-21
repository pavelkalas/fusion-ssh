using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FusionSSH
{
    internal class JsonHelper
    {
        /// <summary>
        /// Gets a value from key in JSON string.
        /// </summary>
        /// <param name="keyName">Name of the key</param>
        /// <param name="jsonString">JSON string to be parsed</param>
        /// <returns>Parsed value from JSON key as string</returns>
        public static string ParseValueFromKey(string keyName, string jsonString)
        {
            try
            {
                JObject jsonObject = JObject.Parse(jsonString);
                JToken value = jsonObject[keyName];

                if (value != null)
                {
                    return value.ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (JsonReaderException)
            {
                return null;
            }
        }

        /// <summary>
        /// Validates if JSON has correct format.
        /// </summary>
        /// <param name="jsonString">JSON you want validate</param>
        /// <returns>Returns boolean if is JSON format correct</returns>
        public static bool ValidateJSON(string jsonString)
        {
            try
            {
                JToken.Parse(jsonString);
                return true;
            }
            catch (JsonReaderException)
            {
                return false;
            }
        }
    }
}
