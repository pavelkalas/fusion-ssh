namespace FusionSSH
{
    partial class MainWindow
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ConnectionsListView = new System.Windows.Forms.ListView();
            this.ConnectToSelectedBtn = new System.Windows.Forms.Button();
            this.EditConnectionBtn = new System.Windows.Forms.Button();
            this.DeleteConnectionBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CreateNewConnectionBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectionsListView
            // 
            this.ConnectionsListView.HideSelection = false;
            this.ConnectionsListView.Location = new System.Drawing.Point(6, 19);
            this.ConnectionsListView.Name = "ConnectionsListView";
            this.ConnectionsListView.Size = new System.Drawing.Size(565, 199);
            this.ConnectionsListView.TabIndex = 0;
            this.ConnectionsListView.UseCompatibleStateImageBehavior = false;
            // 
            // ConnectToSelectedBtn
            // 
            this.ConnectToSelectedBtn.Location = new System.Drawing.Point(6, 19);
            this.ConnectToSelectedBtn.Name = "ConnectToSelectedBtn";
            this.ConnectToSelectedBtn.Size = new System.Drawing.Size(130, 27);
            this.ConnectToSelectedBtn.TabIndex = 1;
            this.ConnectToSelectedBtn.Text = "Connect to selected";
            this.ConnectToSelectedBtn.UseVisualStyleBackColor = true;
            this.ConnectToSelectedBtn.Click += new System.EventHandler(this.ConnectToSelectedBtn_Click);
            // 
            // EditConnectionBtn
            // 
            this.EditConnectionBtn.Location = new System.Drawing.Point(290, 19);
            this.EditConnectionBtn.Name = "EditConnectionBtn";
            this.EditConnectionBtn.Size = new System.Drawing.Size(130, 27);
            this.EditConnectionBtn.TabIndex = 2;
            this.EditConnectionBtn.Text = "Edit connection";
            this.EditConnectionBtn.UseVisualStyleBackColor = true;
            this.EditConnectionBtn.Click += new System.EventHandler(this.EditConnectionBtn_Click);
            // 
            // DeleteConnectionBtn
            // 
            this.DeleteConnectionBtn.Location = new System.Drawing.Point(426, 19);
            this.DeleteConnectionBtn.Name = "DeleteConnectionBtn";
            this.DeleteConnectionBtn.Size = new System.Drawing.Size(130, 27);
            this.DeleteConnectionBtn.TabIndex = 3;
            this.DeleteConnectionBtn.Text = "Delete connection";
            this.DeleteConnectionBtn.UseVisualStyleBackColor = true;
            this.DeleteConnectionBtn.Click += new System.EventHandler(this.DeleteConnectionBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ConnectionsListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 283);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connections list";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CreateNewConnectionBtn);
            this.groupBox2.Controls.Add(this.ConnectToSelectedBtn);
            this.groupBox2.Controls.Add(this.DeleteConnectionBtn);
            this.groupBox2.Controls.Add(this.EditConnectionBtn);
            this.groupBox2.Location = new System.Drawing.Point(6, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // CreateNewConnectionBtn
            // 
            this.CreateNewConnectionBtn.Location = new System.Drawing.Point(154, 19);
            this.CreateNewConnectionBtn.Name = "CreateNewConnectionBtn";
            this.CreateNewConnectionBtn.Size = new System.Drawing.Size(130, 27);
            this.CreateNewConnectionBtn.TabIndex = 4;
            this.CreateNewConnectionBtn.Text = "Create connection";
            this.CreateNewConnectionBtn.UseVisualStyleBackColor = true;
            this.CreateNewConnectionBtn.Click += new System.EventHandler(this.CreateNewConnectionBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 305);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FusionSSH";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ConnectionsListView;
        private System.Windows.Forms.Button ConnectToSelectedBtn;
        private System.Windows.Forms.Button EditConnectionBtn;
        private System.Windows.Forms.Button DeleteConnectionBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CreateNewConnectionBtn;
    }
}

