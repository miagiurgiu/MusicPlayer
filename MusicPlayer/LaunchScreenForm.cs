using System;
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
    public partial class LaunchScreenForm : Form
    {
        Service service;
        string connectionString;
        public LaunchScreenForm(Service service, string connectionString)
        {
            this.service = service;
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void LaunchScreenForm_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Form1 mainForm = new Form1(service);
            //mainForm.Show();
            //this.Hide();
            //mainForm.FormClosed += (s, args) => this.Close(); //daca inchid formul de tip playlist (adica asta nou) sa mi se afiseze anteriorul
            LoginForm loginForm = new LoginForm(service, connectionString);
            loginForm.Show();
            this.Hide();
            loginForm.FormClosed += (s, args) => this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
