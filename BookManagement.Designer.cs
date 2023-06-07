namespace LibraryManagement
{
    partial class BookManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManagement));
            label1 = new Label();
            btnAddBook = new Button();
            btnEditBook = new Button();
            btnDeleteBook = new Button();
            btnMainMenu = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(40, 45);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 0;
            label1.Text = "Book Management";
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.Transparent;
            btnAddBook.BackgroundImage = (Image)resources.GetObject("btnAddBook.BackgroundImage");
            btnAddBook.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddBook.ForeColor = Color.Transparent;
            btnAddBook.Location = new Point(64, 89);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(50, 50);
            btnAddBook.TabIndex = 1;
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.BackColor = Color.Transparent;
            btnEditBook.BackgroundImage = (Image)resources.GetObject("btnEditBook.BackgroundImage");
            btnEditBook.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditBook.FlatStyle = FlatStyle.Flat;
            btnEditBook.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditBook.ForeColor = Color.Transparent;
            btnEditBook.Location = new Point(64, 158);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(50, 50);
            btnEditBook.TabIndex = 2;
            btnEditBook.UseVisualStyleBackColor = false;
            btnEditBook.Click += btnEditBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.Transparent;
            btnDeleteBook.BackgroundImage = (Image)resources.GetObject("btnDeleteBook.BackgroundImage");
            btnDeleteBook.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeleteBook.FlatStyle = FlatStyle.Flat;
            btnDeleteBook.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteBook.ForeColor = Color.Transparent;
            btnDeleteBook.Location = new Point(64, 228);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(55, 50);
            btnDeleteBook.TabIndex = 3;
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.Transparent;
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMainMenu.ForeColor = Color.Transparent;
            btnMainMenu.Location = new Point(40, 404);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(144, 34);
            btnMainMenu.TabIndex = 4;
            btnMainMenu.Text = "Back to Main Menu";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Transparent;
            btnExit.Location = new Point(679, 404);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // BookManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnMainMenu);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnEditBook);
            Controls.Add(btnAddBook);
            Controls.Add(label1);
            Name = "BookManagement";
            Text = "BookManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddBook;
        private Button btnEditBook;
        private Button btnDeleteBook;
        private Button btnMainMenu;
        private Button btnExit;
    }
}