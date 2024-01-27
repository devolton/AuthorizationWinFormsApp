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
            SuspendLayout();
            // 
            // loginMainLabel
            // 
            loginMainLabel.AutoSize = true;
            loginMainLabel.Font = new Font("Stencil", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            loginMainLabel.Location = new Point(92, 3);
            loginMainLabel.Name = "loginMainLabel";
            loginMainLabel.Size = new Size(147, 52);
            loginMainLabel.TabIndex = 0;
            loginMainLabel.Text = "Login";
            // 
            // loginInputLabel
            // 
            loginInputLabel.AutoSize = true;
            loginInputLabel.Location = new Point(41, 77);
            loginInputLabel.Name = "loginInputLabel";
            loginInputLabel.Size = new Size(84, 20);
            loginInputLabel.TabIndex = 1;
            loginInputLabel.Text = "Input login:";
            // 
            // loginInputTextBox
            // 
            loginInputTextBox.Location = new Point(160, 74);
            loginInputTextBox.Name = "loginInputTextBox";
            loginInputTextBox.Size = new Size(125, 27);
            loginInputTextBox.TabIndex = 2;
            loginInputTextBox.TextChanged += loginInputTextBox_TextChanged;
            // 
            // passwordInputLabel
            // 
            passwordInputLabel.AutoSize = true;
            passwordInputLabel.Location = new Point(41, 110);
            passwordInputLabel.Name = "passwordInputLabel";
            passwordInputLabel.Size = new Size(113, 20);
            passwordInputLabel.TabIndex = 3;
            passwordInputLabel.Text = "Input password:";
            // 
            // passwordInputTextBox
            // 
            passwordInputTextBox.Location = new Point(160, 109);
            passwordInputTextBox.Name = "passwordInputTextBox";
            passwordInputTextBox.PasswordChar = '*';
            passwordInputTextBox.Size = new Size(125, 27);
            passwordInputTextBox.TabIndex = 4;
            passwordInputTextBox.TextChanged += passwordInputTextBox_TextChanged;
            // 
            // comeInButton
            // 
            comeInButton.Location = new Point(104, 162);
            comeInButton.Name = "comeInButton";
            comeInButton.Size = new Size(94, 29);
            comeInButton.TabIndex = 5;
            comeInButton.Text = "Come in...";
            comeInButton.UseVisualStyleBackColor = true;
            comeInButton.Click += comeInButton_Click;
            // 
            // noAccountLinkLabel
            // 
            noAccountLinkLabel.AutoSize = true;
            noAccountLinkLabel.Location = new Point(104, 217);
            noAccountLinkLabel.Name = "noAccountLinkLabel";
            noAccountLinkLabel.Size = new Size(94, 20);
            noAccountLinkLabel.TabIndex = 6;
            noAccountLinkLabel.TabStop = true;
            noAccountLinkLabel.Text = "No account...";
            noAccountLinkLabel.Click += noAccountLinkLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(339, 450);
            Controls.Add(noAccountLinkLabel);
            Controls.Add(comeInButton);
            Controls.Add(passwordInputTextBox);
            Controls.Add(passwordInputLabel);
            Controls.Add(loginInputTextBox);
            Controls.Add(loginInputLabel);
            Controls.Add(loginMainLabel);
            Name = "Form1";
            Text = "Main";
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
    }
}