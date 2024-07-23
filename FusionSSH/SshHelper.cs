using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionSSH
{
    internal class SshHelper
    {
        private ConnectionsHelper connectionHelper;
        private string connectionName;

        public SshHelper(ConnectionsHelper connectionHelper, string connectionName)
        {
            this.connectionHelper = connectionHelper;
            this.connectionName = connectionName;
        }
        
        public void Connect()
        {

        }

    }
}
