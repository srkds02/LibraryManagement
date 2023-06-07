namespace LibraryManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            labelRegistration = new Label();
            checkBoxShowPassword = new CheckBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(336, 134);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(336, 182);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(336, 116);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(338, 164);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(348, 211);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 33);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelRegistration
            // 
            labelRegistration.AutoSize = true;
            labelRegistration.BackColor = Color.Transparent;
            labelRegistration.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelRegistration.ForeColor = SystemColors.ButtonHighlight;
            labelRegistration.Location = new Point(297, 247);
            labelRegistration.Name = "labelRegistration";
            labelRegistration.Size = new Size(218, 15);
            labelRegistration.TabIndex = 5;
            labelRegistration.Text = "Got no account? Click to registrate!";
            labelRegistration.Click += labelRegistration_Click;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.BackColor = Color.Transparent;
            checkBoxShowPassword.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxShowPassword.ForeColor = SystemColors.ButtonHighlight;
            checkBoxShowPassword.Location = new Point(446, 185);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(119, 19);
            checkBoxShowPassword.TabIndex = 6;
            checkBoxShowPassword.Text = "Show password";
            checkBoxShowPassword.UseVisualStyleBackColor = false;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
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
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(labelRegistration);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Label labelRegistration;
        private CheckBox checkBoxShowPassword;
        private Button btnExit;
    }
}