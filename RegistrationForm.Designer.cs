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
            eyeFirstPasswordVisibleButton = new Button();
            eyeRepeatPasswordVisibleButton = new Button();
            SuspendLayout();
            // 
            // registrationMainLabel
            // 
            registrationMainLabel.AutoSize = true;
            registrationMainLabel.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            registrationMainLabel.ForeColor = Color.Lime;
            registrationMainLabel.Location = new Point(90, 9);
            registrationMainLabel.Name = "registrationMainLabel";
            registrationMainLabel.Size = new Size(303, 47);
            registrationMainLabel.TabIndex = 0;
            registrationMainLabel.Text = "Registration";
            // 
            // loginRegistrationLabel
            // 
            loginRegistrationLabel.AutoSize = true;
            loginRegistrationLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginRegistrationLabel.ForeColor = Color.WhiteSmoke;
            loginRegistrationLabel.Location = new Point(24, 275);
            loginRegistrationLabel.Name = "loginRegistrationLabel";
            loginRegistrationLabel.Size = new Size(77, 24);
            loginRegistrationLabel.TabIndex = 1;
            loginRegistrationLabel.Text = "Login:";
            // 
            // loginRegistratioinTextBox
            // 
            loginRegistratioinTextBox.BackColor = Color.White;
            loginRegistratioinTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginRegistratioinTextBox.Location = new Point(218, 268);
            loginRegistratioinTextBox.Name = "loginRegistratioinTextBox";
            loginRegistratioinTextBox.Size = new Size(230, 34);
            loginRegistratioinTextBox.TabIndex = 2;
            loginRegistratioinTextBox.TextChanged += loginRegistratioinTextBox_TextChanged;
            // 
            // passwordRegistrationFirstLabel
            // 
            passwordRegistrationFirstLabel.AutoSize = true;
            passwordRegistrationFirstLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordRegistrationFirstLabel.ForeColor = Color.Gainsboro;
            passwordRegistrationFirstLabel.Location = new Point(22, 315);
            passwordRegistrationFirstLabel.Name = "passwordRegistrationFirstLabel";
            passwordRegistrationFirstLabel.Size = new Size(178, 24);
            passwordRegistrationFirstLabel.TabIndex = 3;
            passwordRegistrationFirstLabel.Text = "Input password:";
            // 
            // passwordRegistrationFirstTextBox
            // 
            passwordRegistrationFirstTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordRegistrationFirstTextBox.Location = new Point(218, 308);
            passwordRegistrationFirstTextBox.Name = "passwordRegistrationFirstTextBox";
            passwordRegistrationFirstTextBox.Size = new Size(182, 34);
            passwordRegistrationFirstTextBox.TabIndex = 4;
            passwordRegistrationFirstTextBox.UseSystemPasswordChar = true;
            passwordRegistrationFirstTextBox.TextChanged += passwordRegistrationFirstTextBox_TextChanged;
            // 
            // passwordRegistrationSecondLabel
            // 
            passwordRegistrationSecondLabel.AutoSize = true;
            passwordRegistrationSecondLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordRegistrationSecondLabel.ForeColor = Color.Gainsboro;
            passwordRegistrationSecondLabel.Location = new Point(24, 355);
            passwordRegistrationSecondLabel.Name = "passwordRegistrationSecondLabel";
            passwordRegistrationSecondLabel.Size = new Size(191, 24);
            passwordRegistrationSecondLabel.TabIndex = 5;
            passwordRegistrationSecondLabel.Text = "Repeat password:";
            // 
            // passwordRegistrationRepeatTextBox
            // 
            passwordRegistrationRepeatTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordRegistrationRepeatTextBox.Location = new Point(218, 348);
            passwordRegistrationRepeatTextBox.Name = "passwordRegistrationRepeatTextBox";
            passwordRegistrationRepeatTextBox.Size = new Size(182, 34);
            passwordRegistrationRepeatTextBox.TabIndex = 6;
            passwordRegistrationRepeatTextBox.UseSystemPasswordChar = true;
            passwordRegistrationRepeatTextBox.TextChanged += passwordRegistrationRepeatTextBox_TextChanged;
            // 
            // createAccountButton
            // 
            createAccountButton.BackColor = Color.ForestGreen;
            createAccountButton.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            createAccountButton.ForeColor = Color.White;
            createAccountButton.Location = new Point(90, 408);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(310, 67);
            createAccountButton.TabIndex = 7;
            createAccountButton.Text = "Create account...";
            createAccountButton.UseVisualStyleBackColor = false;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // firstNameRegistrationLabel
            // 
            firstNameRegistrationLabel.AutoSize = true;
            firstNameRegistrationLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameRegistrationLabel.ForeColor = Color.WhiteSmoke;
            firstNameRegistrationLabel.Location = new Point(24, 75);
            firstNameRegistrationLabel.Name = "firstNameRegistrationLabel";
            firstNameRegistrationLabel.Size = new Size(127, 24);
            firstNameRegistrationLabel.TabIndex = 8;
            firstNameRegistrationLabel.Text = "First name:";
            // 
            // firstNameRegistrationTextBox
            // 
            firstNameRegistrationTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameRegistrationTextBox.Location = new Point(218, 68);
            firstNameRegistrationTextBox.Name = "firstNameRegistrationTextBox";
            firstNameRegistrationTextBox.Size = new Size(230, 34);
            firstNameRegistrationTextBox.TabIndex = 9;
            firstNameRegistrationTextBox.TextChanged += firstNameRegistrationTextBox_TextChanged;
            // 
            // LastNameRegistrationLabel
            // 
            LastNameRegistrationLabel.AutoSize = true;
            LastNameRegistrationLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LastNameRegistrationLabel.ForeColor = Color.WhiteSmoke;
            LastNameRegistrationLabel.Location = new Point(22, 115);
            LastNameRegistrationLabel.Name = "LastNameRegistrationLabel";
            LastNameRegistrationLabel.Size = new Size(123, 24);
            LastNameRegistrationLabel.TabIndex = 10;
            LastNameRegistrationLabel.Text = "Last name:";
            // 
            // lastNameRegistrationTextBox
            // 
            lastNameRegistrationTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameRegistrationTextBox.Location = new Point(218, 108);
            lastNameRegistrationTextBox.Name = "lastNameRegistrationTextBox";
            lastNameRegistrationTextBox.Size = new Size(230, 34);
            lastNameRegistrationTextBox.TabIndex = 11;
            lastNameRegistrationTextBox.TextChanged += lastNameRegistrationTextBox_TextChanged;
            // 
            // middleNameRegistrationLabel
            // 
            middleNameRegistrationLabel.AutoSize = true;
            middleNameRegistrationLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            middleNameRegistrationLabel.ForeColor = Color.WhiteSmoke;
            middleNameRegistrationLabel.Location = new Point(24, 155);
            middleNameRegistrationLabel.Name = "middleNameRegistrationLabel";
            middleNameRegistrationLabel.Size = new Size(150, 24);
            middleNameRegistrationLabel.TabIndex = 12;
            middleNameRegistrationLabel.Text = "Middle name:";
            // 
            // middleNameRegistrationTextBox
            // 
            middleNameRegistrationTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            middleNameRegistrationTextBox.Location = new Point(218, 148);
            middleNameRegistrationTextBox.Name = "middleNameRegistrationTextBox";
            middleNameRegistrationTextBox.Size = new Size(230, 34);
            middleNameRegistrationTextBox.TabIndex = 13;
            middleNameRegistrationTextBox.TextChanged += middleNameRegistrationTextBox_TextChanged;
            // 
            // phoneRegistrationLabel
            // 
            phoneRegistrationLabel.AutoSize = true;
            phoneRegistrationLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phoneRegistrationLabel.ForeColor = Color.WhiteSmoke;
            phoneRegistrationLabel.Location = new Point(24, 235);
            phoneRegistrationLabel.Name = "phoneRegistrationLabel";
            phoneRegistrationLabel.Size = new Size(170, 24);
            phoneRegistrationLabel.TabIndex = 14;
            phoneRegistrationLabel.Text = "Phone number:";
            // 
            // phoneRegistrationTextBox
            // 
            phoneRegistrationTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneRegistrationTextBox.Location = new Point(218, 228);
            phoneRegistrationTextBox.Name = "phoneRegistrationTextBox";
            phoneRegistrationTextBox.Size = new Size(230, 34);
            phoneRegistrationTextBox.TabIndex = 15;
            phoneRegistrationTextBox.TextChanged += phoneRegistrationTextBox_TextChanged;
            // 
            // emailRegistratinLabel
            // 
            emailRegistratinLabel.AutoSize = true;
            emailRegistratinLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            emailRegistratinLabel.ForeColor = Color.WhiteSmoke;
            emailRegistratinLabel.Location = new Point(24, 195);
            emailRegistratinLabel.Name = "emailRegistratinLabel";
            emailRegistratinLabel.Size = new Size(77, 24);
            emailRegistratinLabel.TabIndex = 16;
            emailRegistratinLabel.Text = "Email:";
            // 
            // emailRegistrationTextBox
            // 
            emailRegistrationTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailRegistrationTextBox.Location = new Point(218, 188);
            emailRegistrationTextBox.Name = "emailRegistrationTextBox";
            emailRegistrationTextBox.Size = new Size(230, 34);
            emailRegistrationTextBox.TabIndex = 17;
            emailRegistrationTextBox.TextChanged += emailRegistrationTextBox_TextChanged;
            // 
            // eyeFirstPasswordVisibleButton
            // 
            eyeFirstPasswordVisibleButton.BackColor = Color.WhiteSmoke;
            eyeFirstPasswordVisibleButton.BackgroundImage = Properties.Resources.eyeIcon;
            eyeFirstPasswordVisibleButton.BackgroundImageLayout = ImageLayout.Stretch;
            eyeFirstPasswordVisibleButton.Location = new Point(417, 308);
            eyeFirstPasswordVisibleButton.Name = "eyeFirstPasswordVisibleButton";
            eyeFirstPasswordVisibleButton.Size = new Size(31, 34);
            eyeFirstPasswordVisibleButton.TabIndex = 18;
            eyeFirstPasswordVisibleButton.UseVisualStyleBackColor = false;
            eyeFirstPasswordVisibleButton.Click += eyeFirstPasswordVisibleButton_Click;
            // 
            // eyeRepeatPasswordVisibleButton
            // 
            eyeRepeatPasswordVisibleButton.BackColor = Color.WhiteSmoke;
            eyeRepeatPasswordVisibleButton.BackgroundImage = Properties.Resources.eyeIcon;
            eyeRepeatPasswordVisibleButton.BackgroundImageLayout = ImageLayout.Stretch;
            eyeRepeatPasswordVisibleButton.Location = new Point(417, 348);
            eyeRepeatPasswordVisibleButton.Name = "eyeRepeatPasswordVisibleButton";
            eyeRepeatPasswordVisibleButton.Size = new Size(31, 34);
            eyeRepeatPasswordVisibleButton.TabIndex = 19;
            eyeRepeatPasswordVisibleButton.UseVisualStyleBackColor = false;
            eyeRepeatPasswordVisibleButton.Click += eyeRepeatPasswordVisibleButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(490, 503);
            Controls.Add(eyeRepeatPasswordVisibleButton);
            Controls.Add(eyeFirstPasswordVisibleButton);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterParent;
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
        private Button eyeFirstPasswordVisibleButton;
        private Button eyeRepeatPasswordVisibleButton;
    }
}