using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace LibraryManagement
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.Load += RegistrationForm_Load;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.");
                return;
            }

            if (IsEmailExists(email))
            {
                MessageBox.Show("Email already registered. Please use a different email.");
                return;
            }

            if (IsUsernameExists(username))
            {
                MessageBox.Show("Username already taken. Please choose a different username.");
                return;
            }

            if (RegisterUser(email, username, password))
            {
                MessageBox.Show("Registration successful!");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsEmailExists(string email)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        private bool IsUsernameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Login = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        private bool RegisterUser(string email, string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
            {
                connection.Open();

                string query = "INSERT INTO Users (Email, Login, Password) VALUES (@Email, @Username, @Password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Username", username);

                    string hashedPassword = HashPassword(password);
                    command.Parameters.AddWithValue("@Password", hashedPassword);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '•';
        }
        private void RegistrationForm_Load(object? sender, EventArgs e)
        {
            checkBoxShowPassword.Checked = false;
            txtPassword.PasswordChar = '•';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
