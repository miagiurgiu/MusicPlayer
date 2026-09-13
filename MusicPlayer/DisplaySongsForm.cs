/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class DisplaySongsForm : Form
    {
        private Service service;
        private Form mainForm;

        public DisplaySongsForm(Service service, Form mainForm)
        {
            this.mainForm = mainForm;
            this.service = service;
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(168, 225, 222);
            displaySongs();
        }

        private void displaySongs()
        {
            Song[] songs = service.getAllSongs();
            int songCount = service.getAllSongsCount();

            for (int i = 0; i < songCount; i++)
            {
                //if (songs[i] == null) continue; // prevenim exceptii NullReference

                Button button = new System.Windows.Forms.Button();
                button.Text = songs[i].Title;
                button.Tag = songs[i].IdSong;
                button.Font = new Font("Candara", 12);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.Width = 250;
                button.Height = TextRenderer.MeasureText(button.Text, button.Font).Height + 20;
                button.Click += new EventHandler(PlaySong);

                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void PlaySong(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                int songId = (int)clickedButton.Tag;
                service.playSelectedSong(songId);
                MessageBox.Show("Melodia a fost pornită.");
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Nu face nimic momentan
        }

        private void DisplaySongsForm_Load(object sender, EventArgs e)
        {
            // Nu face nimic momentan
        }
    }

}
*/
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class DisplaySongsForm : Form
    {
        private Service service;
        private Form1 mainForm;

        public DisplaySongsForm(Service service, Form1 mainForm)
        {
            this.mainForm = mainForm;
            this.service = service;
            InitializeComponent();
            //this.Resize += DisplaySongsForm_Resize;
            panel1.BackColor = Color.FromArgb(168, 225, 222);
            this.Activated += (s, e) => RefreshSongs();
            flowLayoutPanel1.SizeChanged += (s, e) =>
            {
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is Button button)
                        button.Width = Math.Max(200, flowLayoutPanel1.ClientSize.Width - 40);
                }
            };
            displaySongs();
        }

        public void RefreshSongs()
        {
            displaySongs();
        }
        private void displaySongs()
        {
            flowLayoutPanel1.Controls.Clear();
            Song[] songs = service.getAllSongs();
            int songCount = service.getAllSongsCount();

            for (int i = 0; i < songCount; i++)
            {
                Button button = new Button();
                button.Text = songs[i].Title;
                button.Tag = songs[i].IdSong;
                button.Font = new Font("Candara", 12F);
                button.ForeColor = Color.FromArgb(20, 75, 78);

                button.BackColor = Color.FromArgb(225, 245, 243);

                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.FromArgb(80, 180, 178);
                button.FlatAppearance.BorderSize = 1;

                button.Width = Math.Max(200, flowLayoutPanel1.ClientSize.Width - 40);
                button.Height = 48;
                button.Margin = new Padding(8, 6, 8, 6);

                button.BackgroundImage = CreateButtonGradient(button.Width, button.Height);
                button.BackgroundImageLayout = ImageLayout.Stretch;
                //button.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                //button.Click += (sender, e) => mainForm.PlaySong((Song)((Button)sender).Tag);
                button.Click += (sender, e) =>
                {
                    Button b = (Button)sender;
                    int songId = (int)b.Tag;

                    Song[] allSongs = service.getAllSongs();

                    service.setPlayingSongs(allSongs);
                    service.playSongFromCurrentList(songId);

                    mainForm.playCurrentSong();

                    Song selectedSong = allSongs.FirstOrDefault(s => s.IdSong == songId);
                    if (selectedSong != null)
                    {
                        DisplaySongDetails detailsForm =
                            new DisplaySongDetails(selectedSong, service);

                        detailsForm.Show();
                    }
                };
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private Image CreateButtonGradient(int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bmp))
            using (System.Drawing.Drawing2D.LinearGradientBrush brush =
                new System.Drawing.Drawing2D.LinearGradientBrush(
                    new Rectangle(0, 0, width, height),
                    Color.FromArgb(225, 245, 243),
                    Color.FromArgb(250, 253, 253),
                    System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
            {
                g.FillRectangle(brush, 0, 0, width, height);
            }

            return bmp;
        }

        //private void DisplaySongsForm_Resize(object sender, EventArgs e)
        //{ 
        //    foreach (Control control in flowLayoutPanel1.Controls)
        //    {
        //        if (control is Button button)
        //        {
        //            int newWidth = flowLayoutPanel1.ClientSize.Width - 40;

        //            if (newWidth > 100)
        //            {
        //                button.Width = newWidth;

        //                if (button.BackgroundImage != null)
        //                    button.BackgroundImage.Dispose();

        //                button.BackgroundImage =
        //                    CreateButtonGradient(button.Width, button.Height);
        //            }
        //        }
        //    }
        //}

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Nu face nimic momentan
        }

        private void DisplaySongsForm_Load(object sender, EventArgs e)
        {
            // Nu face nimic momentan
        }
    }
}
