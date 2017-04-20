namespace FinalProject
{
    partial class Chat
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
            this.MessageBox = new System.Windows.Forms.ListBox();
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.uxSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageBox
            // 
            this.MessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBox.FormattingEnabled = true;
            this.MessageBox.ItemHeight = 16;
            this.MessageBox.Location = new System.Drawing.Point(12, 12);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(583, 244);
            this.MessageBox.TabIndex = 0;
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatTextBox.Location = new System.Drawing.Point(12, 269);
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.Size = new System.Drawing.Size(477, 26);
            this.ChatTextBox.TabIndex = 1;
            // 
            // uxSend
            // 
            this.uxSend.BackColor = System.Drawing.Color.Lime;
            this.uxSend.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSend.Location = new System.Drawing.Point(495, 268);
            this.uxSend.Name = "uxSend";
            this.uxSend.Size = new System.Drawing.Size(100, 27);
            this.uxSend.TabIndex = 2;
            this.uxSend.Text = "SEND";
            this.uxSend.UseVisualStyleBackColor = false;
            this.uxSend.Click += new System.EventHandler(this.uxSend_Click);
            // 
            // Chat
            // 
            this.AcceptButton = this.uxSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 303);
            this.Controls.Add(this.uxSend);
            this.Controls.Add(this.ChatTextBox);
            this.Controls.Add(this.MessageBox);
            this.Name = "Chat";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MessageBox;
        private System.Windows.Forms.TextBox ChatTextBox;
        private System.Windows.Forms.Button uxSend;
    }
}