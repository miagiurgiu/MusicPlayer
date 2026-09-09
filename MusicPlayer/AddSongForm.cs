using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class AddSongForm : Form
    {
        private Service service;
        public AddSongForm(Service service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "WAV files (*.wav)|*.wav";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = dialog.FileName;
            }
        }

        private TimeSpan GetWavDuration(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                reader.ReadChars(4); // RIFF
                reader.ReadInt32();
                reader.ReadChars(4); // WAVE

                int byteRate = 0;
                int dataSize = 0;

                while (fs.Position < fs.Length)
                {
                    string chunkId = new string(reader.ReadChars(4));
                    int chunkSize = reader.ReadInt32();

                    if (chunkId == "fmt ")
                    {
                        reader.ReadInt16(); // audio format
                        reader.ReadInt16(); // channels
                        reader.ReadInt32(); // sample rate
                        byteRate = reader.ReadInt32();

                        fs.Position += chunkSize - 12;
                    }
                    else if (chunkId == "data")
                    {
                        dataSize = chunkSize;
                        break;
                    }
                    else
                    {
                        fs.Position += chunkSize;
                    }
                }

                if (byteRate == 0 || dataSize == 0)
                    return TimeSpan.Zero;

                return TimeSpan.FromSeconds((double)dataSize / byteRate);
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            string sourcePath = pathTextBox.Text.Trim();

            if (!File.Exists(sourcePath))
            {
                MessageBox.Show("Select a valid WAV file.");
                return;
            }

            try
            {
                string fileName = Path.GetFileName(sourcePath);

                string destinationFolder = Path.Combine(
                    Application.StartupPath,
                    "Media",
                    "Audio"
                );

                Directory.CreateDirectory(destinationFolder);

                string destinationPath = Path.Combine(destinationFolder, fileName);

                File.Copy(sourcePath, destinationPath, true);
                TimeSpan duration = GetWavDuration(sourcePath);
                string durationText = duration.ToString(@"mm\:ss");
                string artistName = artistTextBox.Text.Trim();

                Artist artist = service.getArtistByName(artistName);
                int artistId;
                if (artist!= null)
                {
                    artistId = artist.IdArtist;
                }
                else
                {
                    artistId = service.addArtist(artistName);
                }
                string title = songTextBox.Text.Trim();

                if (title == "")
                {
                    MessageBox.Show("Enter a song title.");
                    return;
                }

                if (artistName == "")
                {
                    MessageBox.Show("Enter an artist.");
                    return;
                }
                Song newSong = new Song(
                    0,
                    title,
                    durationText,
                    "2026",
                    "Unknown",
                    "Unknown",
                    "Imported manually",
                    fileName,
                    artistId
                );

                service.addSong(newSong);

                MessageBox.Show("Song added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
