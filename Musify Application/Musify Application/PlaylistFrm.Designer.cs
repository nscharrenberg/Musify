namespace Musify_Application
{
    partial class PlaylistFrm
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
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.userCombo = new System.Windows.Forms.ComboBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.imageLbl = new System.Windows.Forms.Label();
            this.imageTxt = new System.Windows.Forms.TextBox();
            this.publicCheck = new System.Windows.Forms.CheckBox();
            this.publicLbl = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTxt.Location = new System.Drawing.Point(84, 63);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(229, 20);
            this.nameTxt.TabIndex = 0;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(16, 65);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name:";
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(21, 249);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(292, 94);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Make Playlist";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // userCombo
            // 
            this.userCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userCombo.FormattingEnabled = true;
            this.userCombo.Location = new System.Drawing.Point(84, 36);
            this.userCombo.Name = "userCombo";
            this.userCombo.Size = new System.Drawing.Size(229, 21);
            this.userCombo.TabIndex = 3;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(16, 91);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.descriptionLbl.TabIndex = 5;
            this.descriptionLbl.Text = "Description:";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTxt.Location = new System.Drawing.Point(84, 89);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(229, 95);
            this.descriptionTxt.TabIndex = 4;
            // 
            // imageLbl
            // 
            this.imageLbl.AutoSize = true;
            this.imageLbl.Location = new System.Drawing.Point(18, 192);
            this.imageLbl.Name = "imageLbl";
            this.imageLbl.Size = new System.Drawing.Size(64, 13);
            this.imageLbl.TabIndex = 7;
            this.imageLbl.Text = "Image URL:";
            // 
            // imageTxt
            // 
            this.imageTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageTxt.Location = new System.Drawing.Point(86, 190);
            this.imageTxt.Name = "imageTxt";
            this.imageTxt.Size = new System.Drawing.Size(227, 20);
            this.imageTxt.TabIndex = 6;
            // 
            // publicCheck
            // 
            this.publicCheck.AutoSize = true;
            this.publicCheck.Checked = true;
            this.publicCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.publicCheck.Location = new System.Drawing.Point(86, 218);
            this.publicCheck.Name = "publicCheck";
            this.publicCheck.Size = new System.Drawing.Size(15, 14);
            this.publicCheck.TabIndex = 8;
            this.publicCheck.UseVisualStyleBackColor = true;
            // 
            // publicLbl
            // 
            this.publicLbl.AutoSize = true;
            this.publicLbl.Location = new System.Drawing.Point(18, 218);
            this.publicLbl.Name = "publicLbl";
            this.publicLbl.Size = new System.Drawing.Size(36, 13);
            this.publicLbl.TabIndex = 10;
            this.publicLbl.Text = "Public";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(16, 39);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(32, 13);
            this.userLbl.TabIndex = 12;
            this.userLbl.Text = "User:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(325, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreToolStripMenuItem,
            this.genreToolStripMenuItem1,
            this.notificationsToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.genreToolStripMenuItem.Text = "Artist";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem1
            // 
            this.genreToolStripMenuItem1.Name = "genreToolStripMenuItem1";
            this.genreToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.genreToolStripMenuItem1.Text = "Genre";
            this.genreToolStripMenuItem1.Click += new System.EventHandler(this.genreToolStripMenuItem1_Click);
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.notificationsToolStripMenuItem.Text = "Notifications";
            this.notificationsToolStripMenuItem.Click += new System.EventHandler(this.notificationsToolStripMenuItem_Click);
            // 
            // PlaylistFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 358);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.publicLbl);
            this.Controls.Add(this.publicCheck);
            this.Controls.Add(this.imageLbl);
            this.Controls.Add(this.imageTxt);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.userCombo);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameTxt);
            this.Name = "PlaylistFrm";
            this.Text = "PlaylistFrm";
            this.Load += new System.EventHandler(this.PlaylistFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.ComboBox userCombo;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label imageLbl;
        private System.Windows.Forms.TextBox imageTxt;
        private System.Windows.Forms.CheckBox publicCheck;
        private System.Windows.Forms.Label publicLbl;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notificationsToolStripMenuItem;
    }
}