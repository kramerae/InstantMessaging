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
            this.panel2 = new System.Windows.Forms.Panel();
            this.uxListBoxUsers = new System.Windows.Forms.ListBox();
            this.uxLabelContacts = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBoxUsers = new System.Windows.Forms.CheckedListBox();
            this.usersLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.uxBtnStartServer = new System.Windows.Forms.Button();
            this.uxBtnStopServer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uxEventListBox = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uxListBoxUsers);
            this.panel2.Controls.Add(this.uxLabelContacts);
            this.panel2.Location = new System.Drawing.Point(353, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 344);
            this.panel2.TabIndex = 1;
            // 
            // uxListBoxUsers
            // 
            this.uxListBoxUsers.FormattingEnabled = true;
            this.uxListBoxUsers.Location = new System.Drawing.Point(0, 24);
            this.uxListBoxUsers.Name = "uxListBoxUsers";
            this.uxListBoxUsers.Size = new System.Drawing.Size(340, 303);
            this.uxListBoxUsers.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.checkedListBoxUsers);
            this.panel1.Controls.Add(this.usersLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 344);
            this.panel1.TabIndex = 0;
            // 
            // checkedListBoxUsers
            // 
            this.checkedListBoxUsers.FormattingEnabled = true;
            this.checkedListBoxUsers.Location = new System.Drawing.Point(4, 24);
            this.checkedListBoxUsers.Name = "checkedListBoxUsers";
            this.checkedListBoxUsers.Size = new System.Drawing.Size(337, 304);
            this.checkedListBoxUsers.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Location = new System.Drawing.Point(13, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 247);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chat Rooms";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(7, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(686, 214);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.panel4.Controls.Add(this.uxEventListBox);
            this.panel4.Location = new System.Drawing.Point(720, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 515);
            this.panel4.TabIndex = 4;
            // 
            // uxEventListBox
            // 
            this.uxEventListBox.FormattingEnabled = true;
            this.uxEventListBox.Location = new System.Drawing.Point(3, 27);
            this.uxEventListBox.Name = "uxEventListBox";
            this.uxEventListBox.Size = new System.Drawing.Size(406, 485);
            this.uxEventListBox.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.uxBtnStartServer);
            this.panel5.Controls.Add(this.uxBtnStopServer);
            this.panel5.Location = new System.Drawing.Point(720, 552);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(412, 79);
            this.panel5.TabIndex = 5;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 643);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox uxListBoxUsers;
        private System.Windows.Forms.Label uxLabelContacts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBoxUsers;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button uxBtnStartServer;
        private System.Windows.Forms.Button uxBtnStopServer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox uxEventListBox;
        private System.Windows.Forms.Panel panel5;
    }
}