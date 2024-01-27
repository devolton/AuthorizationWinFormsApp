using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationApp
{
    public partial class RegistrationForm : Form
    {
        private AccountsDB _accountsDB;
        private FieldValidator _validator;
        private bool _isValidLogin = false;
        private bool _isValidFirstName = false;
        private bool _isValidLastName = false;
        private bool _isValidMiddleName = false;
        private bool _isValidPhoneNumber = false;
        private bool _isValidEmail = false;
        private bool _isValidFirstPassword = false;
        private bool _isValidRepeatPassword = false;
        private bool _isUniqueLogin = false;
        private bool _isUniqueEmail = false;
        private bool _isUniquePhoneNumber = false;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (IsValidFields())
            {
                var newAccount = new Account()
                {
                    FirstName = firstNameRegistrationTextBox.Text,
                    LastName = lastNameRegistrationTextBox.Text,
                    MiddleName = middleNameRegistrationTextBox.Text,
                    PhoneNumber = phoneRegistrationTextBox.Text,
                    Email = emailRegistrationTextBox.Text,
                    Login = loginRegistratioinTextBox.Text,
                    Password = _accountsDB.EncryptPassword(passwordRegistrationFirstTextBox.Text)
                };
                _accountsDB.AddNewAccount(newAccount);
                var successForm = new SuccessRegistrationForm();
                successForm.ShowDialog();
                this.Close();

            }
            else
            {
                ChangeIncorrectFieldsColor();
            }
        }





        private void loginRegistratioinTextBox_TextChanged(object sender, EventArgs e)
        {
            _isValidLogin = _validator.IsValidLogin(loginRegistratioinTextBox.Text);
            _isUniqueLogin = _accountsDB.IsUniqueLogin(loginRegistratioinTextBox.Text);
            ReturnFieldToCorrectState(loginRegistratioinTextBox);

        }

        private void passwordRegistrationFirstTextBox_TextChanged(object sender, EventArgs e)
        {
            _isValidFirstPassword = _validator.IsValidPassword(passwordRegistrationFirstTextBox.Text);
            ReturnFieldToCorrectState(passwordRegistrationFirstTextBox);
        }

        private void passwordRegistrationRepeatTextBox_TextChanged(object sender, EventArgs e)
        {
            _isValidRepeatPassword = _validator.IsValidPassword(passwordRegistrationRepeatTextBox.Text);
            ReturnFieldToCorrectState(passwordRegistrationRepeatTextBox);
        }

        private void firstNameRegistrationTextBox_TextChanged(object sender, EventArgs e)
        {
            _isValidFirstName = _validator.IsValidName(firstNameRegistrationTextBox.Text);
            ReturnFieldToCorrectState(firstNameRegistrationTextBox);
        }

        private void lastNameRegistrationTextBox_TextChanged(object sender, EventArgs e)
        {
            _isValidLastName = _validator.IsValidName(lastNameRegistrationTextBox.Text);
            ReturnFieldToCorrectState(lastNameRegistrationTextBox);
        }

        private void middleNameRegistrationTextBox_TextChanged(object sender, EventArgs e)
        {
            _isValidMiddleName = _validator.IsValidName(middleNameRegistrationTextBox.Text);
            ReturnFieldToCorrectState(middleNameRegistrationTextBox);
        }

        private void phoneRegistrationTextBox_TextChanged(object sender, EventArgs e)
        {
            _isValidPhoneNumber = _validator.IsValidPhoneNumber(phoneRegistrationTextBox.Text);
            _isUniquePhoneNumber = _accountsDB.IsUniquePhoneNumber(phoneRegistrationTextBox.Text);
            ReturnFieldToCorrectState(phoneRegistrationTextBox);
        }

        private void emailRegistrationTextBox_TextChanged(object sender, EventArgs e)
        {
            _isValidEmail = _validator.IsValidEmail(emailRegistrationTextBox.Text);
            _isUniqueEmail = _accountsDB.IsUniqueEmail(emailRegistrationTextBox.Text);
            ReturnFieldToCorrectState(emailRegistrationTextBox);
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            _validator = new FieldValidator();
            _accountsDB = AccountsDB.Instance();

        }
        private bool IsValidFields()
        {
            return _isValidFirstName && _isValidLastName && _isValidMiddleName && _isValidPhoneNumber && _isValidEmail && _isValidLogin
                && passwordRegistrationFirstTextBox.Text == passwordRegistrationRepeatTextBox.Text && _isUniqueEmail && _isUniquePhoneNumber && _isUniqueLogin;

        }
        private void ChangeIncorrectFieldsColor()
        {
            if (!_isValidFirstName) firstNameRegistrationTextBox.BackColor = Color.Red;
            if (!_isValidLastName) lastNameRegistrationTextBox.BackColor = Color.Red;
            if (!_isValidMiddleName) middleNameRegistrationTextBox.BackColor = Color.Red;
            if (!_isValidLogin)
                loginRegistratioinTextBox.BackColor = Color.Red;
            else
            {
                if (!_isUniqueLogin)
                {
                    loginRegistratioinTextBox.BackColor = Color.DarkRed;
                }

            }
            if (!_isValidEmail)
                emailRegistrationTextBox.BackColor = Color.Red;
            else
            {
                if (!_isUniqueEmail)
                {
                    emailRegistrationTextBox.BackColor=Color.DarkRed;
                }
            }
            if (!_isValidPhoneNumber)
                phoneRegistrationTextBox.BackColor = Color.Red;
            else
            {
                if (!_isUniquePhoneNumber)
                {
                    phoneRegistrationTextBox.BackColor = Color.DarkRed;
                }
            }
            if (!_isValidFirstPassword || passwordRegistrationRepeatTextBox.Text !=passwordRegistrationFirstTextBox.Text)
                passwordRegistrationFirstTextBox.BackColor = Color.Red;
            if (!_isValidRepeatPassword || passwordRegistrationRepeatTextBox.Text != passwordRegistrationFirstTextBox.Text)
                passwordRegistrationRepeatTextBox.BackColor = Color.Red;

        }
        private void ReturnFieldToCorrectState(Control element)
        {
            if (element.BackColor == Color.Red || element.BackColor == Color.DarkRed)
                element.BackColor = Color.White;
        }
    }
}
