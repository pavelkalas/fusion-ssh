using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace FusionSSH
{
    public partial class CreateConnection : Form
    {
        /// <summary>
        /// ConnectionsHelper object declaration.
        /// </summary>
        private ConnectionsHelper connectionsHelper;

        /// <summary>
        /// Constructor passing the ConnectionsHelper object.
        /// </summary>
        /// <param name="connectionsHelper"></param>
        public CreateConnection(ConnectionsHelper connectionsHelper)
        {
            InitializeComponent();

            this.connectionsHelper = connectionsHelper;
        }

        /// <summary>
        /// Saves the connection into database file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmCreateBtn_Click(object sender, System.EventArgs e)
        {
            // loads data from FORM.
            string userName = (UserNameTxt.Text.Length > 0) ? UserNameTxt.Text : "root";
            string connection = HostAndPortTxt.Text;
            string passWord = PasswordTxt.Text;
            string passWordAgain = PasswordAgainTxt.Text;

            // create dummy variables
            string ipAddress = null;
            string port = null;

            // check if user is putting port in HOST input, if yes, split string by ':'
            if (connection.Contains(":"))
            {
                string[] connectionData = connection.Split(':');
                ipAddress = connectionData[0].Trim();
                port = connectionData[1].Trim();
            }
            else
            {
                port = "22";            // default SSH port 22
                ipAddress = connection; // whole input as IP address
            }

            // creating JSON object
            var connectionString = new
            {
                ConnectionUser = userName,
                ConnectionName = ipAddress,
                ConnectionPort = port,
                ConnectionHost = ipAddress,
                ConnectionId = connectionsHelper.GetRecordsCount() + 1,
            };

            // generate JSON string from object above.
            string jsonString = JsonConvert.SerializeObject(connectionString, Formatting.None);
            
            // append the connection to file to a bottom.
            File.AppendAllText(connectionsHelper.connectionDatabase, jsonString + Environment.NewLine);
            
            // closes this form.
            Hide();
        }

        /// <summary>
        /// Cancells and close this window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelCreationBtn_Click(object sender, System.EventArgs e)
        {
            // closes this form
            Hide();
        }
    }
}
