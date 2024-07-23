using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FusionSSH
{
    internal class SshHelper
    {
        /// <summary>
        /// ConnectionHelper instance
        /// </summary>
        private ConnectionsHelper connectionHelper;

        /// <summary>
        /// Connection name
        /// </summary>
        private string connectionName;

        /// <summary>
        /// Connection exists checker
        /// </summary>
        private bool canConnect;

        /// <summary>
        /// User name
        /// </summary>
        public string UserName { get; private set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; private set; }

        /// <summary>
        /// Ip address
        /// </summary>
        public string IpAddress { get; private set; }

        /// <summary>
        /// Port
        /// </summary>
        public string Port { get; private set; }

        public SshHelper(ConnectionsHelper connectionHelper, string connectionName)
        {
            this.connectionHelper = connectionHelper;
            this.connectionName = connectionName;

            GetInformation();
        }

        /// <summary>
        /// Get connection by name and set values to properties.
        /// </summary>
        public void GetInformation()
        {
            canConnect = false;

            foreach (var connection in connectionHelper.GetConnections())
            {
                if (connection.ConnectionName == connectionName)
                {
                    UserName = connection.ConnectionUser;
                    Password = connection.ConnectionPass;
                    IpAddress = connection.ConnectionHost;
                    Port = connection.ConnectionPort;
                    canConnect = true;
                    break;
                }
            }
        }
        
        /// <summary>
        /// Connect to SSH server.
        /// </summary>
        public void Connect()
        {
            if (canConnect)
            {

            }
        }

    }
}
