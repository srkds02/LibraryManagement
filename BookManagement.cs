using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class BookManagement : Form
    {
        public BookManagement()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            this.Close();
            AddBook form = new AddBook();
            form.Show();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            this.Close();
            EditBook form = new EditBook();
            form.Show();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            this.Close();
            DeleteBook form = new DeleteBook();
            form.Show();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu form = new MainMenu();
            form.Show();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
