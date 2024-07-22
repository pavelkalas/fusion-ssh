namespace FusionSSH
{
    partial class CreateConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HostAndPortTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelCreationBtn = new System.Windows.Forms.Button();
            this.ConfirmCreateBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordAgainTxt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HostAndPortTxt
            // 
            this.HostAndPortTxt.Location = new System.Drawing.Point(133, 19);
            this.HostAndPortTxt.Name = "HostAndPortTxt";
            this.HostAndPortTxt.Size = new System.Drawing.Size(251, 26);
            this.HostAndPortTxt.TabIndex = 0;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(133, 89);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(251, 26);
            this.PasswordTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelCreationBtn);
            this.groupBox1.Controls.Add(this.ConfirmCreateBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PasswordAgainTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UserNameTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PasswordTxt);
            this.groupBox1.Controls.Add(this.HostAndPortTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 204);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup a new SSH connection";
            // 
            // CancelCreationBtn
            // 
            this.CancelCreationBtn.Location = new System.Drawing.Point(220, 163);
            this.CancelCreationBtn.Name = "CancelCreationBtn";
            this.CancelCreationBtn.Size = new System.Drawing.Size(75, 29);
            this.CancelCreationBtn.TabIndex = 8;
            this.CancelCreationBtn.Text = "Cancel";
            this.CancelCreationBtn.UseVisualStyleBackColor = true;
            this.CancelCreationBtn.Click += new System.EventHandler(this.CancelCreationBtn_Click);
            // 
            // ConfirmCreateBtn
            // 
            this.ConfirmCreateBtn.Location = new System.Drawing.Point(301, 163);
            this.ConfirmCreateBtn.Name = "ConfirmCreateBtn";
            this.ConfirmCreateBtn.Size = new System.Drawing.Size(75, 29);
            this.ConfirmCreateBtn.TabIndex = 7;
            this.ConfirmCreateBtn.Text = "Create";
            this.ConfirmCreateBtn.UseVisualStyleBackColor = true;
            this.ConfirmCreateBtn.Click += new System.EventHandler(this.ConfirmCreateBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password again:";
            // 
            // PasswordAgainTxt
            // 
            this.PasswordAgainTxt.Location = new System.Drawing.Point(133, 124);
            this.PasswordAgainTxt.Name = "PasswordAgainTxt";
            this.PasswordAgainTxt.PasswordChar = '*';
            this.PasswordAgainTxt.Size = new System.Drawing.Size(251, 26);
            this.PasswordAgainTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Location = new System.Drawing.Point(133, 54);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(251, 26);
            this.UserNameTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host and port:";
            // 
            // CreateConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 227);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FusionSSH - New connection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox HostAndPortTxt;
        private System.Windows.Forms.MaskedTextBox PasswordTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox PasswordAgainTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConfirmCreateBtn;
        private System.Windows.Forms.Button CancelCreationBtn;
    }
}