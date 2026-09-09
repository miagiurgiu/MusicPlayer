namespace MusicPlayer
{
    partial class AddSongForm
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
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.songLabel = new System.Windows.Forms.Label();
            this.songTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // label2 - Audio file
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F);
            this.label2.Location = new System.Drawing.Point(50, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Audio file:";

            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.pathTextBox.Location = new System.Drawing.Point(160, 63);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(475, 26);
            this.pathTextBox.TabIndex = 0;

            // 
            // browseButton
            // 
            this.browseButton.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.browseButton.Location = new System.Drawing.Point(655, 57);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(95, 38);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click +=
                new System.EventHandler(this.browseButton_Click);

            // 
            // label1 - Artist
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F);
            this.label1.Location = new System.Drawing.Point(50, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Artist:";

            // 
            // artistTextBox
            // 
            this.artistTextBox.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.artistTextBox.Location = new System.Drawing.Point(160, 128);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(590, 26);
            this.artistTextBox.TabIndex = 3;

            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Font = new System.Drawing.Font("Candara", 12F);
            this.songLabel.Location = new System.Drawing.Point(50, 195);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(100, 24);
            this.songLabel.TabIndex = 5;
            this.songLabel.Text = "Song name:";

            // 
            // songTextBox
            // 
            this.songTextBox.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.songTextBox.Location = new System.Drawing.Point(160, 193);
            this.songTextBox.Name = "songTextBox";
            this.songTextBox.Size = new System.Drawing.Size(590, 26);
            this.songTextBox.TabIndex = 6;

            // 
            // importButton
            // 
            this.importButton.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.importButton.BackColor = System.Drawing.Color.DarkCyan;
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Font =
                new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.importButton.ForeColor = System.Drawing.Color.White;
            this.importButton.Location = new System.Drawing.Point(630, 270);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(120, 45);
            this.importButton.TabIndex = 2;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click +=
                new System.EventHandler(this.importButton_Click);

            // 
            // AddSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.MinimumSize = new System.Drawing.Size(600, 350);

            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.songLabel);
            this.Controls.Add(this.songTextBox);
            this.Controls.Add(this.importButton);

            this.Name = "AddSongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add song to database";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.TextBox songTextBox;
        private System.Windows.Forms.Label label2;
    }
}