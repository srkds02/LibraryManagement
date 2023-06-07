namespace LibraryManagement
{
    partial class DeletePatron
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePatron));
            listBoxPatrons = new ListBox();
            txtSearch = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            btnDelete = new Button();
            btnMainMenu = new Button();
            btnPatronManagement = new Button();
            SuspendLayout();
            // 
            // listBoxPatrons
            // 
            listBoxPatrons.FormattingEnabled = true;
            listBoxPatrons.ItemHeight = 15;
            listBoxPatrons.Location = new Point(464, 47);
            listBoxPatrons.Name = "listBoxPatrons";
            listBoxPatrons.Size = new Size(312, 319);
            listBoxPatrons.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(207, 59);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(189, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter Name, Surname or Email";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(322, 59);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(30, 30);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(369, 59);
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
            btnMainMenu.Location = new Point(605, 408);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(161, 30);
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
            btnPatronManagement.Location = new Point(342, 408);
            btnPatronManagement.Name = "btnPatronManagement";
            btnPatronManagement.Size = new Size(199, 30);
            btnPatronManagement.TabIndex = 6;
            btnPatronManagement.Text = "Exit to Patron Management";
            btnPatronManagement.UseVisualStyleBackColor = false;
            btnPatronManagement.Click += btnPatronManagement_Click;
            // 
            // DeletePatron
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPatronManagement);
            Controls.Add(btnMainMenu);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(listBoxPatrons);
            Name = "DeletePatron";
            Text = "DeletePatron";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPatrons;
        private TextBox txtSearch;
        private Label label1;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnMainMenu;
        private Button btnPatronManagement;
    }
}