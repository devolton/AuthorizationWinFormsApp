namespace RegistrationApp
{
    partial class Form1
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
            loginMainLabel = new Label();
            loginInputLabel = new Label();
            loginInputTextBox = new TextBox();
            passwordInputLabel = new Label();
            passwordInputTextBox = new TextBox();
            comeInButton = new Button();
            noAccountLinkLabel = new LinkLabel();
            eyeVisibleLoginButton = new Button();
            SuspendLayout();
            // 
            // loginMainLabel
            // 
            loginMainLabel.AutoSize = true;
            loginMainLabel.Font = new Font("Stencil", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            loginMainLabel.ForeColor = Color.FromArgb(192, 0, 192);
            loginMainLabel.Location = new Point(151, 9);
            loginMainLabel.Name = "loginMainLabel";
            loginMainLabel.Size = new Size(147, 52);
            loginMainLabel.TabIndex = 0;
            loginMainLabel.Text = "Login";
            // 
            // loginInputLabel
            // 
            loginInputLabel.AutoSize = true;
            loginInputLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginInputLabel.ForeColor = Color.WhiteSmoke;
            loginInputLabel.Location = new Point(81, 72);
            loginInputLabel.Name = "loginInputLabel";
            loginInputLabel.Size = new Size(133, 24);
            loginInputLabel.TabIndex = 1;
            loginInputLabel.Text = "Input login:";
            // 
            // loginInputTextBox
            // 
            loginInputTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginInputTextBox.Location = new Point(81, 111);
            loginInputTextBox.Name = "loginInputTextBox";
            loginInputTextBox.Size = new Size(259, 34);
            loginInputTextBox.TabIndex = 2;
            loginInputTextBox.TextChanged += loginInputTextBox_TextChanged;
            // 
            // passwordInputLabel
            // 
            passwordInputLabel.AutoSize = true;
            passwordInputLabel.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            passwordInputLabel.ForeColor = Color.WhiteSmoke;
            passwordInputLabel.Location = new Point(81, 157);
            passwordInputLabel.Name = "passwordInputLabel";
            passwordInputLabel.Size = new Size(164, 21);
            passwordInputLabel.TabIndex = 3;
            passwordInputLabel.Text = "Input password:";
            // 
            // passwordInputTextBox
            // 
            passwordInputTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordInputTextBox.Location = new Point(81, 192);
            passwordInputTextBox.Name = "passwordInputTextBox";
            passwordInputTextBox.Size = new Size(201, 34);
            passwordInputTextBox.TabIndex = 4;
            passwordInputTextBox.UseSystemPasswordChar = true;
            passwordInputTextBox.TextChanged += passwordInputTextBox_TextChanged;
            // 
            // comeInButton
            // 
            comeInButton.BackColor = Color.Purple;
            comeInButton.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comeInButton.ForeColor = Color.WhiteSmoke;
            comeInButton.Location = new Point(81, 263);
            comeInButton.Name = "comeInButton";
            comeInButton.Size = new Size(259, 60);
            comeInButton.TabIndex = 5;
            comeInButton.Text = "Come in...";
            comeInButton.UseVisualStyleBackColor = false;
            comeInButton.Click += comeInButton_Click;
            // 
            // noAccountLinkLabel
            // 
            noAccountLinkLabel.AutoSize = true;
            noAccountLinkLabel.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            noAccountLinkLabel.LinkColor = Color.MidnightBlue;
            noAccountLinkLabel.Location = new Point(151, 354);
            noAccountLinkLabel.Name = "noAccountLinkLabel";
            noAccountLinkLabel.Size = new Size(127, 24);
            noAccountLinkLabel.TabIndex = 6;
            noAccountLinkLabel.TabStop = true;
            noAccountLinkLabel.Text = "No account...";
            noAccountLinkLabel.Click += noAccountLinkLabel_Click;
            // 
            // eyeVisibleLoginButton
            // 
            eyeVisibleLoginButton.BackColor = Color.WhiteSmoke;
            eyeVisibleLoginButton.BackgroundImage = Properties.Resources.eyeIcon;
            eyeVisibleLoginButton.BackgroundImageLayout = ImageLayout.Stretch;
            eyeVisibleLoginButton.Location = new Point(304, 192);
            eyeVisibleLoginButton.Name = "eyeVisibleLoginButton";
            eyeVisibleLoginButton.Size = new Size(36, 34);
            eyeVisibleLoginButton.TabIndex = 7;
            eyeVisibleLoginButton.UseVisualStyleBackColor = false;
            eyeVisibleLoginButton.Click += eyeVisibleLoginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(434, 450);
            Controls.Add(eyeVisibleLoginButton);
            Controls.Add(noAccountLinkLabel);
            Controls.Add(comeInButton);
            Controls.Add(passwordInputTextBox);
            Controls.Add(passwordInputLabel);
            Controls.Add(loginInputTextBox);
            Controls.Add(loginInputLabel);
            Controls.Add(loginMainLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authorization";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginMainLabel;
        private Label loginInputLabel;
        private TextBox loginInputTextBox;
        private Label passwordInputLabel;
        private TextBox passwordInputTextBox;
        private Button comeInButton;
        private LinkLabel noAccountLinkLabel;
        private Button eyeVisibleLoginButton;
    }
}