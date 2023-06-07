using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static LibraryManagement.AddPatron;

namespace LibraryManagement
{
    public partial class DeletePatron : Form
    {
        private List<Patron> patrons;

        public DeletePatron()
        {
            InitializeComponent();
            patrons = new List<Patron>();
        }

        private void DeletePatron_Load(object sender, EventArgs e)
        {
            LoadPatronList();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DeletePatron_Load(this, EventArgs.Empty);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();
            List<Patron> searchResults = patrons
                .Where(p => p.Name.ToLower().Contains(searchTerm) || p.Surname.ToLower().Contains(searchTerm) || p.Email.ToLower().Contains(searchTerm))
                .ToList();

            listBoxPatrons.DataSource = null;
            listBoxPatrons.DataSource = searchResults;
            listBoxPatrons.DisplayMember = null;
            listBoxPatrons.ValueMember = null;
            listBoxPatrons.DisplayMember = "ToString";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxPatrons.SelectedItem == null)
            {
                MessageBox.Show("Please select a patron to delete.");
                return;
            }

            Patron selectedPatron = (Patron)listBoxPatrons.SelectedItem;

            string message = $"Are you sure you want to delete the patron:\n\n{selectedPatron.Name} {selectedPatron.Surname} ({selectedPatron.Email})";
            DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
                {
                    connection.Open();
                    string deleteBookLoansQuery = "DELETE FROM BookLoans WHERE PatronID = @PatronID";

                    using (SqlCommand deleteBookLoansCommand = new SqlCommand(deleteBookLoansQuery, connection))
                    {
                        deleteBookLoansCommand.Parameters.AddWithValue("@PatronID", selectedPatron.PatronID);
                        deleteBookLoansCommand.ExecuteNonQuery();
                    }
                }

                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
                {
                    connection.Open();
                    string deletePatronQuery = "DELETE FROM Patrons WHERE PatronID = @PatronID";

                    using (SqlCommand deletePatronCommand = new SqlCommand(deletePatronQuery, connection))
                    {
                        deletePatronCommand.Parameters.AddWithValue("@PatronID", selectedPatron.PatronID);
                        deletePatronCommand.ExecuteNonQuery();
                    }
                }

                patrons.Remove(selectedPatron);
                listBoxPatrons.DataSource = null;
                listBoxPatrons.DataSource = patrons;
                listBoxPatrons.DisplayMember = "FullName";
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
