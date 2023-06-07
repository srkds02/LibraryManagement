using System;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookManagement form = new BookManagement();
            form.Show();
        }

        private void btnPatronManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatronManagement form = new PatronManagement();
            form.Show();
        }

        private void btnAllInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllInformation form = new AllInformation();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
