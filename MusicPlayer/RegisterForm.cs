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
    public partial class RegisterForm : Form
    {
        private string connectionString;
        public RegisterForm(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            UserRepository userRepository =
                new UserRepository(connectionString);

            userRepository.AddUser(username, email, password);

            MessageBox.Show("Contul a fost creat cu succes!");
            this.Close();

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
