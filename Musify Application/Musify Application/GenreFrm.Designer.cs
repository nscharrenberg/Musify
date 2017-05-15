namespace Musify_Application
{
    partial class GenreFrm
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.genreFoundLbl = new System.Windows.Forms.Label();
            this.genreList = new System.Windows.Forms.ListBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.RichTextBox();
            this.h1Lbl = new System.Windows.Forms.Label();
            this.addLbl = new System.Windows.Forms.Label();
            this.namTxt = new System.Windows.Forms.TextBox();
            this.namLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.descTxt = new System.Windows.Forms.RichTextBox();
            this.imgLbl = new System.Windows.Forms.Label();
            this.imgTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.genrePic = new System.Windows.Forms.PictureBox();
            this.errorLbl = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.genreIDLbl = new System.Windows.Forms.Label();
            this.imageUrlTxt = new System.Windows.Forms.TextBox();
            this.imageUrlLbl = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.genrePic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(433, 121);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(400, 95);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(108, 20);
            this.searchTxt.TabIndex = 8;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(318, 99);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(76, 13);
            this.searchLbl.TabIndex = 9;
            this.searchLbl.Text = "Search Genre:";
            // 
            // genreFoundLbl
            // 
            this.genreFoundLbl.AutoSize = true;
            this.genreFoundLbl.Location = new System.Drawing.Point(318, 200);
            this.genreFoundLbl.Name = "genreFoundLbl";
            this.genreFoundLbl.Size = new System.Drawing.Size(0, 13);
            this.genreFoundLbl.TabIndex = 10;
            // 
            // genreList
            // 
            this.genreList.FormattingEnabled = true;
            this.genreList.HorizontalScrollbar = true;
            this.genreList.Location = new System.Drawing.Point(533, 95);
            this.genreList.Name = "genreList";
            this.genreList.Size = new System.Drawing.Size(336, 316);
            this.genreList.TabIndex = 11;
            this.genreList.SelectedIndexChanged += new System.EventHandler(this.genreList_SelectedIndexChanged);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(81, 92);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(217, 20);
            this.nameTxt.TabIndex = 0;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(37, 95);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name:";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(15, 121);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.descriptionLbl.TabIndex = 3;
            this.descriptionLbl.Text = "Description";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(81, 118);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(217, 160);
            this.descriptionTxt.TabIndex = 4;
            this.descriptionTxt.Text = "";
            // 
            // h1Lbl
            // 
            this.h1Lbl.AutoSize = true;
            this.h1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h1Lbl.Location = new System.Drawing.Point(12, 43);
            this.h1Lbl.Name = "h1Lbl";
            this.h1Lbl.Size = new System.Drawing.Size(202, 31);
            this.h1Lbl.TabIndex = 12;
            this.h1Lbl.Text = "GET GENRES";
            // 
            // addLbl
            // 
            this.addLbl.AutoSize = true;
            this.addLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLbl.Location = new System.Drawing.Point(12, 350);
            this.addLbl.Name = "addLbl";
            this.addLbl.Size = new System.Drawing.Size(185, 31);
            this.addLbl.TabIndex = 13;
            this.addLbl.Text = "ADD GENRE";
            // 
            // namTxt
            // 
            this.namTxt.Location = new System.Drawing.Point(81, 405);
            this.namTxt.Name = "namTxt";
            this.namTxt.Size = new System.Drawing.Size(217, 20);
            this.namTxt.TabIndex = 14;
            // 
            // namLbl
            // 
            this.namLbl.AutoSize = true;
            this.namLbl.Location = new System.Drawing.Point(37, 409);
            this.namLbl.Name = "namLbl";
            this.namLbl.Size = new System.Drawing.Size(38, 13);
            this.namLbl.TabIndex = 15;
            this.namLbl.Text = "Name:";
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(15, 457);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(63, 13);
            this.descLbl.TabIndex = 17;
            this.descLbl.Text = "Description:";
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(81, 457);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(217, 160);
            this.descTxt.TabIndex = 18;
            this.descTxt.Text = "";
            // 
            // imgLbl
            // 
            this.imgLbl.AutoSize = true;
            this.imgLbl.Location = new System.Drawing.Point(15, 435);
            this.imgLbl.Name = "imgLbl";
            this.imgLbl.Size = new System.Drawing.Size(64, 13);
            this.imgLbl.TabIndex = 20;
            this.imgLbl.Text = "Image Path:";
            // 
            // imgTxt
            // 
            this.imgTxt.Location = new System.Drawing.Point(81, 431);
            this.imgTxt.Name = "imgTxt";
            this.imgTxt.Size = new System.Drawing.Size(217, 20);
            this.imgTxt.TabIndex = 19;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(223, 623);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click_1);
            // 
            // genrePic
            // 
            this.genrePic.Location = new System.Drawing.Point(304, 150);
            this.genrePic.Name = "genrePic";
            this.genrePic.Size = new System.Drawing.Size(204, 191);
            this.genrePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.genrePic.TabIndex = 22;
            this.genrePic.TabStop = false;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(303, 344);
            this.errorLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 23;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(222, 303);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 24;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // genreIDLbl
            // 
            this.genreIDLbl.AutoSize = true;
            this.genreIDLbl.Location = new System.Drawing.Point(79, 75);
            this.genreIDLbl.Name = "genreIDLbl";
            this.genreIDLbl.Size = new System.Drawing.Size(18, 13);
            this.genreIDLbl.TabIndex = 25;
            this.genreIDLbl.Text = "ID";
            this.genreIDLbl.Visible = false;
            // 
            // imageUrlTxt
            // 
            this.imageUrlTxt.Location = new System.Drawing.Point(81, 283);
            this.imageUrlTxt.Name = "imageUrlTxt";
            this.imageUrlTxt.Size = new System.Drawing.Size(217, 20);
            this.imageUrlTxt.TabIndex = 26;
            // 
            // imageUrlLbl
            // 
            this.imageUrlLbl.AutoSize = true;
            this.imageUrlLbl.Location = new System.Drawing.Point(36, 286);
            this.imageUrlLbl.Name = "imageUrlLbl";
            this.imageUrlLbl.Size = new System.Drawing.Size(39, 13);
            this.imageUrlLbl.TabIndex = 27;
            this.imageUrlLbl.Text = "Image:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(793, 417);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 28;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(793, 65);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 29;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistToolStripMenuItem,
            this.playlistToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // artistToolStripMenuItem
            // 
            this.artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            this.artistToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.artistToolStripMenuItem.Text = "Artist";
            this.artistToolStripMenuItem.Click += new System.EventHandler(this.artistToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playlistToolStripMenuItem.Text = "Playlist";
            this.playlistToolStripMenuItem.Click += new System.EventHandler(this.playlistToolStripMenuItem_Click);
            // 
            // GenreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 716);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.imageUrlLbl);
            this.Controls.Add(this.imageUrlTxt);
            this.Controls.Add(this.genreIDLbl);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.genrePic);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.imgLbl);
            this.Controls.Add(this.imgTxt);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.namLbl);
            this.Controls.Add(this.namTxt);
            this.Controls.Add(this.addLbl);
            this.Controls.Add(this.h1Lbl);
            this.Controls.Add(this.genreList);
            this.Controls.Add(this.genreFoundLbl);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GenreFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genrePic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label genreFoundLbl;
        private System.Windows.Forms.ListBox genreList;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.RichTextBox descriptionTxt;
        private System.Windows.Forms.Label h1Lbl;
        private System.Windows.Forms.Label addLbl;
        private System.Windows.Forms.TextBox namTxt;
        private System.Windows.Forms.Label namLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.RichTextBox descTxt;
        private System.Windows.Forms.Label imgLbl;
        private System.Windows.Forms.TextBox imgTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox genrePic;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label genreIDLbl;
        private System.Windows.Forms.TextBox imageUrlTxt;
        private System.Windows.Forms.Label imageUrlLbl;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
    }
}

