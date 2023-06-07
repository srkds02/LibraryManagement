using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace LibraryManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            // Hash the entered password
            string hashedPassword = HashPassword(password);

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Login = @Login AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", hashedPassword);

                    int userCount = (int)command.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MessageBox.Show("Login successful!");
                        txtLogin.Text = "";
                        txtPassword.Text = "";
                        this.Hide();
                        MainMenu form = new MainMenu();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login credentials. Please try again.");
                    }
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


        private void LoginForm_Load(object? sender, EventArgs e)
        {
            checkBoxShowPassword.Checked = false;
            txtPassword.PasswordChar = '•';
        }

        private void labelRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm form = new RegistrationForm();
            form.Show();
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '•';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}