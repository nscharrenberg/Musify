namespace Musify_Application
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
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.genrePic)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(584, 107);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 28);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(540, 75);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(143, 22);
            this.searchTxt.TabIndex = 8;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(431, 80);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(94, 16);
            this.searchLbl.TabIndex = 9;
            this.searchLbl.Text = "Search Genre:";
            // 
            // genreFoundLbl
            // 
            this.genreFoundLbl.AutoSize = true;
            this.genreFoundLbl.Location = new System.Drawing.Point(431, 204);
            this.genreFoundLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreFoundLbl.Name = "genreFoundLbl";
            this.genreFoundLbl.Size = new System.Drawing.Size(0, 16);
            this.genreFoundLbl.TabIndex = 10;
            // 
            // genreList
            // 
            this.genreList.FormattingEnabled = true;
            this.genreList.HorizontalScrollbar = true;
            this.genreList.ItemHeight = 16;
            this.genreList.Location = new System.Drawing.Point(717, 75);
            this.genreList.Margin = new System.Windows.Forms.Padding(4);
            this.genreList.Name = "genreList";
            this.genreList.Size = new System.Drawing.Size(447, 388);
            this.genreList.TabIndex = 11;
            this.genreList.SelectedIndexChanged += new System.EventHandler(this.genreList_SelectedIndexChanged);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(115, 71);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(288, 22);
            this.nameTxt.TabIndex = 0;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(56, 75);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(48, 16);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name:";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(27, 107);
            this.descriptionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(76, 16);
            this.descriptionLbl.TabIndex = 3;
            this.descriptionLbl.Text = "Description";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(115, 103);
            this.descriptionTxt.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(288, 196);
            this.descriptionTxt.TabIndex = 4;
            this.descriptionTxt.Text = "";
            // 
            // h1Lbl
            // 
            this.h1Lbl.AutoSize = true;
            this.h1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h1Lbl.Location = new System.Drawing.Point(23, 11);
            this.h1Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.h1Lbl.Name = "h1Lbl";
            this.h1Lbl.Size = new System.Drawing.Size(202, 31);
            this.h1Lbl.TabIndex = 12;
            this.h1Lbl.Text = "GET GENRES";
            // 
            // addLbl
            // 
            this.addLbl.AutoSize = true;
            this.addLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLbl.Location = new System.Drawing.Point(23, 389);
            this.addLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addLbl.Name = "addLbl";
            this.addLbl.Size = new System.Drawing.Size(185, 31);
            this.addLbl.TabIndex = 13;
            this.addLbl.Text = "ADD GENRE";
            // 
            // namTxt
            // 
            this.namTxt.Location = new System.Drawing.Point(115, 457);
            this.namTxt.Margin = new System.Windows.Forms.Padding(4);
            this.namTxt.Name = "namTxt";
            this.namTxt.Size = new System.Drawing.Size(288, 22);
            this.namTxt.TabIndex = 14;
            // 
            // namLbl
            // 
            this.namLbl.AutoSize = true;
            this.namLbl.Location = new System.Drawing.Point(56, 461);
            this.namLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namLbl.Name = "namLbl";
            this.namLbl.Size = new System.Drawing.Size(48, 16);
            this.namLbl.TabIndex = 15;
            this.namLbl.Text = "Name:";
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(27, 521);
            this.descLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(79, 16);
            this.descLbl.TabIndex = 17;
            this.descLbl.Text = "Description:";
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(115, 521);
            this.descTxt.Margin = new System.Windows.Forms.Padding(4);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(288, 196);
            this.descTxt.TabIndex = 18;
            this.descTxt.Text = "";
            // 
            // imgLbl
            // 
            this.imgLbl.AutoSize = true;
            this.imgLbl.Location = new System.Drawing.Point(27, 493);
            this.imgLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imgLbl.Name = "imgLbl";
            this.imgLbl.Size = new System.Drawing.Size(79, 16);
            this.imgLbl.TabIndex = 20;
            this.imgLbl.Text = "Image Path:";
            // 
            // imgTxt
            // 
            this.imgTxt.Location = new System.Drawing.Point(115, 489);
            this.imgTxt.Margin = new System.Windows.Forms.Padding(4);
            this.imgTxt.Name = "imgTxt";
            this.imgTxt.Size = new System.Drawing.Size(288, 22);
            this.imgTxt.TabIndex = 19;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(304, 725);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 28);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click_1);
            // 
            // genrePic
            // 
            this.genrePic.Location = new System.Drawing.Point(412, 143);
            this.genrePic.Margin = new System.Windows.Forms.Padding(4);
            this.genrePic.Name = "genrePic";
            this.genrePic.Size = new System.Drawing.Size(272, 235);
            this.genrePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.genrePic.TabIndex = 22;
            this.genrePic.TabStop = false;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(410, 382);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 16);
            this.errorLbl.TabIndex = 23;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(303, 331);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(100, 28);
            this.updateBtn.TabIndex = 24;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // genreIDLbl
            // 
            this.genreIDLbl.AutoSize = true;
            this.genreIDLbl.Location = new System.Drawing.Point(112, 51);
            this.genreIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreIDLbl.Name = "genreIDLbl";
            this.genreIDLbl.Size = new System.Drawing.Size(21, 16);
            this.genreIDLbl.TabIndex = 25;
            this.genreIDLbl.Text = "ID";
            this.genreIDLbl.Visible = false;
            // 
            // imageUrlTxt
            // 
            this.imageUrlTxt.Location = new System.Drawing.Point(115, 307);
            this.imageUrlTxt.Margin = new System.Windows.Forms.Padding(4);
            this.imageUrlTxt.Name = "imageUrlTxt";
            this.imageUrlTxt.Size = new System.Drawing.Size(288, 22);
            this.imageUrlTxt.TabIndex = 26;
            // 
            // imageUrlLbl
            // 
            this.imageUrlLbl.AutoSize = true;
            this.imageUrlLbl.Location = new System.Drawing.Point(55, 310);
            this.imageUrlLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageUrlLbl.Name = "imageUrlLbl";
            this.imageUrlLbl.Size = new System.Drawing.Size(49, 16);
            this.imageUrlLbl.TabIndex = 27;
            this.imageUrlLbl.Text = "Image:";
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 5000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(1064, 471);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 28);
            this.deleteBtn.TabIndex = 28;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 763);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genrePic)).EndInit();
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
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Button deleteBtn;
    }
}

