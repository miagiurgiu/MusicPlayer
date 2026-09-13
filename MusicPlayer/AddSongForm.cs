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
                string title = songTextBox.Text.Trim();
                if (string.IsNullOrEmpty(title))
                {
                    MessageBox.Show("Enter a song title.");
                    return;
                }

                string artistName = artistTextBox.Text.Trim();
                if (string.IsNullOrEmpty(artistName))
                {
                    MessageBox.Show("Enter an artist.");
                    return;
                }

                // Validate Release Year input
                string yearInput = yearTextBox.Text.Trim();
                if (!int.TryParse(yearInput, out int year) || year < 1000 || year > DateTime.Now.Year)
                {
                    MessageBox.Show($"Please enter a valid 4-digit release year (1000–{DateTime.Now.Year}).");
                    return;
                }

                // Default Genre and Studio to "Unknown" if left empty
                string genre = string.IsNullOrWhiteSpace(genreTextBox.Text) ? "Unknown" : genreTextBox.Text.Trim();
                string studio = string.IsNullOrWhiteSpace(studioTextBox.Text) ? "Unknown" : studioTextBox.Text.Trim();

                string fileName = Path.GetFileName(sourcePath);
                string destinationFolder = Path.Combine(Application.StartupPath, "Media", "Audio");
                Directory.CreateDirectory(destinationFolder);

                string destinationPath = Path.Combine(destinationFolder, fileName);
                File.Copy(sourcePath, destinationPath, true);

                TimeSpan duration = GetWavDuration(sourcePath);
                string durationText = duration.ToString(@"mm\:ss");

                Artist artist = service.getArtistByName(artistName);
                int artistId = (artist != null) ? artist.IdArtist : service.addArtist(artistName);

                Song newSong = new Song(
                    0,
                    title,
                    durationText,
                    yearInput,
                    genre,
                    studio,
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

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}