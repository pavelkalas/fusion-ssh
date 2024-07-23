using Renci.SshNet;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FusionSSH
{
    public partial class SshWindow : Form
    {
        /// <summary>
        /// User name
        /// </summary>
        public string UserName { get; private set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; private set; }

        /// <summary>
        /// IP address
        /// </summary>
        public string IpAddress { get; private set; }

        /// <summary>
        /// Port
        /// </summary>
        public string Port { get; private set; }

        /// <summary>
        /// SshClient instance
        /// </summary>
        private SshClient sshClient;

        /// <summary>
        /// ShellStream instance
        /// </summary>
        private ShellStream shellStream;

        public SshWindow(string userName, string password, string ipAddress, string port)
        {
            InitializeComponent();

            UserName = userName;
            Password = password;
            IpAddress = ipAddress;
            Port = port;

            Text = ipAddress + ":" + userName;
        }

        /// <summary>
        /// Creates a SSH connection.
        /// </summary>
        public void Connect()
        {
            sshClient = new SshClient(IpAddress, int.Parse(Port), UserName, DpapiHelper.Unprotect(Password));

            try
            {
                sshClient.Connect();

                if (sshClient.IsConnected)
                {
                    shellStream = sshClient.CreateShellStream("xterm", 80, 24, 800, 600, 1024);
                    _ = Task.Run(() => ReadAsync());
                }
                else
                {
                    TerminalOutputRich.Text += "Nelze se připojit k serveru.\n";
                }
            }
            catch (Exception ex)
            {
                TerminalOutputRich.Text += $"Chyba: {ex.Message}\n";
            }
        }

        /// <summary>
        /// Reads the output from SSH client.
        /// </summary>
        /// <returns></returns>
        private async Task ReadAsync()
        {
            var buffer = new byte[1024];
            var encoding = new UTF8Encoding();

            while (sshClient.IsConnected)
            {
                int bytesRead = await shellStream.ReadAsync(buffer, 0, buffer.Length);
                
                if (bytesRead > 0)
                {
                    var output = encoding.GetString(buffer, 0, bytesRead);
                    AppendText(output);
                }
            }
        }

        /// <summary>
        /// After form loading.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormLoad(object sender, EventArgs e)
        {
            Connect();
        }

        /// <summary>
        /// On command input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCommandEntry(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string inputCommand = TerminalInputTxt.Text;
                SendCommand(inputCommand);
                TerminalInputTxt.Clear();
            }
        }

        /// <summary>
        /// Sends command to SSH client.
        /// </summary>
        /// <param name="command"></param>
        private void SendCommand(string command)
        {
            if (shellStream != null && shellStream.CanWrite)
            {
                shellStream.WriteLine(command);
            }
        }

        /// <summary>
        /// Appends text to richtextbox and scroll to bottom.
        /// </summary>
        /// <param name="text"></param>
        private void AppendText(string text)
        {
            if (TerminalOutputRich.InvokeRequired)
            {
                TerminalOutputRich.Invoke(new Action(() =>
                {
                    TerminalOutputRich.AppendText(text);
                    TerminalOutputRich.ScrollToCaret();
                }));
            }
            else
            {
                TerminalOutputRich.AppendText(text);
                TerminalOutputRich.ScrollToCaret();
            }
        }
    }
}
