using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static LibraryManagement.AddBook;

namespace LibraryManagement
{
    public partial class DeleteBook : Form
    {
        private List<Book> books;
        private List<Book> searchResults;

        public DeleteBook()
        {
            InitializeComponent();
            books = new List<Book>();
            searchResults = new List<Book>();
        }
        private void DeleteBook_Load(object sender, EventArgs e)
        {
            LoadBookList();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DeleteBook_Load(this, EventArgs.Empty);
        }

        private void LoadBookList()
        {
            books.Clear();
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT * FROM Books";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int bookID = (int)reader["BookID"];
                        string author = (string)reader["Author"];
                        string title = (string)reader["Title"];
                        string genre = (string)reader["Genre"];

                        Book book = new Book(bookID, author, title, genre);
                        books.Add(book);
                    }

                    reader.Close();
                }
            }

            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = books;
            listBoxBooks.DisplayMember = null;
            listBoxBooks.ValueMember = null;
            listBoxBooks.DisplayMember = "ToString";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                searchResults.Clear();

                foreach (Book book in books)
                {
                    if (book.Title.ToLower().Contains(searchText.ToLower()) || book.Author.ToLower().Contains(searchText.ToLower()))
                    {
                        searchResults.Add(book);
                    }
                }

                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = searchResults;
                listBoxBooks.DisplayMember = "ToString";
            }
            else
            {
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = books;
                listBoxBooks.DisplayMember = "ToString";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem != null)
            {
                Book selectedBook = (Book)listBoxBooks.SelectedItem;

                string confirmationMessage = $"Are you sure you want to delete book {selectedBook.Title} by {selectedBook.Author} ({selectedBook.Genre}) from the database?";
                DialogResult result = MessageBox.Show(confirmationMessage, "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
                    {
                        connection.Open();
                        string query = "DELETE FROM Books WHERE BookID = @BookID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@BookID", selectedBook.BookID);
                            command.ExecuteNonQuery();
                        }
                    }

                    LoadBookList();

                    MessageBox.Show("Book deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            BookManagement bookManagement = new BookManagement();
            bookManagement.Show();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
