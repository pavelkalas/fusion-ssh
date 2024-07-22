namespace FusionSSH
{
    partial class EditConnection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelEditBtn = new System.Windows.Forms.Button();
            this.ConfirmEditBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordAgainTxt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.MaskedTextBox();
            this.HostAndPortTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelEditBtn);
            this.groupBox1.Controls.Add(this.ConfirmEditBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PasswordAgainTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UserNameTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PasswordTxt);
            this.groupBox1.Controls.Add(this.HostAndPortTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit SSH connection";
            // 
            // CancelEditBtn
            // 
            this.CancelEditBtn.Location = new System.Drawing.Point(220, 163);
            this.CancelEditBtn.Name = "CancelEditBtn";
            this.CancelEditBtn.Size = new System.Drawing.Size(75, 29);
            this.CancelEditBtn.TabIndex = 8;
            this.CancelEditBtn.Text = "Cancel";
            this.CancelEditBtn.UseVisualStyleBackColor = true;
            this.CancelEditBtn.Click += new System.EventHandler(this.CancelEditBtn_Click);
            // 
            // ConfirmEditBtn
            // 
            this.ConfirmEditBtn.Location = new System.Drawing.Point(301, 163);
            this.ConfirmEditBtn.Name = "ConfirmEditBtn";
            this.ConfirmEditBtn.Size = new System.Drawing.Size(75, 29);
            this.ConfirmEditBtn.TabIndex = 7;
            this.ConfirmEditBtn.Text = "Edit";
            this.ConfirmEditBtn.UseVisualStyleBackColor = true;
            this.ConfirmEditBtn.Click += new System.EventHandler(this.ConfirmEditBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password again:";
            // 
            // PasswordAgainTxt
            // 
            this.PasswordAgainTxt.Location = new System.Drawing.Point(133, 124);
            this.PasswordAgainTxt.Name = "PasswordAgainTxt";
            this.PasswordAgainTxt.PasswordChar = '*';
            this.PasswordAgainTxt.Size = new System.Drawing.Size(251, 22);
            this.PasswordAgainTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Location = new System.Drawing.Point(133, 54);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(251, 22);
            this.UserNameTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host and port:";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(133, 89);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(251, 22);
            this.PasswordTxt.TabIndex = 1;
            // 
            // HostAndPortTxt
            // 
            this.HostAndPortTxt.Location = new System.Drawing.Point(133, 19);
            this.HostAndPortTxt.Name = "HostAndPortTxt";
            this.HostAndPortTxt.Size = new System.Drawing.Size(251, 22);
            this.HostAndPortTxt.TabIndex = 0;
            // 
            // EditConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 227);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FusionSSH - Edit connection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelEditBtn;
        private System.Windows.Forms.Button ConfirmEditBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox PasswordAgainTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox PasswordTxt;
        private System.Windows.Forms.TextBox HostAndPortTxt;
    }
}