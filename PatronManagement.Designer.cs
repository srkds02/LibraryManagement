namespace LibraryManagement
{
    partial class PatronManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatronManagement));
            label1 = new Label();
            btnAddPatron = new Button();
            btnLoanBook = new Button();
            btnMainMenu = new Button();
            btnExit = new Button();
            btnEditPatron = new Button();
            btnDeletePatron = new Button();
            btnBookReturn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(29, 26);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 0;
            label1.Text = "Patron Management";
            // 
            // btnAddPatron
            // 
            btnAddPatron.BackColor = Color.Transparent;
            btnAddPatron.FlatStyle = FlatStyle.Flat;
            btnAddPatron.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddPatron.ForeColor = SystemColors.ButtonHighlight;
            btnAddPatron.Location = new Point(29, 75);
            btnAddPatron.Name = "btnAddPatron";
            btnAddPatron.Size = new Size(136, 41);
            btnAddPatron.TabIndex = 1;
            btnAddPatron.Text = "Add Patron";
            btnAddPatron.UseVisualStyleBackColor = false;
            btnAddPatron.Click += btnAddPatron_Click;
            // 
            // btnLoanBook
            // 
            btnLoanBook.BackColor = Color.Transparent;
            btnLoanBook.FlatStyle = FlatStyle.Flat;
            btnLoanBook.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoanBook.ForeColor = SystemColors.ButtonHighlight;
            btnLoanBook.Location = new Point(29, 213);
            btnLoanBook.Name = "btnLoanBook";
            btnLoanBook.Size = new Size(136, 38);
            btnLoanBook.TabIndex = 2;
            btnLoanBook.Text = "Book Loaning";
            btnLoanBook.UseVisualStyleBackColor = false;
            btnLoanBook.Click += btnLoanBook_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.Transparent;
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMainMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMainMenu.Location = new Point(45, 405);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(131, 33);
            btnMainMenu.TabIndex = 3;
            btnMainMenu.Text = "Exit to Main Menu";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(690, 405);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 33);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnEditPatron
            // 
            btnEditPatron.BackColor = Color.Transparent;
            btnEditPatron.FlatStyle = FlatStyle.Flat;
            btnEditPatron.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditPatron.ForeColor = SystemColors.ButtonHighlight;
            btnEditPatron.Location = new Point(29, 122);
            btnEditPatron.Name = "btnEditPatron";
            btnEditPatron.Size = new Size(136, 40);
            btnEditPatron.TabIndex = 5;
            btnEditPatron.Text = "Edit Patron";
            btnEditPatron.UseVisualStyleBackColor = false;
            btnEditPatron.Click += btnEditPatron_Click;
            // 
            // btnDeletePatron
            // 
            btnDeletePatron.BackColor = Color.Transparent;
            btnDeletePatron.FlatStyle = FlatStyle.Flat;
            btnDeletePatron.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeletePatron.ForeColor = SystemColors.ButtonHighlight;
            btnDeletePatron.Location = new Point(29, 168);
            btnDeletePatron.Name = "btnDeletePatron";
            btnDeletePatron.Size = new Size(136, 39);
            btnDeletePatron.TabIndex = 6;
            btnDeletePatron.Text = "Delete Patron";
            btnDeletePatron.UseVisualStyleBackColor = false;
            btnDeletePatron.Click += btnDeletePatron_Click;
            // 
            // btnBookReturn
            // 
            btnBookReturn.BackColor = Color.Transparent;
            btnBookReturn.FlatStyle = FlatStyle.Flat;
            btnBookReturn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBookReturn.ForeColor = SystemColors.ButtonHighlight;
            btnBookReturn.Location = new Point(29, 257);
            btnBookReturn.Name = "btnBookReturn";
            btnBookReturn.Size = new Size(136, 38);
            btnBookReturn.TabIndex = 7;
            btnBookReturn.Text = "Book Return";
            btnBookReturn.UseVisualStyleBackColor = false;
            btnBookReturn.Click += btnBookReturn_Click;
            // 
            // PatronManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBookReturn);
            Controls.Add(btnDeletePatron);
            Controls.Add(btnEditPatron);
            Controls.Add(btnExit);
            Controls.Add(btnMainMenu);
            Controls.Add(btnLoanBook);
            Controls.Add(btnAddPatron);
            Controls.Add(label1);
            Name = "PatronManagement";
            Text = "PatronManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddPatron;
        private Button btnLoanBook;
        private Button btnMainMenu;
        private Button btnExit;
        private Button btnEditPatron;
        private Button btnDeletePatron;
        private Button btnBookReturn;
    }
}