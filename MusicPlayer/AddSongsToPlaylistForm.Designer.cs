using System.Windows.Forms;

namespace MusicPlayer
{
    partial class AddSongsToPlaylistForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button doneButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.doneButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.doneButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 500);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(10, 10);
            this.doneButton.Margin = new System.Windows.Forms.Padding(10);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(100, 30);
            this.doneButton.TabIndex = 0;
            this.doneButton.Text = "Create";
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // AddSongsToPlaylistForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AddSongsToPlaylistForm";
            this.Text = "Adaugă melodii în playlist";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
