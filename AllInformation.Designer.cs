namespace LibraryManagement
{
    partial class AllInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllInformation));
            label1 = new Label();
            labelBooks = new Label();
            label2 = new Label();
            label3 = new Label();
            labelPatrons = new Label();
            label = new Label();
            labelLoanedBooks = new Label();
            btnMainMenu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(41, 26);
            label1.Name = "label1";
            label1.Size = new Size(174, 30);
            label1.TabIndex = 0;
            label1.Text = "Library Statistics";
            // 
            // labelBooks
            // 
            labelBooks.AutoSize = true;
            labelBooks.BackColor = Color.Transparent;
            labelBooks.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBooks.ForeColor = SystemColors.ButtonHighlight;
            labelBooks.Location = new Point(174, 73);
            labelBooks.Name = "labelBooks";
            labelBooks.Size = new Size(0, 15);
            labelBooks.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(42, 73);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 2;
            label2.Text = "Books in library:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(42, 105);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 3;
            label3.Text = "Patrons in library:";
            // 
            // labelPatrons
            // 
            labelPatrons.AutoSize = true;
            labelPatrons.BackColor = Color.Transparent;
            labelPatrons.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPatrons.ForeColor = SystemColors.ButtonHighlight;
            labelPatrons.Location = new Point(174, 105);
            labelPatrons.Name = "labelPatrons";
            labelPatrons.Size = new Size(0, 15);
            labelPatrons.TabIndex = 4;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ButtonHighlight;
            label.Location = new Point(41, 144);
            label.Name = "label";
            label.Size = new Size(93, 15);
            label.TabIndex = 5;
            label.Text = "Books loaned:";
            // 
            // labelLoanedBooks
            // 
            labelLoanedBooks.AutoSize = true;
            labelLoanedBooks.BackColor = Color.Transparent;
            labelLoanedBooks.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelLoanedBooks.ForeColor = SystemColors.ButtonHighlight;
            labelLoanedBooks.Location = new Point(174, 144);
            labelLoanedBooks.Name = "labelLoanedBooks";
            labelLoanedBooks.Size = new Size(0, 15);
            labelLoanedBooks.TabIndex = 6;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.Transparent;
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMainMenu.ForeColor = Color.Transparent;
            btnMainMenu.Location = new Point(624, 401);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(145, 37);
            btnMainMenu.TabIndex = 9;
            btnMainMenu.Text = "Exit to Main Menu";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // AllInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMainMenu);
            Controls.Add(labelLoanedBooks);
            Controls.Add(label);
            Controls.Add(labelPatrons);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelBooks);
            Controls.Add(label1);
            Name = "AllInformation";
            Text = "AllInformation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelBooks;
        private Label label2;
        private Label label3;
        private Label labelPatrons;
        private Label label;
        private Label labelLoanedBooks;
        private Button btnMainMenu;
    }
}