using System;
using System.Windows.Forms;

namespace FusionSSH
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Path for database file with connections.
        /// </summary>
        private readonly string connectionDatabase = Environment.CurrentDirectory + "\\connections.txt";

        /// <summary>
        /// ConnectionsHelper object to manipulate the connections.
        /// </summary>
        private ConnectionsHelper connectionHelper;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Application start and load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAppLoad(object sender, EventArgs e)
        {
            connectionHelper = new ConnectionsHelper(connectionDatabase);

            LoadConnections();
        }

        /// <summary>
        /// Load the connections into list.
        /// </summary>
        public void LoadConnections()
        {
            connectionHelper.LoadDatabase();

            if (ConnectionsListView.Items.Count > 0)
                ConnectionsListView.Items.Clear();

            int counter = 0;
            foreach (var connections in connectionHelper.GetConnections())
            {
                counter++;
                ListViewItem item = new ListViewItem(counter.ToString());
                item.SubItems.Add(connections.ConnectionName);
                item.SubItems.Add(connections.ConnectionHost);
                item.SubItems.Add(connections.ConnectionPort);
                ConnectionsListView.Items.Add(item);
            }
        }

        /// <summary>
        /// Connects to selected connection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectToSelectedBtn_Click(object sender, System.EventArgs e)
        {

        }

        /// <summary>
        /// Deletes the connection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteConnectionBtn_Click(object sender, System.EventArgs e)
        {

        }

        /// <summary>
        /// Edit the existing connection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditConnectionBtn_Click(object sender, System.EventArgs e)
        {
            new EditConnection(connectionHelper, "192.168.100.3").ShowDialog();
            LoadConnections();
        }

        /// <summary>
        /// Create new connection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateNewConnectionBtn_Click(object sender, System.EventArgs e)
        {
            new CreateConnection(connectionHelper).ShowDialog();
            LoadConnections();
        }
    }
}
