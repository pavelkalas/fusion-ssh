using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FusionSSH
{
    public partial class EditConnection : Form
    {
        private ConnectionsHelper connectionHelper;

        private string connectionName;
        private string jsonData;

        public EditConnection(ConnectionsHelper connectionHelper, string connectionName)
        {
            InitializeComponent();

            this.connectionHelper = connectionHelper;
            this.connectionName = connectionName;

            foreach (var connections in connectionHelper.GetConnections())
            {
                if (connections.ConnectionName == connectionName)
                {
                    UserNameTxt.Text = connections.ConnectionUser;
                    PasswordAgainTxt.Text = DpapiHelper.Unprotect(connections.ConnectionPass);
                    PasswordTxt.Text = DpapiHelper.Unprotect(connections.ConnectionPass);
                    HostAndPortTxt.Text = (connections.ConnectionPort == "22") ? connections.ConnectionHost : connections.ConnectionHost + ":" + connections.ConnectionPort;
                    break;
                }
            }
        }

        private void ConfirmEditBtn_Click(object sender, EventArgs e)
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

            // checks if is password really correct
            if (passWord != passWordAgain)
            {
                MessageBox.Show("Password and password again are not same!");
                return;
            }

            // creating JSON object
            var connectionString = new
            {
                ConnectionUser = userName,
                ConnectionName = ipAddress,
                ConnectionPort = port,
                ConnectionHost = ipAddress,
                ConnectionPass = DpapiHelper.Protect(passWord)
            };

            // generate JSON string from object above.
            string jsonString = JsonConvert.SerializeObject(connectionString, Formatting.None);

            connectionHelper.EditConnection(connectionName, jsonString);

            // close this form
            Hide();
        }

        private void CancelEditBtn_Click(object sender, EventArgs e)
        {
            // close this form
            Hide();
        }
    }
}
