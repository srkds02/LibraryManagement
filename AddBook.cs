using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AddBook : Form
    {
        private List<Book> books;

        public AddBook()
        {
            InitializeComponent();
            books = new List<Book>();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            LoadBookList();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AddBook_Load(this, EventArgs.Empty);
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string author = txtAuthor.Text;
            string title = txtTitle.Text;
            string genre = txtGenre.Text;

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
            {
                connection.Open();
                string query = "INSERT INTO Books (Author, Title, Genre) VALUES (@Author, @Title, @Genre)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Author", author);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Genre", genre);

                    command.ExecuteNonQuery();
                }
            }
            LoadBookList();
            txtAuthor.Clear();
            txtTitle.Clear();
            txtGenre.Clear();
        }
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu form = new MainMenu();
            form.Show();
        }
        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            BookManagement form = new BookManagement();
            form.Show();
        }
    }
    public class Book
    {
        public int BookID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public Book(int bookID, string author, string title, string genre)
        {
            BookID = bookID;
            Author = author;
            Title = title;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"{Title} by {Author} ({Genre})";
        }
    }
}
