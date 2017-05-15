namespace Musify_Application
{
    partial class ArtistFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigImgLbl = new System.Windows.Forms.Label();
            this.addBigImageTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.addNameTxt = new System.Windows.Forms.TextBox();
            this.addLbl = new System.Windows.Forms.Label();
            this.smallImageLbl = new System.Windows.Forms.Label();
            this.addSmallImageTxt = new System.Windows.Forms.TextBox();
            this.addBioTxt = new System.Windows.Forms.RichTextBox();
            this.bioLbl = new System.Windows.Forms.Label();
            this.addArtistBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.artistPic = new System.Windows.Forms.PictureBox();
            this.artistList = new System.Windows.Forms.ListBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.updateArtistBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateBiographyTxt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateSmallImageTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateBigImageTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.artistIDLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.genreList = new System.Windows.Forms.CheckedListBox();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistPic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1516, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreToolStripMenuItem,
            this.playlistToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // bigImgLbl
            // 
            this.bigImgLbl.AutoSize = true;
            this.bigImgLbl.Location = new System.Drawing.Point(18, 497);
            this.bigImgLbl.Name = "bigImgLbl";
            this.bigImgLbl.Size = new System.Drawing.Size(57, 13);
            this.bigImgLbl.TabIndex = 28;
            this.bigImgLbl.Text = "Big Image:";
            // 
            // addBigImageTxt
            // 
            this.addBigImageTxt.Location = new System.Drawing.Point(81, 494);
            this.addBigImageTxt.Name = "addBigImageTxt";
            this.addBigImageTxt.Size = new System.Drawing.Size(217, 20);
            this.addBigImageTxt.TabIndex = 27;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(37, 472);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 26;
            this.nameLbl.Text = "Name:";
            // 
            // addNameTxt
            // 
            this.addNameTxt.Location = new System.Drawing.Point(81, 468);
            this.addNameTxt.Name = "addNameTxt";
            this.addNameTxt.Size = new System.Drawing.Size(217, 20);
            this.addNameTxt.TabIndex = 25;
            // 
            // addLbl
            // 
            this.addLbl.AutoSize = true;
            this.addLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLbl.Location = new System.Drawing.Point(12, 413);
            this.addLbl.Name = "addLbl";
            this.addLbl.Size = new System.Drawing.Size(187, 31);
            this.addLbl.TabIndex = 24;
            this.addLbl.Text = "ADD ARTIST";
            // 
            // smallImageLbl
            // 
            this.smallImageLbl.AutoSize = true;
            this.smallImageLbl.Location = new System.Drawing.Point(8, 523);
            this.smallImageLbl.Name = "smallImageLbl";
            this.smallImageLbl.Size = new System.Drawing.Size(67, 13);
            this.smallImageLbl.TabIndex = 30;
            this.smallImageLbl.Text = "Small Image:";
            // 
            // addSmallImageTxt
            // 
            this.addSmallImageTxt.Location = new System.Drawing.Point(81, 520);
            this.addSmallImageTxt.Name = "addSmallImageTxt";
            this.addSmallImageTxt.Size = new System.Drawing.Size(217, 20);
            this.addSmallImageTxt.TabIndex = 29;
            // 
            // addBioTxt
            // 
            this.addBioTxt.Location = new System.Drawing.Point(81, 546);
            this.addBioTxt.Name = "addBioTxt";
            this.addBioTxt.Size = new System.Drawing.Size(217, 142);
            this.addBioTxt.TabIndex = 31;
            this.addBioTxt.Text = "";
            // 
            // bioLbl
            // 
            this.bioLbl.AutoSize = true;
            this.bioLbl.Location = new System.Drawing.Point(15, 549);
            this.bioLbl.Name = "bioLbl";
            this.bioLbl.Size = new System.Drawing.Size(57, 13);
            this.bioLbl.TabIndex = 32;
            this.bioLbl.Text = "Biography:";
            // 
            // addArtistBtn
            // 
            this.addArtistBtn.Location = new System.Drawing.Point(223, 694);
            this.addArtistBtn.Name = "addArtistBtn";
            this.addArtistBtn.Size = new System.Drawing.Size(75, 23);
            this.addArtistBtn.TabIndex = 33;
            this.addArtistBtn.Text = "Save";
            this.addArtistBtn.UseVisualStyleBackColor = true;
            this.addArtistBtn.Click += new System.EventHandler(this.addArtistBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(1189, 75);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 40;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(1189, 427);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 39;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // artistPic
            // 
            this.artistPic.Location = new System.Drawing.Point(700, 160);
            this.artistPic.Name = "artistPic";
            this.artistPic.Size = new System.Drawing.Size(204, 191);
            this.artistPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.artistPic.TabIndex = 38;
            this.artistPic.TabStop = false;
            // 
            // artistList
            // 
            this.artistList.FormattingEnabled = true;
            this.artistList.HorizontalScrollbar = true;
            this.artistList.Location = new System.Drawing.Point(929, 105);
            this.artistList.Name = "artistList";
            this.artistList.Size = new System.Drawing.Size(336, 316);
            this.artistList.TabIndex = 37;
            this.artistList.SelectedIndexChanged += new System.EventHandler(this.artistList_SelectedIndexChanged);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(714, 109);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(70, 13);
            this.searchLbl.TabIndex = 36;
            this.searchLbl.Text = "Search Artist:";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(796, 105);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(108, 20);
            this.searchTxt.TabIndex = 35;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(829, 131);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 34;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // updateArtistBtn
            // 
            this.updateArtistBtn.Location = new System.Drawing.Point(223, 305);
            this.updateArtistBtn.Name = "updateArtistBtn";
            this.updateArtistBtn.Size = new System.Drawing.Size(75, 23);
            this.updateArtistBtn.TabIndex = 50;
            this.updateArtistBtn.Text = "Update";
            this.updateArtistBtn.UseVisualStyleBackColor = true;
            this.updateArtistBtn.Click += new System.EventHandler(this.updateArtistBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Biography:";
            // 
            // UpdateBiographyTxt
            // 
            this.UpdateBiographyTxt.Location = new System.Drawing.Point(81, 157);
            this.UpdateBiographyTxt.Name = "UpdateBiographyTxt";
            this.UpdateBiographyTxt.Size = new System.Drawing.Size(217, 142);
            this.UpdateBiographyTxt.TabIndex = 48;
            this.UpdateBiographyTxt.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Small Image:";
            // 
            // UpdateSmallImageTxt
            // 
            this.UpdateSmallImageTxt.Location = new System.Drawing.Point(81, 131);
            this.UpdateSmallImageTxt.Name = "UpdateSmallImageTxt";
            this.UpdateSmallImageTxt.Size = new System.Drawing.Size(217, 20);
            this.UpdateSmallImageTxt.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Big Image:";
            // 
            // UpdateBigImageTxt
            // 
            this.UpdateBigImageTxt.Location = new System.Drawing.Point(81, 105);
            this.UpdateBigImageTxt.Name = "UpdateBigImageTxt";
            this.UpdateBigImageTxt.Size = new System.Drawing.Size(217, 20);
            this.UpdateBigImageTxt.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Name:";
            // 
            // updateNameTxt
            // 
            this.updateNameTxt.Location = new System.Drawing.Point(81, 79);
            this.updateNameTxt.Name = "updateNameTxt";
            this.updateNameTxt.Size = new System.Drawing.Size(217, 20);
            this.updateNameTxt.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 31);
            this.label5.TabIndex = 41;
            this.label5.Text = "ADD ARTIST";
            // 
            // artistIDLbl
            // 
            this.artistIDLbl.AutoSize = true;
            this.artistIDLbl.Location = new System.Drawing.Point(78, 55);
            this.artistIDLbl.Name = "artistIDLbl";
            this.artistIDLbl.Size = new System.Drawing.Size(18, 13);
            this.artistIDLbl.TabIndex = 51;
            this.artistIDLbl.Text = "ID";
            this.artistIDLbl.Visible = false;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(318, 343);
            this.errorLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 52;
            // 
            // genreList
            // 
            this.genreList.FormattingEnabled = true;
            this.genreList.Location = new System.Drawing.Point(304, 79);
            this.genreList.Name = "genreList";
            this.genreList.Size = new System.Drawing.Size(203, 214);
            this.genreList.TabIndex = 53;
            this.genreList.SelectedIndexChanged += new System.EventHandler(this.genreList_SelectedIndexChanged);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playlistToolStripMenuItem.Text = "Playlist";
            this.playlistToolStripMenuItem.Click += new System.EventHandler(this.playlistToolStripMenuItem_Click);
            // 
            // ArtistFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 742);
            this.Controls.Add(this.genreList);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.artistIDLbl);
            this.Controls.Add(this.updateArtistBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateBiographyTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateSmallImageTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpdateBigImageTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateNameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.artistPic);
            this.Controls.Add(this.artistList);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.addArtistBtn);
            this.Controls.Add(this.bioLbl);
            this.Controls.Add(this.addBioTxt);
            this.Controls.Add(this.smallImageLbl);
            this.Controls.Add(this.addSmallImageTxt);
            this.Controls.Add(this.bigImgLbl);
            this.Controls.Add(this.addBigImageTxt);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.addNameTxt);
            this.Controls.Add(this.addLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ArtistFrm";
            this.Text = "Artist";
            this.Load += new System.EventHandler(this.ArtistFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.Label bigImgLbl;
        private System.Windows.Forms.TextBox addBigImageTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox addNameTxt;
        private System.Windows.Forms.Label addLbl;
        private System.Windows.Forms.Label smallImageLbl;
        private System.Windows.Forms.TextBox addSmallImageTxt;
        private System.Windows.Forms.RichTextBox addBioTxt;
        private System.Windows.Forms.Label bioLbl;
        private System.Windows.Forms.Button addArtistBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.PictureBox artistPic;
        private System.Windows.Forms.ListBox artistList;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button updateArtistBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox UpdateBiographyTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UpdateSmallImageTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UpdateBigImageTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox updateNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label artistIDLbl;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.CheckedListBox genreList;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
    }
}