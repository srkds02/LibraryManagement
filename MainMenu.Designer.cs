namespace LibraryManagement
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            label1 = new Label();
            btnBookManagement = new Button();
            btnPatronManagement = new Button();
            btnAllInformation = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Main Menu";
            // 
            // btnBookManagement
            // 
            btnBookManagement.BackColor = Color.Transparent;
            btnBookManagement.FlatStyle = FlatStyle.Flat;
            btnBookManagement.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBookManagement.ForeColor = SystemColors.ButtonHighlight;
            btnBookManagement.Location = new Point(39, 58);
            btnBookManagement.Name = "btnBookManagement";
            btnBookManagement.Size = new Size(161, 23);
            btnBookManagement.TabIndex = 1;
            btnBookManagement.Text = "1. Book Management";
            btnBookManagement.UseVisualStyleBackColor = false;
            btnBookManagement.Click += btnBookManagement_Click;
            // 
            // btnPatronManagement
            // 
            btnPatronManagement.BackColor = Color.Transparent;
            btnPatronManagement.FlatStyle = FlatStyle.Flat;
            btnPatronManagement.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPatronManagement.ForeColor = SystemColors.ButtonHighlight;
            btnPatronManagement.Location = new Point(39, 109);
            btnPatronManagement.Name = "btnPatronManagement";
            btnPatronManagement.Size = new Size(161, 23);
            btnPatronManagement.TabIndex = 2;
            btnPatronManagement.Text = "2. Patron Management";
            btnPatronManagement.UseVisualStyleBackColor = false;
            btnPatronManagement.Click += btnPatronManagement_Click;
            // 
            // btnAllInformation
            // 
            btnAllInformation.BackColor = Color.Transparent;
            btnAllInformation.FlatStyle = FlatStyle.Flat;
            btnAllInformation.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAllInformation.ForeColor = SystemColors.ButtonHighlight;
            btnAllInformation.Location = new Point(39, 159);
            btnAllInformation.Name = "btnAllInformation";
            btnAllInformation.Size = new Size(161, 23);
            btnAllInformation.TabIndex = 4;
            btnAllInformation.Text = "3. All Information";
            btnAllInformation.UseVisualStyleBackColor = false;
            btnAllInformation.Click += btnAllInformation_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(689, 392);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 33);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnAllInformation);
            Controls.Add(btnPatronManagement);
            Controls.Add(btnBookManagement);
            Controls.Add(label1);
            Name = "MainMenu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBookManagement;
        private Button btnPatronManagement;
        private Button btnAllInformation;
        private Button btnExit;
    }
}