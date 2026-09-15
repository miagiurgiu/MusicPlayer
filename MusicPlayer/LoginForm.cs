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
    public partial class LoginForm : Form
    {
        private Service service;
        private string connectionString;
        public LoginForm(Service service, string connectionString)
        {
            InitializeComponent();
            this.service = service;
            this.connectionString = connectionString;
        }

        private void passwordTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            UserRepository userRepository =
                new UserRepository(connectionString);

            if (userRepository.Login(username, password))
            {
                this.Hide();

                Form1 mainForm = new Form1(service);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Username sau parolă incorectă.");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(connectionString);
            registerForm.Show();
        }
    }
}
