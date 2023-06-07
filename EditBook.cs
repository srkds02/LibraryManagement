using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static LibraryManagement.AddBook;

namespace LibraryManagement
{
    public partial class EditBook : Form
    {
        private List<Book> books;
        private List<Book> searchResults;

        public EditBook()
        {
            InitializeComponent();
            books = new List<Book>();
            searchResults = new List<Book>();
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            LoadBookList();
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            EditBook_Load(this, EventArgs.Empty);
        }

        public void LoadBookList()
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


        private void listBoxBooks_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listBoxBooks.SelectedIndex >= 0)
            {
                Book selectedBook = searchResults.Count > 0 ? searchResults[listBoxBooks.SelectedIndex] : books[listBoxBooks.SelectedIndex];

                txtAuthor.Text = selectedBook.Author;
                txtTitle.Text = selectedBook.Title;
                txtGenre.Text = selectedBook.Genre;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedIndex >= 0)
            {
                Book selectedBook = searchResults.Count > 0 ? searchResults[listBoxBooks.SelectedIndex] : books[listBoxBooks.SelectedIndex];

                selectedBook.Author = txtAuthor.Text;
                selectedBook.Title = txtTitle.Text;
                selectedBook.Genre = txtGenre.Text;

                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
                {
                    connection.Open();
                    string query = "UPDATE Books SET Author = @Author, Title = @Title, Genre = @Genre WHERE BookID = @BookID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Author", selectedBook.Author);
                        command.Parameters.AddWithValue("@Title", selectedBook.Title);
                        command.Parameters.AddWithValue("@Genre", selectedBook.Genre);
                        command.Parameters.AddWithValue("@BookID", selectedBook.BookID);

                        command.ExecuteNonQuery();
                    }
                }

                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = searchResults.Count > 0 ? searchResults : books;
                listBoxBooks.DisplayMember = "ToString";
            }
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            BookManagement form = new BookManagement();
            form.Show();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
