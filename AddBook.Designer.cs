namespace LibraryManagement
{
    partial class AddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            listBoxBooks = new ListBox();
            bookBindingSource = new BindingSource(components);
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnMainMenu = new Button();
            btnBookManagement = new Button();
            txtGenre = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            resources.ApplyResources(listBoxBooks, "listBoxBooks");
            listBoxBooks.Name = "listBoxBooks";
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.Name = "btnAdd";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Name = "label3";
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.Transparent;
            resources.ApplyResources(btnMainMenu, "btnMainMenu");
            btnMainMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnBookManagement
            // 
            btnBookManagement.BackColor = Color.Transparent;
            resources.ApplyResources(btnBookManagement, "btnBookManagement");
            btnBookManagement.ForeColor = SystemColors.ButtonHighlight;
            btnBookManagement.Name = "btnBookManagement";
            btnBookManagement.UseVisualStyleBackColor = false;
            btnBookManagement.Click += btnBookManagement_Click;
            // 
            // txtGenre
            // 
            resources.ApplyResources(txtGenre, "txtGenre");
            txtGenre.Name = "txtGenre";
            // 
            // txtTitle
            // 
            resources.ApplyResources(txtTitle, "txtTitle");
            txtTitle.Name = "txtTitle";
            // 
            // txtAuthor
            // 
            resources.ApplyResources(txtAuthor, "txtAuthor");
            txtAuthor.Name = "txtAuthor";
            // 
            // AddBook
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBookManagement);
            Controls.Add(btnMainMenu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(listBoxBooks);
            Controls.Add(txtGenre);
            Controls.Add(txtTitle);
            Controls.Add(txtAuthor);
            Name = "AddBook";
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBoxBooks;
        private Button btnAdd;
        private BindingSource bookBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnMainMenu;
        private Button btnBookManagement;
        private TextBox txtGenre;
        private TextBox txtTitle;
        private TextBox txtAuthor;
    }
}