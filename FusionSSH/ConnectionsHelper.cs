using System.Collections.Generic;
using System.IO;

namespace FusionSSH
{
    public class ConnectionsHelper
    {
        /// <summary>
        /// Path of connections database file.
        /// </summary>
        public readonly string connectionDatabase;

        /// <summary>
        /// List of connections.
        /// </summary>
        private List<ConnectionStructure> connectionsList = new List<ConnectionStructure>();

        /// <summary>
        /// ConnectionsHelper constructor, taking argument for connections database file.
        /// </summary>
        /// <param name="connectionDatabase"></param>
        public ConnectionsHelper(string connectionDatabase)
        {
            this.connectionDatabase = connectionDatabase;
        }

        /// <summary>
        /// Loads database and all connections to "connectionsList"
        /// </summary>
        public void LoadDatabase()
        {
            if (!File.Exists(connectionDatabase))
                CreateDatabase();

            List<string> jsonConnectionRecords = new List<string>();

            string[] databaseRecords = GetDatabaseRecords();

            if (databaseRecords != null)
            {
                foreach (var record in databaseRecords)
                {
                    if (!string.IsNullOrEmpty(record) && JsonHelper.ValidateJSON(record))
                    {
                        jsonConnectionRecords.Add(record.Trim());
                    }
                }
            }

            foreach (var connectionRecord in jsonConnectionRecords)
            {
                InsertToList(connectionRecord);
            }
        }

        /// <summary>
        /// Returns a list of connections.
        /// </summary>
        /// <returns>List of connections</returns>
        public List<ConnectionStructure> GetConnections()
        {
            return connectionsList;
        }

        /// <summary>
        /// Get a count of a connections on connection list.
        /// </summary>
        /// <returns>Count of connections</returns>
        public int GetRecordsCount()
        {
            return connectionsList.Count;
        }

        /// <summary>
        /// Parse connections from JSON and insert into list with ConnectionStructure structure.
        /// </summary>
        /// <param name="connectionRecord">JSON string to parse</param>
        public void InsertToList(string connectionRecord)
        {
            if (connectionRecord == null || connectionRecord.Trim().Length == 0)
                return;

            // parse the JSON value from keys.
            string connectionName = JsonHelper.ParseValueFromKey("ConnectionName", connectionRecord);
            string connectionHost = JsonHelper.ParseValueFromKey("ConnectionHost", connectionRecord);
            string connectionPort = JsonHelper.ParseValueFromKey("ConnectionPort", connectionRecord);
            string connectionPass = JsonHelper.ParseValueFromKey("ConnectionPass", connectionRecord);
            string connectionUser = JsonHelper.ParseValueFromKey("ConnectionUser", connectionRecord);

            // parsing the ID as integer (for able to increment)
            int.TryParse(JsonHelper.ParseValueFromKey("ConnectionId", connectionRecord), out int connectionId);
            
            // adds connections into list.
            connectionsList.Add(new ConnectionStructure
            {
                ConnectionName = connectionName,
                ConnectionHost = connectionHost,
                ConnectionPort = connectionPort,
                ConnectionPass = connectionPass,
                ConnectionUser = connectionUser,
                ConnectionId = connectionId
            });
        }

        /// <summary>
        /// Creates a non-existing database.
        /// </summary>
        public void CreateDatabase()
        {
            File.WriteAllText(connectionDatabase, "");
        }

        /// <summary>
        /// Loads all connection records from database file.
        /// </summary>
        /// <returns>Array of connections in JSON format.</returns>
        public string[] GetDatabaseRecords()
        {
            return File.ReadAllLines(connectionDatabase);
        }
    }
}
