namespace Musify_Application
{
    partial class Notification_Test
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
            this.notifyCountBtn = new System.Windows.Forms.Button();
            this.userLbl = new System.Windows.Forms.Label();
            this.userCombo = new System.Windows.Forms.ComboBox();
            this.chooseUserBtn = new System.Windows.Forms.Button();
            this.notificationList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyCountBtn
            // 
            this.notifyCountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notifyCountBtn.Location = new System.Drawing.Point(12, 70);
            this.notifyCountBtn.Name = "notifyCountBtn";
            this.notifyCountBtn.Size = new System.Drawing.Size(565, 48);
            this.notifyCountBtn.TabIndex = 0;
            this.notifyCountBtn.Text = "You have x Notifications";
            this.notifyCountBtn.UseVisualStyleBackColor = true;
            this.notifyCountBtn.Click += new System.EventHandler(this.notifyCountBtn_Click);
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(13, 35);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(32, 13);
            this.userLbl.TabIndex = 14;
            this.userLbl.Text = "User:";
            // 
            // userCombo
            // 
            this.userCombo.FormattingEnabled = true;
            this.userCombo.Location = new System.Drawing.Point(51, 32);
            this.userCombo.Name = "userCombo";
            this.userCombo.Size = new System.Drawing.Size(389, 21);
            this.userCombo.TabIndex = 13;
            // 
            // chooseUserBtn
            // 
            this.chooseUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseUserBtn.Location = new System.Drawing.Point(446, 30);
            this.chooseUserBtn.Name = "chooseUserBtn";
            this.chooseUserBtn.Size = new System.Drawing.Size(131, 34);
            this.chooseUserBtn.TabIndex = 15;
            this.chooseUserBtn.Text = "Load Notifications";
            this.chooseUserBtn.UseVisualStyleBackColor = true;
            this.chooseUserBtn.Click += new System.EventHandler(this.chooseUserBtn_Click);
            // 
            // notificationList
            // 
            this.notificationList.FormattingEnabled = true;
            this.notificationList.Location = new System.Drawing.Point(12, 125);
            this.notificationList.Name = "notificationList";
            this.notificationList.Size = new System.Drawing.Size(565, 316);
            this.notificationList.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificationsToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.notificationsToolStripMenuItem.Text = "Playlist";
            this.notificationsToolStripMenuItem.Click += new System.EventHandler(this.notificationsToolStripMenuItem_Click);
            // 
            // Notification_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 452);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.notificationList);
            this.Controls.Add(this.chooseUserBtn);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.userCombo);
            this.Controls.Add(this.notifyCountBtn);
            this.Name = "Notification_Test";
            this.Text = "Notification_Test";
            this.Load += new System.EventHandler(this.Notification_Test_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button notifyCountBtn;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.ComboBox userCombo;
        private System.Windows.Forms.Button chooseUserBtn;
        private System.Windows.Forms.ListBox notificationList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationsToolStripMenuItem;
    }
}