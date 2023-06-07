using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static LibraryManagement.AddPatron;

namespace LibraryManagement
{
    public partial class LoanBook : Form
    {
        private List<Book> books;
        private List<Patron> patrons;

        public LoanBook()
        {
            InitializeComponent();
            books = new List<Book>();
            patrons = new List<Patron>();
        }

        private void LoanBook_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadPatrons();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoanBook_Load(this, EventArgs.Empty);
        }

        private void LoadBooks()
        {
            books.Clear();

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT * FROM Books WHERE BookID NOT IN (SELECT BookID FROM BookLoans)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int bookID = (int)reader["BookID"];
                        string title = (string)reader["Title"];
                        string author = (string)reader["Author"];
                        string genre = (string)reader["Genre"];

                        Book book = new Book(bookID, title, author, genre);
                        books.Add(book);
                    }

                    reader.Close();
                }
            }

            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = books;
            listBoxBooks.DisplayMember = "DisplayInfo";
        }

        private void LoadPatrons()
        {
            patrons.Clear();

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT * FROM Patrons WHERE PatronID NOT IN (SELECT PatronID FROM BookLoans)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int patronID = (int)reader["PatronID"];
                        string name = (string)reader["Name"];
                        string surname = (string)reader["Surname"];
                        string email = (string)reader["Email"];

                        Patron patron = new Patron(patronID, name, surname, email);
                        patrons.Add(patron);
                    }

                    reader.Close();
                }
            }

            listBoxPatrons.DataSource = null;
            listBoxPatrons.DataSource = patrons;
            listBoxPatrons.DisplayMember = "DisplayInfo";
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchBooks.Text.Trim().ToLower();

            List<Book> searchResults = books
                .Where(b => b.Title.ToLower().Contains(searchTerm) || b.Author.ToLower().Contains(searchTerm))
                .ToList();

            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = searchResults;
            listBoxBooks.DisplayMember = "DisplayInfo";
        }

        private void btnSearchPatrons_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchPatrons.Text.Trim().ToLower();

            List<Patron> searchResults = patrons
                .Where(p => p.Name.ToLower().Contains(searchTerm) || p.Surname.ToLower().Contains(searchTerm) || p.Email.ToLower().Contains(searchTerm))
                .ToList();

            listBoxPatrons.DataSource = null;
            listBoxPatrons.DataSource = searchResults;
            listBoxPatrons.DisplayMember = "DisplayInfo";
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Book selectedBook = (Book)listBoxBooks.SelectedItem;
            Patron selectedPatron = (Patron)listBoxPatrons.SelectedItem;

            DateTime loanStartDate = DateTime.Now;

            if (DateTime.TryParse(txtLoan.Text, out DateTime loanEndDate))
            {
                BookLoan loan = new BookLoan(selectedBook.BookID, selectedPatron.PatronID, loanStartDate, loanEndDate);

                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
                {
                    connection.Open();

                    string query = "INSERT INTO dbo.BookLoans (BookID, PatronID, LoanDate, ReturnDate) " +
                      "VALUES (@BookID, @PatronID, @LoanDate, @ReturnDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", loan.BookID);
                        command.Parameters.AddWithValue("@PatronID", loan.PatronID);
                        command.Parameters.AddWithValue("@LoanDate", loan.LoanDate);
                        command.Parameters.AddWithValue("@ReturnDate", loan.ReturnDate);

                        command.ExecuteNonQuery();
                    }
                }

                books.Remove(selectedBook);
                patrons.Remove(selectedPatron);

                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = books;
                listBoxBooks.DisplayMember = "DisplayInfo";

                listBoxPatrons.DataSource = null;
                listBoxPatrons.DataSource = patrons;
                listBoxPatrons.DisplayMember = "DisplayInfo";

                MessageBox.Show("Book loaned successfully!");

                listBoxBooks.ClearSelected();
                listBoxPatrons.ClearSelected();
                txtLoan.Clear();
            }
            else
            {
                MessageBox.Show("Invalid loan end date. Please enter a valid date.");
            }
        }

        public class BookLoan
        {
            public int BookID { get; set; }
            public int PatronID { get; set; }
            public DateTime LoanDate { get; set; }
            public DateTime ReturnDate { get; set; }

            public BookLoan(int bookID, int patronID, DateTime loanDate, DateTime returnDate)
            {
                BookID = bookID;
                PatronID = patronID;
                LoanDate = loanDate;
                ReturnDate = returnDate;
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
