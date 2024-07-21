using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionSSH
{
    internal class ConnectionsHelper
    {
        private string connectionDatabase;
        

        public ConnectionsHelper(string connectionDatabase)
        {
            this.connectionDatabase = connectionDatabase;
        }

        public void LoadDatabase()
        {
            if (!File.Exists(connectionDatabase))
                CreateDatabase();

            List<string> connectionsStrings = new List<string>();

            string[] databaseRecords = GetDatabaseRecords();

            if (databaseRecords != null)
            {
                foreach (var record in databaseRecords)
                {

                }
            }
        }

        public void CreateDatabase()
        {
            File.WriteAllText(connectionDatabase, "");
        }

        public string[] GetDatabaseRecords()
        {
            return File.ReadAllLines(connectionDatabase);
        }
    }
}
