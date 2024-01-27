namespace RegistrationApp
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
            registrationMainLabel = new Label();
            loginRegistrationLabel = new Label();
            loginRegistratioinTextBox = new TextBox();
            passwordRegistrationFirstLabel = new Label();
            passwordRegistrationFirstTextBox = new TextBox();
            passwordRegistrationSecondLabel = new Label();
            passwordRegistrationRepeatTextBox = new TextBox();
            createAccountButton = new Button();
            firstNameRegistrationLabel = new Label();
            firstNameRegistrationTextBox = new TextBox();
            LastNameRegistrationLabel = new Label();
            lastNameRegistrationTextBox = new TextBox();
            middleNameRegistrationLabel = new Label();
            middleNameRegistrationTextBox = new TextBox();
            phoneRegistrationLabel = new Label();
            phoneRegistrationTextBox = new TextBox();
            emailRegistratinLabel = new Label();
            emailRegistrationTextBox = new TextBox();
            SuspendLayout();
            // 
            // registrationMainLabel
            // 
            registrationMainLabel.AutoSize = true;
            registrationMainLabel.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            registrationMainLabel.Location = new Point(35, 9);
            registrationMainLabel.Name = "registrationMainLabel";
            registrationMainLabel.Size = new Size(303, 47);
            registrationMainLabel.TabIndex = 0;
            registrationMainLabel.Text = "Registration";
            // 
            // loginRegistrationLabel
            // 
            loginRegistrationLabel.AutoSize = true;
            loginRegistrationLabel.Location = new Point(22, 68);
            loginRegistrationLabel.Name = "loginRegistrationLabel";
            loginRegistrationLabel.Size = new Size(84, 20);
            loginRegistrationLabel.TabIndex = 1;
            loginRegistrationLabel.Text = "Input login:";
            // 
            // loginRegistratioinTextBox
            // 
            loginRegistratioinTextBox.BackColor = Color.White;
            loginRegistratioinTextBox.Location = new Point(183, 68);
            loginRegistratioinTextBox.Name = "loginRegistratioinTextBox";
            loginRegistratioinTextBox.Size = new Size(125, 27);
            loginRegistratioinTextBox.TabIndex = 2;
            loginRegistratioinTextBox.TextChanged += loginRegistratioinTextBox_TextChanged;
            // 
            // passwordRegistrationFirstLabel
            // 
            passwordRegistrationFirstLabel.AutoSize = true;
            passwordRegistrationFirstLabel.Location = new Point(22, 115);
            passwordRegistrationFirstLabel.Name = "passwordRegistrationFirstLabel";
            passwordRegistrationFirstLabel.Size = new Size(113, 20);
            passwordRegistrationFirstLabel.TabIndex = 3;
            passwordRegistrationFirstLabel.Text = "Input password:";
            // 
            // passwordRegistrationFirstTextBox
            // 
            passwordRegistrationFirstTextBox.Location = new Point(183, 115);
            passwordRegistrationFirstTextBox.Name = "passwordRegistrationFirstTextBox";
            passwordRegistrationFirstTextBox.PasswordChar = '*';
            passwordRegistrationFirstTextBox.Size = new Size(125, 27);
            passwordRegistrationFirstTextBox.TabIndex = 4;
            passwordRegistrationFirstTextBox.TextChanged += passwordRegistrationFirstTextBox_TextChanged;
            // 
            // passwordRegistrationSecondLabel
            // 
            passwordRegistrationSecondLabel.AutoSize = true;
            passwordRegistrationSecondLabel.Location = new Point(22, 167);
            passwordRegistrationSecondLabel.Name = "passwordRegistrationSecondLabel";
            passwordRegistrationSecondLabel.Size = new Size(126, 20);
            passwordRegistrationSecondLabel.TabIndex = 5;
            passwordRegistrationSecondLabel.Text = "Repeat password:";
            // 
            // passwordRegistrationRepeatTextBox
            // 
            passwordRegistrationRepeatTextBox.Location = new Point(183, 160);
            passwordRegistrationRepeatTextBox.Name = "passwordRegistrationRepeatTextBox";
            passwordRegistrationRepeatTextBox.PasswordChar = '*';
            passwordRegistrationRepeatTextBox.Size = new Size(125, 27);
            passwordRegistrationRepeatTextBox.TabIndex = 6;
            passwordRegistrationRepeatTextBox.TextChanged += passwordRegistrationRepeatTextBox_TextChanged;
            // 
            // createAccountButton
            // 
            createAccountButton.Location = new Point(90, 425);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(179, 51);
            createAccountButton.TabIndex = 7;
            createAccountButton.Text = "Create account...";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // firstNameRegistrationLabel
            // 
            firstNameRegistrationLabel.AutoSize = true;
            firstNameRegistrationLabel.Location = new Point(22, 209);
            firstNameRegistrationLabel.Name = "firstNameRegistrationLabel";
            firstNameRegistrationLabel.Size = new Size(116, 20);
            firstNameRegistrationLabel.TabIndex = 8;
            firstNameRegistrationLabel.Text = "Input first name:";
            // 
            // firstNameRegistrationTextBox
            // 
            firstNameRegistrationTextBox.Location = new Point(183, 202);
            firstNameRegistrationTextBox.Name = "firstNameRegistrationTextBox";
            firstNameRegistrationTextBox.Size = new Size(125, 27);
            firstNameRegistrationTextBox.TabIndex = 9;
            firstNameRegistrationTextBox.TextChanged += firstNameRegistrationTextBox_TextChanged;
            // 
            // LastNameRegistrationLabel
            // 
            LastNameRegistrationLabel.AutoSize = true;
            LastNameRegistrationLabel.Location = new Point(22, 252);
            LastNameRegistrationLabel.Name = "LastNameRegistrationLabel";
            LastNameRegistrationLabel.Size = new Size(114, 20);
            LastNameRegistrationLabel.TabIndex = 10;
            LastNameRegistrationLabel.Text = "Input last name:";
            // 
            // lastNameRegistrationTextBox
            // 
            lastNameRegistrationTextBox.Location = new Point(183, 245);
            lastNameRegistrationTextBox.Name = "lastNameRegistrationTextBox";
            lastNameRegistrationTextBox.Size = new Size(125, 27);
            lastNameRegistrationTextBox.TabIndex = 11;
            lastNameRegistrationTextBox.TextChanged += lastNameRegistrationTextBox_TextChanged;
            // 
            // middleNameRegistrationLabel
            // 
            middleNameRegistrationLabel.AutoSize = true;
            middleNameRegistrationLabel.Location = new Point(22, 293);
            middleNameRegistrationLabel.Name = "middleNameRegistrationLabel";
            middleNameRegistrationLabel.Size = new Size(138, 20);
            middleNameRegistrationLabel.TabIndex = 12;
            middleNameRegistrationLabel.Text = "Input middle name:";
            // 
            // middleNameRegistrationTextBox
            // 
            middleNameRegistrationTextBox.Location = new Point(183, 286);
            middleNameRegistrationTextBox.Name = "middleNameRegistrationTextBox";
            middleNameRegistrationTextBox.Size = new Size(125, 27);
            middleNameRegistrationTextBox.TabIndex = 13;
            middleNameRegistrationTextBox.TextChanged += middleNameRegistrationTextBox_TextChanged;
            // 
            // phoneRegistrationLabel
            // 
            phoneRegistrationLabel.AutoSize = true;
            phoneRegistrationLabel.Location = new Point(22, 332);
            phoneRegistrationLabel.Name = "phoneRegistrationLabel";
            phoneRegistrationLabel.Size = new Size(147, 20);
            phoneRegistrationLabel.TabIndex = 14;
            phoneRegistrationLabel.Text = "Input phone number:";
            // 
            // phoneRegistrationTextBox
            // 
            phoneRegistrationTextBox.Location = new Point(183, 325);
            phoneRegistrationTextBox.Name = "phoneRegistrationTextBox";
            phoneRegistrationTextBox.Size = new Size(125, 27);
            phoneRegistrationTextBox.TabIndex = 15;
            phoneRegistrationTextBox.TextChanged += phoneRegistrationTextBox_TextChanged;
            // 
            // emailRegistratinLabel
            // 
            emailRegistratinLabel.AutoSize = true;
            emailRegistratinLabel.Location = new Point(24, 373);
            emailRegistratinLabel.Name = "emailRegistratinLabel";
            emailRegistratinLabel.Size = new Size(87, 20);
            emailRegistratinLabel.TabIndex = 16;
            emailRegistratinLabel.Text = "Input email:";
            // 
            // emailRegistrationTextBox
            // 
            emailRegistrationTextBox.Location = new Point(184, 369);
            emailRegistrationTextBox.Name = "emailRegistrationTextBox";
            emailRegistrationTextBox.Size = new Size(125, 27);
            emailRegistrationTextBox.TabIndex = 17;
            emailRegistrationTextBox.TextChanged += emailRegistrationTextBox_TextChanged;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(373, 503);
            Controls.Add(emailRegistrationTextBox);
            Controls.Add(emailRegistratinLabel);
            Controls.Add(phoneRegistrationTextBox);
            Controls.Add(phoneRegistrationLabel);
            Controls.Add(middleNameRegistrationTextBox);
            Controls.Add(middleNameRegistrationLabel);
            Controls.Add(lastNameRegistrationTextBox);
            Controls.Add(LastNameRegistrationLabel);
            Controls.Add(firstNameRegistrationTextBox);
            Controls.Add(firstNameRegistrationLabel);
            Controls.Add(createAccountButton);
            Controls.Add(passwordRegistrationRepeatTextBox);
            Controls.Add(passwordRegistrationSecondLabel);
            Controls.Add(passwordRegistrationFirstTextBox);
            Controls.Add(passwordRegistrationFirstLabel);
            Controls.Add(loginRegistratioinTextBox);
            Controls.Add(loginRegistrationLabel);
            Controls.Add(registrationMainLabel);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registrationMainLabel;
        private Label loginRegistrationLabel;
        private TextBox loginRegistratioinTextBox;
        private Label passwordRegistrationFirstLabel;
        private TextBox passwordRegistrationFirstTextBox;
        private Label passwordRegistrationSecondLabel;
        private TextBox passwordRegistrationRepeatTextBox;
        private Button createAccountButton;
        private Label firstNameRegistrationLabel;
        private TextBox firstNameRegistrationTextBox;
        private Label LastNameRegistrationLabel;
        private TextBox lastNameRegistrationTextBox;
        private Label middleNameRegistrationLabel;
        private TextBox middleNameRegistrationTextBox;
        private Label phoneRegistrationLabel;
        private TextBox phoneRegistrationTextBox;
        private Label emailRegistratinLabel;
        private TextBox emailRegistrationTextBox;
    }
}