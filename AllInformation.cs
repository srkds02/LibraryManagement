using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AllInformation : Form
    {
        private string connectionString = @"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;";

        public AllInformation()
        {
            InitializeComponent();
        }

        private void LibraryInformation_Load(object sender, EventArgs e)
        {
            LoadBooksCount();
            LoadPatronsCount();
            LoadLoanedBooksCount();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LibraryInformation_Load(this, EventArgs.Empty);
        }

        private void LoadBooksCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM dbo.Books";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int booksCount = (int)command.ExecuteScalar();
                    labelBooks.Text = booksCount.ToString();
                }
            }
        }

        private void LoadPatronsCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM dbo.Patrons";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int patronsCount = (int)command.ExecuteScalar();
                    labelPatrons.Text = patronsCount.ToString();
                }
            }
        }

        private void LoadLoanedBooksCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM dbo.BookLoans";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int loanedBooksCount = (int)command.ExecuteScalar();
                    labelLoanedBooks.Text = loanedBooksCount.ToString();
                }
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu form = new MainMenu();
            form.Show();
        }
    }
}
