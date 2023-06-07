namespace LibraryManagement
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            listBoxLoans = new ListBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            btnReturn = new Button();
            btnMainMenu = new Button();
            btnPatronManagement = new Button();
            SuspendLayout();
            // 
            // listBoxLoans
            // 
            listBoxLoans.FormattingEnabled = true;
            listBoxLoans.HorizontalScrollbar = true;
            listBoxLoans.ItemHeight = 15;
            listBoxLoans.Location = new Point(447, 41);
            listBoxLoans.Name = "listBoxLoans";
            listBoxLoans.Size = new Size(330, 319);
            listBoxLoans.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(183, 79);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(131, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(336, 74);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(30, 30);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(175, 65);
            label1.TabIndex = 3;
            label1.Text = "Enter book title, patron name or surname";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Transparent;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = SystemColors.ButtonHighlight;
            btnReturn.Location = new Point(225, 118);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Returned";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.Transparent;
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMainMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMainMenu.Location = new Point(618, 404);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(149, 34);
            btnMainMenu.TabIndex = 5;
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
            btnPatronManagement.Location = new Point(392, 404);
            btnPatronManagement.Name = "btnPatronManagement";
            btnPatronManagement.Size = new Size(183, 34);
            btnPatronManagement.TabIndex = 6;
            btnPatronManagement.Text = "Exit to Patron Management";
            btnPatronManagement.UseVisualStyleBackColor = false;
            btnPatronManagement.Click += btnPatronManagement_Click;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(btnPatronManagement);
            Controls.Add(btnMainMenu);
            Controls.Add(btnReturn);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(listBoxLoans);
            Name = "ReturnBook";
            Text = "ReturnBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxLoans;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label1;
        private Button btnReturn;
        private Button btnMainMenu;
        private Button btnPatronManagement;
    }
}