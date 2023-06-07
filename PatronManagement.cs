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
    public partial class PatronManagement : Form
    {
        public PatronManagement()
        {
            InitializeComponent();
        }

        private void btnAddPatron_Click(object sender, EventArgs e)
        {
            this.Close();
            AddPatron form = new AddPatron();
            form.Show();
        }

        private void btnLoanBook_Click(object sender, EventArgs e)
        {
            this.Close();
            LoanBook form = new LoanBook();
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

        private void btnEditPatron_Click(object sender, EventArgs e)
        {
            this.Close();
            EditPatron form = new EditPatron();
            form.Show();
        }

        private void btnDeletePatron_Click(object sender, EventArgs e)
        {
            this.Close();
            DeletePatron form = new DeletePatron();
            form.Show();
        }

        private void btnBookReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            ReturnBook form = new ReturnBook();
            form.Show();
        }
    }
}
