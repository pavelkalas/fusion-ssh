namespace FusionSSH
{
    partial class SshWindow
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
            this.TerminalOutputRich = new System.Windows.Forms.RichTextBox();
            this.TerminalInputTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TerminalOutputRich
            // 
            this.TerminalOutputRich.Location = new System.Drawing.Point(12, 12);
            this.TerminalOutputRich.Name = "TerminalOutputRich";
            this.TerminalOutputRich.Size = new System.Drawing.Size(776, 398);
            this.TerminalOutputRich.TabIndex = 0;
            this.TerminalOutputRich.Text = "";
            // 
            // TerminalInputTxt
            // 
            this.TerminalInputTxt.Location = new System.Drawing.Point(12, 416);
            this.TerminalInputTxt.Name = "TerminalInputTxt";
            this.TerminalInputTxt.Size = new System.Drawing.Size(776, 22);
            this.TerminalInputTxt.TabIndex = 1;
            this.TerminalInputTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnCommandEntry);
            // 
            // SshWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TerminalInputTxt);
            this.Controls.Add(this.TerminalOutputRich);
            this.Name = "SshWindow";
            this.Text = "SshWindow";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TerminalOutputRich;
        private System.Windows.Forms.TextBox TerminalInputTxt;
    }
}