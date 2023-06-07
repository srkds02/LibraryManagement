namespace LibraryManagement
{
    partial class DeleteBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBook));
            listBoxBooks = new ListBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            btnMainMenu = new Button();
            btnBookManagement = new Button();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(480, 51);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(290, 289);
            listBoxBooks.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(296, 67);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(30, 30);
            btnSearch.TabIndex = 1;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(180, 67);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(46, 70);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter Title of Author:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(342, 67);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(35, 30);
            btnDelete.TabIndex = 4;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.Transparent;
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMainMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMainMenu.Location = new Point(632, 404);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(138, 34);
            btnMainMenu.TabIndex = 5;
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
            btnBookManagement.Location = new Point(416, 404);
            btnBookManagement.Name = "btnBookManagement";
            btnBookManagement.Size = new Size(174, 34);
            btnBookManagement.TabIndex = 6;
            btnBookManagement.Text = "Exit to Book Management";
            btnBookManagement.UseVisualStyleBackColor = false;
            btnBookManagement.Click += btnBookManagement_Click;
            // 
            // DeleteBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBookManagement);
            Controls.Add(btnMainMenu);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(listBoxBooks);
            Name = "DeleteBook";
            Text = "DeleteBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBooks;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Button btnDelete;
        private Button btnMainMenu;
        private Button btnBookManagement;
    }
}