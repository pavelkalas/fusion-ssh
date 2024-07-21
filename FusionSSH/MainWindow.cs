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

            connectionHelper = new ConnectionsHelper(connectionDatabase);
            connectionHelper.LoadDatabase();
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
