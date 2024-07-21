namespace FusionSSH
{
    internal class ConnectionStructure
    {
        /// <summary>
        /// Identifier for connection.
        /// </summary>
        public int ConnectionId;

        /// <summary>
        /// Name of the connections.
        /// </summary>
        public string ConnectionName;

        /// <summary>
        /// IP address of connection.
        /// </summary>
        public string ConnectionHost;

        /// <summary>
        /// Connection port
        /// </summary>
        public int ConnectionPort;

        /// <summary>
        /// Connection user.
        /// </summary>
        public string ConnectionUser;

        /// <summary>
        /// Password for user.
        /// </summary>
        public string ConnectionPass;
    }
}
