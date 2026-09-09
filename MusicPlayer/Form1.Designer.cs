namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private System.Windows.Forms.Button addPlaylistButton;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label5 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Label();
            this.displaySongs = new System.Windows.Forms.Button();
            this.deleteSongs = new System.Windows.Forms.Button();
            this.displayPlaylists = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.addPlaylistButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addSongToDatabaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(64, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "NOW PLAYING:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.ForeColor = System.Drawing.Color.DarkCyan;
            this.title.Location = new System.Drawing.Point(345, 114);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(0, 39);
            this.title.TabIndex = 5;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.BackColor = System.Drawing.Color.Transparent;
            this.artistLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.artistLabel.Location = new System.Drawing.Point(347, 153);
            this.artistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(70, 29);
            this.artistLabel.TabIndex = 6;
            this.artistLabel.Text = "Artist";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.Location = new System.Drawing.Point(904, 103);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(60, 60);
            this.playButton.TabIndex = 7;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.Transparent;
            this.previousButton.Image = ((System.Drawing.Image)(resources.GetObject("previousButton.Image")));
            this.previousButton.Location = new System.Drawing.Point(827, 103);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(60, 60);
            this.previousButton.TabIndex = 10;
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.Location = new System.Drawing.Point(989, 103);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(60, 60);
            this.nextButton.TabIndex = 11;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Location = new System.Drawing.Point(168, 160);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(96, 32);
            this.help.TabIndex = 12;
            this.help.Text = "label6";
            this.help.Visible = false;
            // 
            // displaySongs
            // 
            this.displaySongs.BackColor = System.Drawing.Color.White;
            this.displaySongs.BackgroundImage = CreateButtonGradient(469, 46);
            this.displaySongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displaySongs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(80, 180, 178);
            this.displaySongs.FlatAppearance.BorderSize = 1;
            this.displaySongs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(205, 238, 235);
            this.displaySongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displaySongs.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.displaySongs.ForeColor = System.Drawing.Color.FromArgb(20, 75, 78);
            this.displaySongs.Location = new System.Drawing.Point(69, 270);
            this.displaySongs.Name = "displaySongs";
            this.displaySongs.Size = new System.Drawing.Size(469, 46);
            this.displaySongs.TabIndex = 13;
            this.displaySongs.Text = "Display all songs";
            this.displaySongs.UseVisualStyleBackColor = false;
            this.displaySongs.Click += new System.EventHandler(this.displaySongs_Click);
            // 
            // deleteSongs
            // 
            this.deleteSongs.BackColor = System.Drawing.Color.White;
            this.deleteSongs.BackgroundImage = CreateButtonGradient(469, 46);
            this.deleteSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteSongs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(80, 180, 178);
            this.deleteSongs.FlatAppearance.BorderSize = 1;
            this.deleteSongs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(205, 238, 235);
            this.deleteSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSongs.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.deleteSongs.ForeColor = System.Drawing.Color.FromArgb(20, 75, 78);
            this.deleteSongs.Location = new System.Drawing.Point(69, 328);
            this.deleteSongs.Name = "deleteSongs";
            this.deleteSongs.Size = new System.Drawing.Size(469, 46);
            this.deleteSongs.TabIndex = 14;
            this.deleteSongs.Text = "Delete songs";
            this.deleteSongs.UseVisualStyleBackColor = false;
            this.deleteSongs.Click += new System.EventHandler(this.deleteSongs_Click);
            // 
            // displayPlaylists
            // 
            this.displayPlaylists.BackColor = System.Drawing.Color.White;
            this.displayPlaylists.BackgroundImage = CreateButtonGradient(469, 46);
            this.displayPlaylists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayPlaylists.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(80, 180, 178);
            this.displayPlaylists.FlatAppearance.BorderSize = 1;
            this.displayPlaylists.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(205, 238, 235);
            this.displayPlaylists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayPlaylists.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.displayPlaylists.ForeColor = System.Drawing.Color.FromArgb(20, 75, 78);
            this.displayPlaylists.Location = new System.Drawing.Point(69, 386);
            this.displayPlaylists.Name = "displayPlaylists";
            this.displayPlaylists.Size = new System.Drawing.Size(469, 46);
            this.displayPlaylists.TabIndex = 15;
            this.displayPlaylists.Text = "Display all playlists";
            this.displayPlaylists.UseVisualStyleBackColor = false;
            this.displayPlaylists.Click += new System.EventHandler(this.displayPlaylists_Click);

            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Candara", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.Location = new System.Drawing.Point(691, 109);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(130, 54);
            this.timeLabel.TabIndex = 16;
            this.timeLabel.Text = "00:00";
            // 
            // addPlaylistButton
            // 
            this.addPlaylistButton.BackColor = System.Drawing.Color.White;
            this.addPlaylistButton.BackgroundImage = CreateButtonGradient(469, 46);
            this.addPlaylistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addPlaylistButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(80, 180, 178);
            this.addPlaylistButton.FlatAppearance.BorderSize = 1;
            this.addPlaylistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(205, 238, 235);
            this.addPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlaylistButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.addPlaylistButton.ForeColor = System.Drawing.Color.FromArgb(20, 75, 78);
            this.addPlaylistButton.Location = new System.Drawing.Point(69, 444);
            this.addPlaylistButton.Name = "addPlaylistButton";
            this.addPlaylistButton.Size = new System.Drawing.Size(469, 46);
            this.addPlaylistButton.TabIndex = 17;
            this.addPlaylistButton.Text = "Add new playlist";
            this.addPlaylistButton.UseVisualStyleBackColor = false;
            this.addPlaylistButton.Click += new System.EventHandler(this.addPlaylistButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(0, 0);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(0, 0);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 26);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // addSongToDatabaseButton
            // 
            this.addSongToDatabaseButton.BackColor = System.Drawing.Color.White;
            this.addSongToDatabaseButton.BackgroundImage = CreateButtonGradient(469, 46);
            this.addSongToDatabaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addSongToDatabaseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(80, 180, 178);
            this.addSongToDatabaseButton.FlatAppearance.BorderSize = 1;
            this.addSongToDatabaseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(205, 238, 235);
            this.addSongToDatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSongToDatabaseButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.addSongToDatabaseButton.ForeColor = System.Drawing.Color.FromArgb(20, 75, 78);
            this.addSongToDatabaseButton.Location = new System.Drawing.Point(69, 212);
            this.addSongToDatabaseButton.Name = "addSongToDatabaseButton";
            this.addSongToDatabaseButton.Size = new System.Drawing.Size(469, 46);
            this.addSongToDatabaseButton.TabIndex = 18;
            this.addSongToDatabaseButton.Text = "Add new song to database";
            this.addSongToDatabaseButton.UseVisualStyleBackColor = false;
            this.addSongToDatabaseButton.Click += new System.EventHandler(this.addSongToDatabaseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 540);
            this.Controls.Add(this.addSongToDatabaseButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.displayPlaylists);
            this.Controls.Add(this.deleteSongs);
            this.Controls.Add(this.displaySongs);
            this.Controls.Add(this.help);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addPlaylistButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Drawing.Image CreateButtonGradient(int width, int height)
        {
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(width, height);

            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bmp))
            using (System.Drawing.Drawing2D.LinearGradientBrush brush =
                new System.Drawing.Drawing2D.LinearGradientBrush(
                    new System.Drawing.Rectangle(0, 0, width, height),
                    System.Drawing.Color.FromArgb(225, 245, 243),
                    System.Drawing.Color.FromArgb(250, 253, 253),
                    System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
            {
                g.FillRectangle(brush, 0, 0, width, height);
            }

            return bmp;
        }
        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.Button displaySongs;
        private System.Windows.Forms.Button deleteSongs;
        private System.Windows.Forms.Button displayPlaylists;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button addPlaylistButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button addSongToDatabaseButton;
    }
}
