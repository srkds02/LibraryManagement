namespace LibraryManagement
{
    partial class AddPatron
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatron));
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            listBoxPatrons = new ListBox();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnMainMenu = new Button();
            btnPatronManagement = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(134, 97);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(134, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 2;
            // 
            // listBoxPatrons
            // 
            listBoxPatrons.FormattingEnabled = true;
            listBoxPatrons.ItemHeight = 15;
            listBoxPatrons.Location = new Point(485, 43);
            listBoxPatrons.Name = "listBoxPatrons";
            listBoxPatrons.Size = new Size(267, 199);
            listBoxPatrons.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(251, 149);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(30, 30);
            btnAdd.TabIndex = 4;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(63, 46);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(63, 100);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(64, 157);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.Transparent;
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMainMenu.ForeColor = Color.Transparent;
            btnMainMenu.Location = new Point(607, 405);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(145, 33);
            btnMainMenu.TabIndex = 8;
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
            btnPatronManagement.Location = new Point(374, 405);
            btnPatronManagement.Name = "btnPatronManagement";
            btnPatronManagement.Size = new Size(189, 33);
            btnPatronManagement.TabIndex = 9;
            btnPatronManagement.Text = "Exit to Patron Management";
            btnPatronManagement.UseVisualStyleBackColor = false;
            btnPatronManagement.Click += btnPatronManagement_Click;
            // 
            // AddPatron
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPatronManagement);
            Controls.Add(btnMainMenu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(listBoxPatrons);
            Controls.Add(txtEmail);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Name = "AddPatron";
            Text = "AddPatron";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private ListBox listBoxPatrons;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnMainMenu;
        private Button btnPatronManagement;
    }
}