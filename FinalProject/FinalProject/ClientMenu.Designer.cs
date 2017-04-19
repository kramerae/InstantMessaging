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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMenu));
            this.uxlabel1 = new System.Windows.Forms.Label();
            this.uxStartChat = new System.Windows.Forms.Button();
            this.uxAddContact = new System.Windows.Forms.Button();
            this.uxRemoveContact = new System.Windows.Forms.Button();
            this.uxInstructions = new System.Windows.Forms.Label();
            this.uxTitleLabel = new System.Windows.Forms.Label();
            this.uxContactListBox = new System.Windows.Forms.ListBox();
            this.uxLogout = new System.Windows.Forms.Button();
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
            // uxStartChat
            // 
            this.uxStartChat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.uxStartChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartChat.Location = new System.Drawing.Point(233, 294);
            this.uxStartChat.Name = "uxStartChat";
            this.uxStartChat.Size = new System.Drawing.Size(157, 74);
            this.uxStartChat.TabIndex = 2;
            this.uxStartChat.Text = "Start Chat";
            this.uxStartChat.UseVisualStyleBackColor = false;
            // 
            // uxAddContact
            // 
            this.uxAddContact.Location = new System.Drawing.Point(248, 194);
            this.uxAddContact.Name = "uxAddContact";
            this.uxAddContact.Size = new System.Drawing.Size(119, 37);
            this.uxAddContact.TabIndex = 3;
            this.uxAddContact.Text = "Add Contact";
            this.uxAddContact.UseVisualStyleBackColor = true;
            // 
            // uxRemoveContact
            // 
            this.uxRemoveContact.Location = new System.Drawing.Point(249, 237);
            this.uxRemoveContact.Name = "uxRemoveContact";
            this.uxRemoveContact.Size = new System.Drawing.Size(118, 38);
            this.uxRemoveContact.TabIndex = 4;
            this.uxRemoveContact.Text = "Remove Contact";
            this.uxRemoveContact.UseVisualStyleBackColor = true;
            // 
            // uxInstructions
            // 
            this.uxInstructions.AutoSize = true;
            this.uxInstructions.Location = new System.Drawing.Point(207, 86);
            this.uxInstructions.Name = "uxInstructions";
            this.uxInstructions.Size = new System.Drawing.Size(215, 91);
            this.uxInstructions.TabIndex = 5;
            this.uxInstructions.Text = resources.GetString("uxInstructions.Text");
            // 
            // uxTitleLabel
            // 
            this.uxTitleLabel.AutoSize = true;
            this.uxTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitleLabel.Location = new System.Drawing.Point(224, 55);
            this.uxTitleLabel.Name = "uxTitleLabel";
            this.uxTitleLabel.Size = new System.Drawing.Size(166, 20);
            this.uxTitleLabel.TabIndex = 6;
            this.uxTitleLabel.Text = "Welcome to 501 Chat!";
            // 
            // uxContactListBox
            // 
            this.uxContactListBox.FormattingEnabled = true;
            this.uxContactListBox.Location = new System.Drawing.Point(12, 33);
            this.uxContactListBox.Name = "uxContactListBox";
            this.uxContactListBox.Size = new System.Drawing.Size(189, 355);
            this.uxContactListBox.TabIndex = 7;
            // 
            // uxLogout
            // 
            this.uxLogout.Location = new System.Drawing.Point(335, 12);
            this.uxLogout.Name = "uxLogout";
            this.uxLogout.Size = new System.Drawing.Size(81, 26);
            this.uxLogout.TabIndex = 8;
            this.uxLogout.Text = "Log Out";
            this.uxLogout.UseVisualStyleBackColor = true;
            // 
            // ClientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 402);
            this.Controls.Add(this.uxLogout);
            this.Controls.Add(this.uxContactListBox);
            this.Controls.Add(this.uxTitleLabel);
            this.Controls.Add(this.uxInstructions);
            this.Controls.Add(this.uxRemoveContact);
            this.Controls.Add(this.uxAddContact);
            this.Controls.Add(this.uxStartChat);
            this.Controls.Add(this.uxlabel1);
            this.Name = "ClientMenu";
            this.Text = "501 Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxlabel1;
        private System.Windows.Forms.Button uxStartChat;
        private System.Windows.Forms.Button uxAddContact;
        private System.Windows.Forms.Button uxRemoveContact;
        private System.Windows.Forms.Label uxInstructions;
        private System.Windows.Forms.Label uxTitleLabel;
        private System.Windows.Forms.ListBox uxContactListBox;
        private System.Windows.Forms.Button uxLogout;
    }
}

