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
            this.uxRefresh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.uxMenuTab = new System.Windows.Forms.TabPage();
            this.uxChatTab = new System.Windows.Forms.TabPage();
            this.uxText = new System.Windows.Forms.TextBox();
            this.uxSend = new System.Windows.Forms.Button();
            this.uxMessagesLabel = new System.Windows.Forms.Label();
            this.uxChatroomsLabel = new System.Windows.Forms.Label();
            this.uxMessagesLB = new System.Windows.Forms.ListBox();
            this.uxChatroomsLB = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.uxMenuTab.SuspendLayout();
            this.uxChatTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxlabel1
            // 
            this.uxlabel1.AutoSize = true;
            this.uxlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxlabel1.Location = new System.Drawing.Point(6, 20);
            this.uxlabel1.Name = "uxlabel1";
            this.uxlabel1.Size = new System.Drawing.Size(105, 24);
            this.uxlabel1.TabIndex = 0;
            this.uxlabel1.Text = "Contact List";
            // 
            // uxStartChat
            // 
            this.uxStartChat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.uxStartChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxStartChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartChat.Location = new System.Drawing.Point(227, 300);
            this.uxStartChat.Name = "uxStartChat";
            this.uxStartChat.Size = new System.Drawing.Size(157, 74);
            this.uxStartChat.TabIndex = 2;
            this.uxStartChat.Text = "Start Chat";
            this.uxStartChat.UseVisualStyleBackColor = false;
            this.uxStartChat.Click += new System.EventHandler(this.uxStartChat_Click);
            // 
            // uxAddContact
            // 
            this.uxAddContact.Location = new System.Drawing.Point(242, 200);
            this.uxAddContact.Name = "uxAddContact";
            this.uxAddContact.Size = new System.Drawing.Size(119, 37);
            this.uxAddContact.TabIndex = 3;
            this.uxAddContact.Text = "Add Contact";
            this.uxAddContact.UseVisualStyleBackColor = true;
            this.uxAddContact.Click += new System.EventHandler(this.uxAddContact_Click);
            // 
            // uxRemoveContact
            // 
            this.uxRemoveContact.Location = new System.Drawing.Point(243, 243);
            this.uxRemoveContact.Name = "uxRemoveContact";
            this.uxRemoveContact.Size = new System.Drawing.Size(118, 38);
            this.uxRemoveContact.TabIndex = 4;
            this.uxRemoveContact.Text = "Remove Contact";
            this.uxRemoveContact.UseVisualStyleBackColor = true;
            this.uxRemoveContact.Click += new System.EventHandler(this.uxRemoveContact_Click);
            // 
            // uxInstructions
            // 
            this.uxInstructions.AutoSize = true;
            this.uxInstructions.Location = new System.Drawing.Point(201, 92);
            this.uxInstructions.Name = "uxInstructions";
            this.uxInstructions.Size = new System.Drawing.Size(215, 91);
            this.uxInstructions.TabIndex = 5;
            this.uxInstructions.Text = resources.GetString("uxInstructions.Text");
            // 
            // uxTitleLabel
            // 
            this.uxTitleLabel.AutoSize = true;
            this.uxTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitleLabel.Location = new System.Drawing.Point(218, 61);
            this.uxTitleLabel.Name = "uxTitleLabel";
            this.uxTitleLabel.Size = new System.Drawing.Size(166, 20);
            this.uxTitleLabel.TabIndex = 6;
            this.uxTitleLabel.Text = "Welcome to 501 Chat!";
            // 
            // uxContactListBox
            // 
            this.uxContactListBox.FormattingEnabled = true;
            this.uxContactListBox.Location = new System.Drawing.Point(6, 52);
            this.uxContactListBox.Name = "uxContactListBox";
            this.uxContactListBox.Size = new System.Drawing.Size(189, 342);
            this.uxContactListBox.TabIndex = 7;
            this.uxContactListBox.SelectedIndexChanged += new System.EventHandler(this.uxContactListBox_SelectedIndexChanged);
            // 
            // uxLogout
            // 
            this.uxLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxLogout.Location = new System.Drawing.Point(277, 18);
            this.uxLogout.Name = "uxLogout";
            this.uxLogout.Size = new System.Drawing.Size(81, 26);
            this.uxLogout.TabIndex = 8;
            this.uxLogout.Text = "Log Out";
            this.uxLogout.UseVisualStyleBackColor = true;
            this.uxLogout.Click += new System.EventHandler(this.uxLogout_Click);
            // 
            // uxRefresh
            // 
            this.uxRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.uxRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxRefresh.Image = ((System.Drawing.Image)(resources.GetObject("uxRefresh.Image")));
            this.uxRefresh.Location = new System.Drawing.Point(156, 12);
            this.uxRefresh.Name = "uxRefresh";
            this.uxRefresh.Size = new System.Drawing.Size(39, 38);
            this.uxRefresh.TabIndex = 9;
            this.uxRefresh.UseVisualStyleBackColor = false;
            this.uxRefresh.Click += new System.EventHandler(this.uxRefresh_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.uxMenuTab);
            this.tabControl1.Controls.Add(this.uxChatTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 426);
            this.tabControl1.TabIndex = 10;
            // 
            // uxMenuTab
            // 
            this.uxMenuTab.Controls.Add(this.uxLogout);
            this.uxMenuTab.Controls.Add(this.uxRefresh);
            this.uxMenuTab.Controls.Add(this.uxlabel1);
            this.uxMenuTab.Controls.Add(this.uxContactListBox);
            this.uxMenuTab.Controls.Add(this.uxStartChat);
            this.uxMenuTab.Controls.Add(this.uxTitleLabel);
            this.uxMenuTab.Controls.Add(this.uxAddContact);
            this.uxMenuTab.Controls.Add(this.uxInstructions);
            this.uxMenuTab.Controls.Add(this.uxRemoveContact);
            this.uxMenuTab.Location = new System.Drawing.Point(4, 22);
            this.uxMenuTab.Name = "uxMenuTab";
            this.uxMenuTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxMenuTab.Size = new System.Drawing.Size(418, 400);
            this.uxMenuTab.TabIndex = 0;
            this.uxMenuTab.Text = "Menu";
            this.uxMenuTab.UseVisualStyleBackColor = true;
            // 
            // uxChatTab
            // 
            this.uxChatTab.Controls.Add(this.uxText);
            this.uxChatTab.Controls.Add(this.uxSend);
            this.uxChatTab.Controls.Add(this.uxMessagesLabel);
            this.uxChatTab.Controls.Add(this.uxChatroomsLabel);
            this.uxChatTab.Controls.Add(this.uxMessagesLB);
            this.uxChatTab.Controls.Add(this.uxChatroomsLB);
            this.uxChatTab.Location = new System.Drawing.Point(4, 22);
            this.uxChatTab.Name = "uxChatTab";
            this.uxChatTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxChatTab.Size = new System.Drawing.Size(418, 400);
            this.uxChatTab.TabIndex = 1;
            this.uxChatTab.Text = "Chat";
            this.uxChatTab.UseVisualStyleBackColor = true;
            // 
            // uxText
            // 
            this.uxText.Location = new System.Drawing.Point(135, 340);
            this.uxText.Name = "uxText";
            this.uxText.Size = new System.Drawing.Size(277, 20);
            this.uxText.TabIndex = 5;
            this.uxText.TextChanged += new System.EventHandler(this.uxText_TextChanged);
            // 
            // uxSend
            // 
            this.uxSend.BackColor = System.Drawing.Color.Lime;
            this.uxSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSend.ForeColor = System.Drawing.Color.Black;
            this.uxSend.Location = new System.Drawing.Point(135, 363);
            this.uxSend.Name = "uxSend";
            this.uxSend.Size = new System.Drawing.Size(278, 23);
            this.uxSend.TabIndex = 4;
            this.uxSend.Text = "SEND";
            this.uxSend.UseVisualStyleBackColor = false;
            this.uxSend.Click += new System.EventHandler(this.uxSend_Click);
            // 
            // uxMessagesLabel
            // 
            this.uxMessagesLabel.AutoSize = true;
            this.uxMessagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMessagesLabel.Location = new System.Drawing.Point(135, 18);
            this.uxMessagesLabel.Name = "uxMessagesLabel";
            this.uxMessagesLabel.Size = new System.Drawing.Size(90, 20);
            this.uxMessagesLabel.TabIndex = 3;
            this.uxMessagesLabel.Text = "Messages";
            // 
            // uxChatroomsLabel
            // 
            this.uxChatroomsLabel.AutoSize = true;
            this.uxChatroomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxChatroomsLabel.Location = new System.Drawing.Point(5, 18);
            this.uxChatroomsLabel.Name = "uxChatroomsLabel";
            this.uxChatroomsLabel.Size = new System.Drawing.Size(96, 20);
            this.uxChatroomsLabel.TabIndex = 2;
            this.uxChatroomsLabel.Text = "Chatrooms";
            // 
            // uxMessagesLB
            // 
            this.uxMessagesLB.FormattingEnabled = true;
            this.uxMessagesLB.Location = new System.Drawing.Point(135, 44);
            this.uxMessagesLB.Name = "uxMessagesLB";
            this.uxMessagesLB.Size = new System.Drawing.Size(277, 290);
            this.uxMessagesLB.TabIndex = 1;
            this.uxMessagesLB.SelectedIndexChanged += new System.EventHandler(this.uxMessagesLB_SelectedIndexChanged);
            // 
            // uxChatroomsLB
            // 
            this.uxChatroomsLB.FormattingEnabled = true;
            this.uxChatroomsLB.Location = new System.Drawing.Point(7, 44);
            this.uxChatroomsLB.Name = "uxChatroomsLB";
            this.uxChatroomsLB.Size = new System.Drawing.Size(121, 342);
            this.uxChatroomsLB.TabIndex = 0;
            this.uxChatroomsLB.SelectedIndexChanged += new System.EventHandler(this.uxChatroomsLB_SelectedIndexChanged);
            // 
            // ClientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 438);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClientMenu";
            this.Text = "501 Chat";
            this.tabControl1.ResumeLayout(false);
            this.uxMenuTab.ResumeLayout(false);
            this.uxMenuTab.PerformLayout();
            this.uxChatTab.ResumeLayout(false);
            this.uxChatTab.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button uxRefresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage uxMenuTab;
        private System.Windows.Forms.TabPage uxChatTab;
        private System.Windows.Forms.TextBox uxText;
        private System.Windows.Forms.Button uxSend;
        private System.Windows.Forms.Label uxMessagesLabel;
        private System.Windows.Forms.Label uxChatroomsLabel;
        private System.Windows.Forms.ListBox uxMessagesLB;
        private System.Windows.Forms.ListBox uxChatroomsLB;
    }
}

