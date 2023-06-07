namespace LibraryManagement
{
    partial class EditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBook));
            listBoxBooks = new ListBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            txtGenre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnEdit = new Button();
            btnMainMenu = new Button();
            btnBookManagement = new Button();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(400, 35);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(376, 334);
            listBoxBooks.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(160, 54);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(275, 54);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(30, 30);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(29, 57);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter Title or Author";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(157, 111);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 4;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(157, 152);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 5;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(157, 191);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(100, 23);
            txtGenre.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(89, 114);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 7;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(89, 155);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 8;
            label3.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(89, 194);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "Genre";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BackgroundImage = (Image)resources.GetObject("btnEdit.BackgroundImage");
            btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(324, 54);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(30, 30);
            btnEdit.TabIndex = 10;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.Transparent;
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMainMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMainMenu.Location = new Point(620, 407);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(140, 31);
            btnMainMenu.TabIndex = 11;
            btnMainMenu.Text = "Exit to Main Menu";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnBookManagement
            // 
            btnBookManagement.BackColor = Color.Transparent;
            btnBookManagement.FlatStyle = FlatStyle.Flat;
            btnBookManagement.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBookManagement.ForeColor = SystemColors.ButtonHighlight;
            btnBookManagement.Location = new Point(400, 407);
            btnBookManagement.Name = "btnBookManagement";
            btnBookManagement.Size = new Size(176, 31);
            btnBookManagement.TabIndex = 12;
            btnBookManagement.Text = "Exit to Book Management";
            btnBookManagement.UseVisualStyleBackColor = false;
            btnBookManagement.Click += btnBookManagement_Click;
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBookManagement);
            Controls.Add(btnMainMenu);
            Controls.Add(btnEdit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtGenre);
            Controls.Add(txtTitle);
            Controls.Add(txtAuthor);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(listBoxBooks);
            Name = "EditBook";
            Text = "EditBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBooks;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label1;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private TextBox txtGenre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnEdit;
        private Button btnMainMenu;
        private Button btnBookManagement;
    }
}