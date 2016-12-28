namespace botform
{
    partial class ActivateBot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.botnameBox = new System.Windows.Forms.TextBox();
            this.btnLoadAuth = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblBotUsername = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.authBox = new System.Windows.Forms.TextBox();
            this.lblAuth = new System.Windows.Forms.Label();
            this.cbLoadFile = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.cbMonChat1 = new System.Windows.Forms.CheckBox();
            this.cbMonChat2 = new System.Windows.Forms.CheckBox();
            this.lblMonChat = new System.Windows.Forms.Label();
            this.monChatBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameBox.Location = new System.Drawing.Point(185, 123);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(230, 22);
            this.usernameBox.TabIndex = 0;
            // 
            // botnameBox
            // 
            this.botnameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botnameBox.Location = new System.Drawing.Point(185, 162);
            this.botnameBox.Name = "botnameBox";
            this.botnameBox.Size = new System.Drawing.Size(230, 22);
            this.botnameBox.TabIndex = 1;
            // 
            // btnLoadAuth
            // 
            this.btnLoadAuth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadAuth.Location = new System.Drawing.Point(222, 190);
            this.btnLoadAuth.Name = "btnLoadAuth";
            this.btnLoadAuth.Size = new System.Drawing.Size(152, 29);
            this.btnLoadAuth.TabIndex = 2;
            this.btnLoadAuth.Text = "Load Auth Token";
            this.btnLoadAuth.UseVisualStyleBackColor = true;
            this.btnLoadAuth.Click += new System.EventHandler(this.btnLoadAuth_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(66, 128);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // lblBotUsername
            // 
            this.lblBotUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBotUsername.AutoSize = true;
            this.lblBotUsername.Location = new System.Drawing.Point(66, 167);
            this.lblBotUsername.Name = "lblBotUsername";
            this.lblBotUsername.Size = new System.Drawing.Size(108, 17);
            this.lblBotUsername.TabIndex = 4;
            this.lblBotUsername.Text = "Bot User Name:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Location = new System.Drawing.Point(222, 317);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(152, 29);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // authBox
            // 
            this.authBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authBox.Location = new System.Drawing.Point(185, 197);
            this.authBox.Name = "authBox";
            this.authBox.Size = new System.Drawing.Size(230, 22);
            this.authBox.TabIndex = 6;
            // 
            // lblAuth
            // 
            this.lblAuth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAuth.AutoSize = true;
            this.lblAuth.Location = new System.Drawing.Point(66, 202);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(85, 17);
            this.lblAuth.TabIndex = 7;
            this.lblAuth.Text = "Auth Token:";
            // 
            // cbLoadFile
            // 
            this.cbLoadFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLoadFile.AutoSize = true;
            this.cbLoadFile.Location = new System.Drawing.Point(422, 202);
            this.cbLoadFile.Name = "cbLoadFile";
            this.cbLoadFile.Size = new System.Drawing.Size(88, 21);
            this.cbLoadFile.TabIndex = 8;
            this.cbLoadFile.Text = "Load File";
            this.cbLoadFile.UseVisualStyleBackColor = true;
            this.cbLoadFile.CheckedChanged += new System.EventHandler(this.cbLoadFile_CheckedChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(4, 421);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 9;
            // 
            // cbMonChat1
            // 
            this.cbMonChat1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMonChat1.AutoSize = true;
            this.cbMonChat1.Location = new System.Drawing.Point(185, 235);
            this.cbMonChat1.Name = "cbMonChat1";
            this.cbMonChat1.Size = new System.Drawing.Size(81, 21);
            this.cbMonChat1.TabIndex = 10;
            this.cbMonChat1.Text = "My Chat";
            this.cbMonChat1.UseVisualStyleBackColor = true;
            this.cbMonChat1.CheckedChanged += new System.EventHandler(this.cbMonChat1_CheckedChanged);
            // 
            // cbMonChat2
            // 
            this.cbMonChat2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMonChat2.AutoSize = true;
            this.cbMonChat2.Location = new System.Drawing.Point(349, 235);
            this.cbMonChat2.Name = "cbMonChat2";
            this.cbMonChat2.Size = new System.Drawing.Size(66, 21);
            this.cbMonChat2.TabIndex = 11;
            this.cbMonChat2.Text = "Other";
            this.cbMonChat2.UseVisualStyleBackColor = true;
            this.cbMonChat2.CheckedChanged += new System.EventHandler(this.cbMonChat2_CheckedChanged);
            // 
            // lblMonChat
            // 
            this.lblMonChat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonChat.AutoSize = true;
            this.lblMonChat.Location = new System.Drawing.Point(66, 239);
            this.lblMonChat.Name = "lblMonChat";
            this.lblMonChat.Size = new System.Drawing.Size(92, 17);
            this.lblMonChat.TabIndex = 12;
            this.lblMonChat.Text = "Monitor Chat:";
            // 
            // monChatBox
            // 
            this.monChatBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monChatBox.Location = new System.Drawing.Point(185, 266);
            this.monChatBox.Name = "monChatBox";
            this.monChatBox.Size = new System.Drawing.Size(230, 22);
            this.monChatBox.TabIndex = 13;
            // 
            // ActivateBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.monChatBox);
            this.Controls.Add(this.lblMonChat);
            this.Controls.Add(this.cbMonChat2);
            this.Controls.Add(this.cbMonChat1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cbLoadFile);
            this.Controls.Add(this.lblAuth);
            this.Controls.Add(this.authBox);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblBotUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLoadAuth);
            this.Controls.Add(this.botnameBox);
            this.Controls.Add(this.usernameBox);
            this.Name = "ActivateBot";
            this.Size = new System.Drawing.Size(558, 441);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox botnameBox;
        private System.Windows.Forms.Button btnLoadAuth;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblBotUsername;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox authBox;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.CheckBox cbLoadFile;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox cbMonChat1;
        private System.Windows.Forms.CheckBox cbMonChat2;
        private System.Windows.Forms.Label lblMonChat;
        private System.Windows.Forms.TextBox monChatBox;
    }
}
