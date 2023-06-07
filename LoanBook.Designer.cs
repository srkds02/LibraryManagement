namespace LibraryManagement
{
    partial class LoanBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanBook));
            listBoxBooks = new ListBox();
            listBoxPatrons = new ListBox();
            txtSearchPatrons = new TextBox();
            txtSearchBooks = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSearchBooks = new Button();
            btnSearchPatrons = new Button();
            txtLoan = new TextBox();
            label3 = new Label();
            btnLoan = new Button();
            btnMainMenu = new Button();
            btnPatronManagement = new Button();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(198, 118);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(264, 244);
            listBoxBooks.TabIndex = 0;
            // 
            // listBoxPatrons
            // 
            listBoxPatrons.FormattingEnabled = true;
            listBoxPatrons.ItemHeight = 15;
            listBoxPatrons.Location = new Point(497, 118);
            listBoxPatrons.Name = "listBoxPatrons";
            listBoxPatrons.Size = new Size(278, 244);
            listBoxPatrons.TabIndex = 1;
            // 
            // txtSearchPatrons
            // 
            txtSearchPatrons.Location = new Point(591, 49);
            txtSearchPatrons.Name = "txtSearchPatrons";
            txtSearchPatrons.Size = new Size(100, 23);
            txtSearchPatrons.TabIndex = 2;
            // 
            // txtSearchBooks
            // 
            txtSearchBooks.Location = new Point(278, 49);
            txtSearchBooks.Name = "txtSearchBooks";
            txtSearchBooks.Size = new Size(100, 23);
            txtSearchBooks.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(246, 31);
            label1.Name = "label1";
            label1.Size = new Size(211, 15);
            label1.TabIndex = 4;
            label1.Text = "Enter Title or author for searching";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(554, 31);
            label2.Name = "label2";
            label2.Size = new Size(189, 15);
            label2.TabIndex = 5;
            label2.Text = "Enter Name, Surname or email";
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.BackColor = Color.Transparent;
            btnSearchBooks.BackgroundImage = (Image)resources.GetObject("btnSearchBooks.BackgroundImage");
            btnSearchBooks.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchBooks.FlatStyle = FlatStyle.Flat;
            btnSearchBooks.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchBooks.ForeColor = SystemColors.ButtonHighlight;
            btnSearchBooks.Location = new Point(314, 78);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(30, 30);
            btnSearchBooks.TabIndex = 6;
            btnSearchBooks.UseVisualStyleBackColor = false;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // btnSearchPatrons
            // 
            btnSearchPatrons.BackColor = Color.Transparent;
            btnSearchPatrons.BackgroundImage = (Image)resources.GetObject("btnSearchPatrons.BackgroundImage");
            btnSearchPatrons.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchPatrons.FlatStyle = FlatStyle.Flat;
            btnSearchPatrons.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchPatrons.ForeColor = SystemColors.ButtonHighlight;
            btnSearchPatrons.Location = new Point(625, 78);
            btnSearchPatrons.Name = "btnSearchPatrons";
            btnSearchPatrons.Size = new Size(30, 30);
            btnSearchPatrons.TabIndex = 7;
            btnSearchPatrons.UseVisualStyleBackColor = false;
            btnSearchPatrons.Click += btnSearchPatrons_Click;
            // 
            // txtLoan
            // 
            txtLoan.Location = new Point(68, 122);
            txtLoan.Name = "txtLoan";
            txtLoan.Size = new Size(100, 23);
            txtLoan.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(68, 95);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 9;
            label3.Text = "Enter Loan end date";
            // 
            // btnLoan
            // 
            btnLoan.BackColor = Color.Transparent;
            btnLoan.BackgroundImage = (Image)resources.GetObject("btnLoan.BackgroundImage");
            btnLoan.BackgroundImageLayout = ImageLayout.Stretch;
            btnLoan.FlatStyle = FlatStyle.Flat;
            btnLoan.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoan.ForeColor = SystemColors.ButtonHighlight;
            btnLoan.Location = new Point(98, 151);
            btnLoan.Name = "btnLoan";
            btnLoan.Size = new Size(35, 30);
            btnLoan.TabIndex = 10;
            btnLoan.UseVisualStyleBackColor = false;
            btnLoan.Click += btnLoan_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.Transparent;
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMainMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMainMenu.Location = new Point(615, 406);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(148, 32);
            btnMainMenu.TabIndex = 11;
            btnMainMenu.Text = "Exit to Main Menu";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnPatronManagement
            // 
            btnPatronManagement.BackColor = Color.Transparent;
            btnPatronManagement.FlatStyle = FlatStyle.Flat;
            btnPatronManagement.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPatronManagement.ForeColor = SystemColors.ButtonHighlight;
            btnPatronManagement.Location = new Point(392, 406);
            btnPatronManagement.Name = "btnPatronManagement";
            btnPatronManagement.Size = new Size(188, 32);
            btnPatronManagement.TabIndex = 12;
            btnPatronManagement.Text = "Exit to Patron Management";
            btnPatronManagement.UseVisualStyleBackColor = false;
            btnPatronManagement.Click += btnPatronManagement_Click;
            // 
            // LoanBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPatronManagement);
            Controls.Add(btnMainMenu);
            Controls.Add(btnLoan);
            Controls.Add(label3);
            Controls.Add(txtLoan);
            Controls.Add(btnSearchPatrons);
            Controls.Add(btnSearchBooks);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearchBooks);
            Controls.Add(txtSearchPatrons);
            Controls.Add(listBoxPatrons);
            Controls.Add(listBoxBooks);
            Name = "LoanBook";
            Text = "LoanBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBooks;
        private ListBox listBoxPatrons;
        private TextBox txtSearchPatrons;
        private TextBox txtSearchBooks;
        private Label label1;
        private Label label2;
        private Button btnSearchBooks;
        private Button btnSearchPatrons;
        private TextBox txtLoan;
        private Label label3;
        private Button btnLoan;
        private Button btnMainMenu;
        private Button btnPatronManagement;
    }
}