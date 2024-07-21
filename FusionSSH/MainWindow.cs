using System;
using System.Windows.Forms;

namespace FusionSSH
{
    public partial class MainWindow : Form
    {
        private readonly string connectionDatabase = Environment.CurrentDirectory + "\\connections.txt";

        private ConnectionsHelper connectionHelper;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAppLoad(object sender, EventArgs e)
        {
            connectionHelper = new ConnectionsHelper(connectionDatabase);
            connectionHelper.LoadDatabase();

            foreach (var connections in connectionHelper.GetConnections())
            {
                ListViewItem item = new ListViewItem(connections.ConnectionId.ToString());
                item.SubItems.Add(connections.ConnectionName);
                item.SubItems.Add(connections.ConnectionHost);
                item.SubItems.Add(connections.ConnectionPort);
                ConnectionsListView.Items.Add(item);
            }
        }

        private void ConnectToSelectedBtn_Click(object sender, System.EventArgs e)
        {

        }

        private void DeleteConnectionBtn_Click(object sender, System.EventArgs e)
        {

        }

        private void EditConnectionBtn_Click(object sender, System.EventArgs e)
        {

        }

        private void CreateNewConnectionBtn_Click(object sender, System.EventArgs e)
        {
            new CreateConnection(connectionHelper).ShowDialog();
        }
    }
}
