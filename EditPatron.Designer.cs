namespace LibraryManagement
{
    partial class EditPatron
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPatron));
            listBoxPatrons = new ListBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnEdit = new Button();
            btnMainMenu = new Button();
            btnPatronManagement = new Button();
            SuspendLayout();
            // 
            // listBoxPatrons
            // 
            listBoxPatrons.FormattingEnabled = true;
            listBoxPatrons.ItemHeight = 15;
            listBoxPatrons.Location = new Point(469, 42);
            listBoxPatrons.Name = "listBoxPatrons";
            listBoxPatrons.Size = new Size(294, 274);
            listBoxPatrons.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(199, 61);
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
            btnSearch.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(314, 61);
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
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(4, 64);
            label1.Name = "label1";
            label1.Size = new Size(189, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter Name, Surname or Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(199, 125);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(199, 173);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(199, 223);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(129, 128);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(129, 176);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(129, 226);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BackgroundImage = (Image)resources.GetObject("btnEdit.BackgroundImage");
            btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(366, 61);
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
            btnMainMenu.Location = new Point(614, 402);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(149, 36);
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
            btnPatronManagement.Location = new Point(352, 402);
            btnPatronManagement.Name = "btnPatronManagement";
            btnPatronManagement.Size = new Size(189, 36);
            btnPatronManagement.TabIndex = 12;
            btnPatronManagement.Text = "Exit to Patron Management";
            btnPatronManagement.UseVisualStyleBackColor = false;
            btnPatronManagement.Click += btnPatronManagement_Click;
            // 
            // EditPatron
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPatronManagement);
            Controls.Add(btnMainMenu);
            Controls.Add(btnEdit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(listBoxPatrons);
            Name = "EditPatron";
            Text = "EditPatron";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPatrons;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label1;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnEdit;
        private Button btnMainMenu;
        private Button btnPatronManagement;
    }
}