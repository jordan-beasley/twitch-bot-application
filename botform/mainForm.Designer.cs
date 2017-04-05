namespace botform
{
    partial class mainForm
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.chatDisplay = new System.Windows.Forms.TextBox();
            this.btnReconnect = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.lblChat = new System.Windows.Forms.Label();
            this.updateChat = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUpBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commResponse = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ContentPanel.Controls.Add(this.chatDisplay);
            this.ContentPanel.Controls.Add(this.btnReconnect);
            this.ContentPanel.Controls.Add(this.btnSubmit);
            this.ContentPanel.Controls.Add(this.chatBox);
            this.ContentPanel.Controls.Add(this.lblChat);
            this.ContentPanel.Location = new System.Drawing.Point(12, 33);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(579, 396);
            this.ContentPanel.TabIndex = 0;
            // 
            // chatDisplay
            // 
            this.chatDisplay.Location = new System.Drawing.Point(6, 23);
            this.chatDisplay.Multiline = true;
            this.chatDisplay.Name = "chatDisplay";
            this.chatDisplay.ReadOnly = true;
            this.chatDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatDisplay.Size = new System.Drawing.Size(464, 266);
            this.chatDisplay.TabIndex = 4;
            // 
            // btnReconnect
            // 
            this.btnReconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReconnect.Location = new System.Drawing.Point(476, 354);
            this.btnReconnect.Name = "btnReconnect";
            this.btnReconnect.Size = new System.Drawing.Size(92, 30);
            this.btnReconnect.TabIndex = 3;
            this.btnReconnect.Text = "Connect";
            this.btnReconnect.UseVisualStyleBackColor = true;
            this.btnReconnect.Click += new System.EventHandler(this.btnReconnect_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubmit.Location = new System.Drawing.Point(378, 354);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 30);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chatBox
            // 
            this.chatBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chatBox.Location = new System.Drawing.Point(6, 296);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(366, 88);
            this.chatBox.TabIndex = 1;
            // 
            // lblChat
            // 
            this.lblChat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChat.AutoSize = true;
            this.lblChat.Location = new System.Drawing.Point(3, 3);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(37, 17);
            this.lblChat.TabIndex = 0;
            this.lblChat.Text = "Chat";
            // 
            // updateChat
            // 
            this.updateChat.Tick += new System.EventHandler(this.chatDisplay_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(603, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUpBotToolStripMenuItem,
            this.configBotToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setUpBotToolStripMenuItem
            // 
            this.setUpBotToolStripMenuItem.Name = "setUpBotToolStripMenuItem";
            this.setUpBotToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.setUpBotToolStripMenuItem.Text = "Setup ";
            this.setUpBotToolStripMenuItem.Click += new System.EventHandler(this.setUpBotToolStripMenuItem_Click);
            // 
            // configBotToolStripMenuItem
            // 
            this.configBotToolStripMenuItem.Name = "configBotToolStripMenuItem";
            this.configBotToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.configBotToolStripMenuItem.Text = "Configure";
            this.configBotToolStripMenuItem.Click += new System.EventHandler(this.configBotToolStripMenuItem_Click);
            // 
            // commResponse
            // 
            this.commResponse.Interval = 5000;
            this.commResponse.Tick += new System.EventHandler(this.commResponse_Tick_1);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 441);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.menuStrip);
            this.Name = "mainForm";
            this.Text = "Chat Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.Timer updateChat;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setUpBotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configBotToolStripMenuItem;
        private System.Windows.Forms.Button btnReconnect;
        private System.Windows.Forms.TextBox chatDisplay;
        private System.Windows.Forms.Timer commResponse;
    }
}

