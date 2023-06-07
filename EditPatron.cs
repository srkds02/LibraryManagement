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
using System.Xml.Linq;
using static LibraryManagement.AddPatron;

namespace LibraryManagement
{
    public partial class EditPatron : Form
    {
        private List<Patron> patrons;

        public EditPatron()
        {
            InitializeComponent();
            patrons = new List<Patron>();
            listBoxPatrons.SelectedIndexChanged += listBoxPatrons_SelectedIndexChanged;
        }
        private void EditPatron_Load(object sender, EventArgs e)
        {
            LoadPatronList();
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            EditPatron_Load(this, EventArgs.Empty);
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
            string searchQuery = txtSearch.Text.Trim();

            List<Patron> searchResults = patrons.Where(p => p.Name.Contains(searchQuery) ||
                                                            p.Surname.Contains(searchQuery) ||
                                                            p.Email.Contains(searchQuery)).ToList();

            listBoxPatrons.DataSource = null;
            listBoxPatrons.DataSource = searchResults;
            listBoxPatrons.DisplayMember = null;
            listBoxPatrons.ValueMember = null;
            listBoxPatrons.DisplayMember = "ToString";
        }
        private void listBoxPatrons_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listBoxPatrons.SelectedItem != null)
            {
                Patron selectedPatron = (Patron)listBoxPatrons.SelectedItem;

                txtName.Text = selectedPatron.Name;
                txtSurname.Text = selectedPatron.Surname;
                txtEmail.Text = selectedPatron.Email;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxPatrons.SelectedItem != null)
            {
                Patron selectedPatron = (Patron)listBoxPatrons.SelectedItem;

                string newName = txtName.Text.Trim();
                string newSurname = txtSurname.Text.Trim();
                string newEmail = txtEmail.Text.Trim();

                if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newSurname) || string.IsNullOrEmpty(newEmail))
                {
                    MessageBox.Show("Please enter all the required information.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N9SMPDC\SQLEXPRESS;Initial Catalog=cwlibrary;Integrated Security=True;"))
                {
                    connection.Open();
                    string query = "UPDATE Patrons SET Name = @NewName, Surname = @NewSurname, Email = @NewEmail WHERE PatronID = @PatronID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewName", newName);
                        command.Parameters.AddWithValue("@NewSurname", newSurname);
                        command.Parameters.AddWithValue("@NewEmail", newEmail);
                        command.Parameters.AddWithValue("@PatronID", selectedPatron.PatronID);

                        command.ExecuteNonQuery();
                    }
                }

                txtName.Clear();
                txtSurname.Clear();
                txtEmail.Clear();

                LoadPatronList();
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
