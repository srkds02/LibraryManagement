using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using static LibraryManagement.LoanBook;

namespace LibraryManagement
{
    public partial class ReturnBook : Form
    {
        private List<BookLoan> loanedBooks;
        private string connectionString = @"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;";

        public ReturnBook()
        {
            InitializeComponent();
            loanedBooks = new List<BookLoan>();
        }
        private void ReturnBook_Load(object sender, EventArgs e)
        {
            LoadLoanedBooks();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ReturnBook_Load(this, EventArgs.Empty);
        }
        private void CheckReturnDateNotifications()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT bl.LoanID, b.Title, p.Name, p.Surname, p.Email, bl.ReturnDate " +
                               "FROM dbo.BookLoans bl " +
                               "JOIN dbo.Books b ON bl.BookID = b.BookID " +
                               "JOIN dbo.Patrons p ON bl.PatronID = p.PatronID " +
                               "WHERE bl.Notified = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int loanId = (int)reader["LoanID"];
                        string bookTitle = (string)reader["Title"];
                        string patronName = (string)reader["Name"];
                        string patronSurname = (string)reader["Surname"];
                        string fullName = $"{patronName} {patronSurname}";
                        string email = (string)reader["Email"];
                        DateTime returnDate = (DateTime)reader["ReturnDate"];
                        DateTime notificationDate = returnDate.AddDays(-2);
                        SendEmailNotification(email, fullName, bookTitle, returnDate);
                        UpdateNotifiedFlag(loanId);
                    }

                    reader.Close();
                }
            }
        }
        private void UpdateNotifiedFlag(int loanId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE dbo.BookLoans SET Notified = 1 WHERE LoanID = @LoanID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LoanID", loanId);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void LoadLoanedBooks()
        {
            listBoxLoans.Items.Clear();

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT b.Title, p.Name, p.Surname, bl.ReturnDate, p.Email FROM dbo.BookLoans bl " +
                               "JOIN dbo.Books b ON bl.BookID = b.BookID " +
                               "JOIN dbo.Patrons p ON bl.PatronID = p.PatronID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string bookTitle = (string)reader["Title"];
                        string patronName = (string)reader["Name"];
                        string patronSurname = (string)reader["Surname"];
                        string fullName = $"{patronName} {patronSurname}";
                        DateTime returnDate = (DateTime)reader["ReturnDate"];
                        string loanInfo = $"Book: {bookTitle}, Patron: {fullName}, Return Date: {returnDate.ToShortDateString()}";

                        listBoxLoans.Items.Add(loanInfo);
                    }

                    reader.Close();
                }
            }
        }
        private void SendEmailNotification(string email, string patronName, string bookTitle, DateTime returnDate)
        {
            string subject = "Library Book Return Reminder";
            string body = $"Dear {patronName},\n\nThis is a friendly reminder to return the book '{bookTitle}' " +
                $"to the library by {returnDate.ToShortDateString()}.\n\nThank you for your cooperation.";

            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "serkrasuckis@gmail.com";
            string smtpPassword = "yibciocivqmsjquk";

            SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(smtpUsername);
            mailMessage.To.Add(email);
            mailMessage.Subject = subject;
            mailMessage.Body = body;

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email notification: " + ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            listBoxLoans.Items.Clear();

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT b.Title, p.Name, p.Surname FROM dbo.BookLoans bl " +
                               "JOIN dbo.Books b ON bl.BookID = b.BookID " +
                               "JOIN dbo.Patrons p ON bl.PatronID = p.PatronID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string bookTitle = (string)reader["Title"];
                        string patronName = (string)reader["Name"];
                        string patronSurname = (string)reader["Surname"];
                        string fullName = $"{patronName} {patronSurname}";
                        string loanInfo = $"Book: {bookTitle}, Patron: {fullName}";

                        if (loanInfo.ToLower().Contains(searchText))
                        {
                            listBoxLoans.Items.Add(loanInfo);
                        }
                    }

                    reader.Close();
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (listBoxLoans.SelectedIndex >= 0)
            {
                string loanInfo = listBoxLoans.SelectedItem.ToString();
                string bookTitle = loanInfo.Substring(loanInfo.IndexOf("Book: ") + 6, loanInfo.IndexOf(", Patron:") - loanInfo.IndexOf("Book: ") - 6);
                string patronName = loanInfo.Substring(loanInfo.IndexOf("Patron: ") + 8);

                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
                {
                    connection.Open();
                    string query = "DELETE FROM dbo.BookLoans WHERE BookID IN (SELECT BookID FROM dbo.Books WHERE Title = @Title) AND PatronID IN (SELECT PatronID FROM dbo.Patrons WHERE CONCAT(Name, ' ', Surname) = @FullName)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", bookTitle);
                        command.Parameters.AddWithValue("@FullName", patronName);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Loan returned successfully!");
                            LoadLoanedBooks();
                        }
                        else
                        {
                            MessageBox.Show("Failed to return the loan. Please try again.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a loan from the list.");
            }
        }
        private void btnPatronManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            PatronManagement form = new PatronManagement();
            form.Show();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu form = new MainMenu();
            form.Show();
        }
    }
}
