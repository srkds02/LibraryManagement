using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AddPatron : Form
    {
        private List<Patron> patrons;

        public AddPatron()
        {
            InitializeComponent();
            patrons = new List<Patron>();
        }
        private void AddPatron_Load(object sender, EventArgs e)
        {
            LoadPatronList();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AddPatron_Load(this, EventArgs.Empty);
        }

        private void LoadPatronList()
        {
            patrons.Clear();
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT * FROM Patrons";

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
            listBoxPatrons.DisplayMember = null;
            listBoxPatrons.ValueMember = null;
            listBoxPatrons.DisplayMember = "ToString";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter all the required information.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
            {
                connection.Open();
                string query = "INSERT INTO Patrons (Name, Surname, Email) VALUES (@Name, @Surname, @Email)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Email", email);

                    command.ExecuteNonQuery();
                }
            }

            txtName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();

            LoadPatronList();
        }
        public class Patron
        {
            public int PatronID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }

            public Patron(int patronID, string name, string surname, string email)
            {
                PatronID = patronID;
                Name = name;
                Surname = surname;
                Email = email;
            }
            public string FullName
            {
                get { return $"{Name} {Surname}"; }
            }

            public override string ToString()
            {
                return $"{Name} {Surname} ({Email})";
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
