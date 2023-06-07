namespace LibraryManagement
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            btnRegistration = new Button();
            checkBoxShowPassword = new CheckBox();
            txtPassword = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(306, 52);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter your e-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(306, 127);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter your username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(306, 193);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter your password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(306, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(306, 145);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(60, 38);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 6;
            label4.Text = "Registration";
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = Color.Transparent;
            btnRegistration.FlatStyle = FlatStyle.Flat;
            btnRegistration.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistration.ForeColor = SystemColors.ButtonHighlight;
            btnRegistration.Location = new Point(288, 251);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(143, 27);
            btnRegistration.TabIndex = 7;
            btnRegistration.Text = "Create new account!";
            btnRegistration.UseVisualStyleBackColor = false;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.BackColor = Color.Transparent;
            checkBoxShowPassword.FlatStyle = FlatStyle.Flat;
            checkBoxShowPassword.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxShowPassword.ForeColor = SystemColors.ButtonHighlight;
            checkBoxShowPassword.Location = new Point(413, 213);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(160, 19);
            checkBoxShowPassword.TabIndex = 8;
            checkBoxShowPassword.Text = "Make password visible";
            checkBoxShowPassword.UseVisualStyleBackColor = false;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(307, 211);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 5;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Transparent;
            btnExit.Location = new Point(713, 404);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 34);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(btnRegistration);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private Label label4;
        private Button btnRegistration;
        private CheckBox checkBoxShowPassword;
        private TextBox txtPassword;
        private Button btnExit;
    }
}