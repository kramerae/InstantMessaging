namespace FP_Server
{
    partial class ServerForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.uxListBoxUsersInChatRoom = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uxListBoxUserNames = new System.Windows.Forms.ListBox();
            this.usersLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uxListBoxContacts = new System.Windows.Forms.ListBox();
            this.uxLabelContacts = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uxListBoxChatRooms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxBtnStartServer = new System.Windows.Forms.Button();
            this.uxBtnStopServer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uxSaveLogBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uxButtonClearServerLog = new System.Windows.Forms.Button();
            this.uxEventListBox = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.91424F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.08576F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(583, 601);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.uxListBoxUsersInChatRoom);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(294, 339);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(283, 259);
            this.panel6.TabIndex = 3;
            // 
            // uxListBoxUsersInChatRoom
            // 
            this.uxListBoxUsersInChatRoom.FormattingEnabled = true;
            this.uxListBoxUsersInChatRoom.Location = new System.Drawing.Point(3, 20);
            this.uxListBoxUsersInChatRoom.Name = "uxListBoxUsersInChatRoom";
            this.uxListBoxUsersInChatRoom.Size = new System.Drawing.Size(277, 238);
            this.uxListBoxUsersInChatRoom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Users in Chatroom";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uxListBoxUserNames);
            this.panel1.Controls.Add(this.usersLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 330);
            this.panel1.TabIndex = 0;
            // 
            // uxListBoxUserNames
            // 
            this.uxListBoxUserNames.FormattingEnabled = true;
            this.uxListBoxUserNames.Location = new System.Drawing.Point(4, 25);
            this.uxListBoxUserNames.Name = "uxListBoxUserNames";
            this.uxListBoxUserNames.Size = new System.Drawing.Size(279, 303);
            this.uxListBoxUserNames.TabIndex = 1;
            this.uxListBoxUserNames.SelectedIndexChanged += new System.EventHandler(this.uxListBoxUserNames_SelectedIndexChanged);
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLabel.Location = new System.Drawing.Point(4, 4);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(49, 16);
            this.usersLabel.TabIndex = 0;
            this.usersLabel.Text = "Users";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uxListBoxContacts);
            this.panel2.Controls.Add(this.uxLabelContacts);
            this.panel2.Location = new System.Drawing.Point(294, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 330);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // uxListBoxContacts
            // 
            this.uxListBoxContacts.FormattingEnabled = true;
            this.uxListBoxContacts.Location = new System.Drawing.Point(7, 25);
            this.uxListBoxContacts.Name = "uxListBoxContacts";
            this.uxListBoxContacts.Size = new System.Drawing.Size(273, 303);
            this.uxListBoxContacts.TabIndex = 1;
            // 
            // uxLabelContacts
            // 
            this.uxLabelContacts.AutoSize = true;
            this.uxLabelContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelContacts.Location = new System.Drawing.Point(4, 4);
            this.uxLabelContacts.Name = "uxLabelContacts";
            this.uxLabelContacts.Size = new System.Drawing.Size(68, 16);
            this.uxLabelContacts.TabIndex = 0;
            this.uxLabelContacts.Text = "Contacts";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uxListBoxChatRooms);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 259);
            this.panel3.TabIndex = 2;
            // 
            // uxListBoxChatRooms
            // 
            this.uxListBoxChatRooms.FormattingEnabled = true;
            this.uxListBoxChatRooms.Location = new System.Drawing.Point(3, 20);
            this.uxListBoxChatRooms.Name = "uxListBoxChatRooms";
            this.uxListBoxChatRooms.Size = new System.Drawing.Size(277, 238);
            this.uxListBoxChatRooms.TabIndex = 3;
            this.uxListBoxChatRooms.SelectedIndexChanged += new System.EventHandler(this.uxListBoxChatRooms_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chat Rooms";
            // 
            // uxBtnStartServer
            // 
            this.uxBtnStartServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnStartServer.Location = new System.Drawing.Point(3, 3);
            this.uxBtnStartServer.Name = "uxBtnStartServer";
            this.uxBtnStartServer.Size = new System.Drawing.Size(198, 73);
            this.uxBtnStartServer.TabIndex = 2;
            this.uxBtnStartServer.Text = "Start Server";
            this.uxBtnStartServer.UseVisualStyleBackColor = true;
            this.uxBtnStartServer.Click += new System.EventHandler(this.uxBtnStartServer_Click);
            // 
            // uxBtnStopServer
            // 
            this.uxBtnStopServer.Enabled = false;
            this.uxBtnStopServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnStopServer.Location = new System.Drawing.Point(217, 3);
            this.uxBtnStopServer.Name = "uxBtnStopServer";
            this.uxBtnStopServer.Size = new System.Drawing.Size(192, 73);
            this.uxBtnStopServer.TabIndex = 3;
            this.uxBtnStopServer.Text = "Stop Server";
            this.uxBtnStopServer.UseVisualStyleBackColor = true;
            this.uxBtnStopServer.Click += new System.EventHandler(this.uxBtnStopServer_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.uxSaveLogBtn);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.uxButtonClearServerLog);
            this.panel4.Controls.Add(this.uxEventListBox);
            this.panel4.Location = new System.Drawing.Point(598, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(526, 515);
            this.panel4.TabIndex = 4;
            // 
            // uxSaveLogBtn
            // 
            this.uxSaveLogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveLogBtn.Location = new System.Drawing.Point(318, -1);
            this.uxSaveLogBtn.Name = "uxSaveLogBtn";
            this.uxSaveLogBtn.Size = new System.Drawing.Size(75, 23);
            this.uxSaveLogBtn.TabIndex = 3;
            this.uxSaveLogBtn.Text = "Save Log";
            this.uxSaveLogBtn.UseVisualStyleBackColor = true;
            this.uxSaveLogBtn.Click += new System.EventHandler(this.uxSaveLogBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Log";
            // 
            // uxButtonClearServerLog
            // 
            this.uxButtonClearServerLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonClearServerLog.Location = new System.Drawing.Point(399, 0);
            this.uxButtonClearServerLog.Name = "uxButtonClearServerLog";
            this.uxButtonClearServerLog.Size = new System.Drawing.Size(123, 23);
            this.uxButtonClearServerLog.TabIndex = 1;
            this.uxButtonClearServerLog.Text = "Clear Server Log";
            this.uxButtonClearServerLog.UseVisualStyleBackColor = true;
            this.uxButtonClearServerLog.Click += new System.EventHandler(this.uxButtonClearServerLog_Click);
            // 
            // uxEventListBox
            // 
            this.uxEventListBox.BackColor = System.Drawing.Color.DarkBlue;
            this.uxEventListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEventListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.uxEventListBox.FormattingEnabled = true;
            this.uxEventListBox.ItemHeight = 15;
            this.uxEventListBox.Location = new System.Drawing.Point(4, 27);
            this.uxEventListBox.Name = "uxEventListBox";
            this.uxEventListBox.Size = new System.Drawing.Size(519, 484);
            this.uxEventListBox.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.uxBtnStartServer);
            this.panel5.Controls.Add(this.uxBtnStopServer);
            this.panel5.Location = new System.Drawing.Point(598, 552);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(534, 79);
            this.panel5.TabIndex = 5;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 643);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerForm_FormClosing);
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox uxListBoxContacts;
        private System.Windows.Forms.Label uxLabelContacts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxBtnStartServer;
        private System.Windows.Forms.Button uxBtnStopServer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox uxEventListBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxButtonClearServerLog;
        private System.Windows.Forms.Button uxSaveLogBtn;
        private System.Windows.Forms.ListBox uxListBoxUserNames;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox uxListBoxUsersInChatRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox uxListBoxChatRooms;
    }
}