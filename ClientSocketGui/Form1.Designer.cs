namespace ClientSocketGui
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.tbOnlineUsers = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbServer = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbOnlineUsers = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tipRefresh = new System.Windows.Forms.ToolTip(this.components);
            this.tipSend = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tbMessage
            // 
            this.tbMessage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbMessage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbMessage.Location = new System.Drawing.Point(12, 354);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(672, 49);
            this.tbMessage.TabIndex = 3;
            this.tbMessage.Text = "Type message here...";
            // 
            // tbChat
            // 
            this.tbChat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbChat.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbChat.Location = new System.Drawing.Point(12, 80);
            this.tbChat.Multiline = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.ReadOnly = true;
            this.tbChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbChat.Size = new System.Drawing.Size(478, 268);
            this.tbChat.TabIndex = 0;
            this.tbChat.TabStop = false;
            this.tbChat.Text = "Chat will be here";
            // 
            // tbOnlineUsers
            // 
            this.tbOnlineUsers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbOnlineUsers.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOnlineUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbOnlineUsers.Location = new System.Drawing.Point(496, 80);
            this.tbOnlineUsers.Multiline = true;
            this.tbOnlineUsers.Name = "tbOnlineUsers";
            this.tbOnlineUsers.ReadOnly = true;
            this.tbOnlineUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOnlineUsers.Size = new System.Drawing.Size(188, 268);
            this.tbOnlineUsers.TabIndex = 0;
            this.tbOnlineUsers.TabStop = false;
            this.tbOnlineUsers.Text = "Users";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogIn.Location = new System.Drawing.Point(310, 26);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(180, 32);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbInfo.Location = new System.Drawing.Point(16, 483);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(72, 19);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Info : ";
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbServer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbServer.Location = new System.Drawing.Point(16, 453);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(288, 19);
            this.lbServer.TabIndex = 0;
            this.lbServer.Text = "Server : 192.168.777.777 : 8888";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbUserName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbUserName.Location = new System.Drawing.Point(124, 26);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(180, 30);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Text = "User name";
            // 
            // lbOnlineUsers
            // 
            this.lbOnlineUsers.AutoSize = true;
            this.lbOnlineUsers.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOnlineUsers.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbOnlineUsers.Location = new System.Drawing.Point(529, 33);
            this.lbOnlineUsers.Name = "lbOnlineUsers";
            this.lbOnlineUsers.Size = new System.Drawing.Size(117, 19);
            this.lbOnlineUsers.TabIndex = 0;
            this.lbOnlineUsers.Text = "Online users";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUser.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbUser.Location = new System.Drawing.Point(30, 33);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(72, 19);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "User >_";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSend.Location = new System.Drawing.Point(12, 409);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(220, 32);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRefresh.Location = new System.Drawing.Point(238, 409);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(220, 32);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Enabled = false;
            this.btnLogOut.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogOut.Location = new System.Drawing.Point(464, 409);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(220, 32);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(696, 515);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.tbChat);
            this.Controls.Add(this.tbOnlineUsers);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbOnlineUsers);
            this.Controls.Add(this.lbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(712, 553);
            this.MinimumSize = new System.Drawing.Size(712, 553);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatiko";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.TextBox tbOnlineUsers;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbOnlineUsers;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ToolTip tipRefresh;
        private System.Windows.Forms.ToolTip tipSend;
    }
}

