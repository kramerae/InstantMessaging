namespace FinalProject
{
    partial class ClientMenu
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
            this.uxlabel1 = new System.Windows.Forms.Label();
            this.uxContactListBox = new System.Windows.Forms.ListBox();
            this.uxStartChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxlabel1
            // 
            this.uxlabel1.AutoSize = true;
            this.uxlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxlabel1.Location = new System.Drawing.Point(12, 9);
            this.uxlabel1.Name = "uxlabel1";
            this.uxlabel1.Size = new System.Drawing.Size(87, 18);
            this.uxlabel1.TabIndex = 0;
            this.uxlabel1.Text = "Contact List";
            // 
            // uxContactListBox
            // 
            this.uxContactListBox.FormattingEnabled = true;
            this.uxContactListBox.Location = new System.Drawing.Point(15, 30);
            this.uxContactListBox.Name = "uxContactListBox";
            this.uxContactListBox.Size = new System.Drawing.Size(186, 355);
            this.uxContactListBox.TabIndex = 1;
            // 
            // uxStartChat
            // 
            this.uxStartChat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.uxStartChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartChat.Location = new System.Drawing.Point(232, 305);
            this.uxStartChat.Name = "uxStartChat";
            this.uxStartChat.Size = new System.Drawing.Size(156, 69);
            this.uxStartChat.TabIndex = 2;
            this.uxStartChat.Text = "Start Chat";
            this.uxStartChat.UseVisualStyleBackColor = false;
            // 
            // ClientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 402);
            this.Controls.Add(this.uxStartChat);
            this.Controls.Add(this.uxContactListBox);
            this.Controls.Add(this.uxlabel1);
            this.Name = "ClientMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxlabel1;
        private System.Windows.Forms.ListBox uxContactListBox;
        private System.Windows.Forms.Button uxStartChat;
    }
}

