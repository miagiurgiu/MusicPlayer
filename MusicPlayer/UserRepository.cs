using System;
using System.Data.SqlClient;

namespace MusicPlayer
{
    internal class UserRepository
    {
        private string connectionString;

        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddUser(string username, string email, string password)
        {
            string hash = PasswordHasher.CreateHash(password, out string salt);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Users
                                (name, mail, passwordHash, passwordSalt)
                                VALUES (@name, @mail, @hash, @salt)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", username);
                    cmd.Parameters.AddWithValue("@mail", email);
                    cmd.Parameters.AddWithValue("@hash", hash);
                    cmd.Parameters.AddWithValue("@salt", salt);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool Login(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT passwordHash, passwordSalt
                                 FROM Users
                                 WHERE name = @name";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hash = reader["passwordHash"].ToString();
                            string salt = reader["passwordSalt"].ToString();

                            return PasswordHasher.VerifyPassword(
                                password, hash, salt);
                        }
                    }
                }
            }

            return false;
        }
    }
}