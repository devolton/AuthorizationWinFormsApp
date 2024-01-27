using System.Text.Json;

namespace RegistrationApp
{
    public partial class Form1 : Form
    {
        private AccountsDB _accountsDB;
        private FieldValidator _validator;
        private bool _isValidLogin = false;
        private bool _isValidPassword = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void noAccountLinkLabel_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void comeInButton_Click(object sender, EventArgs e)
        {
            if (!_isValidLogin)
            {
                loginInputTextBox.BackColor = Color.Red;
                MessageBox.Show("Invalid login");
            }
            if (!_isValidPassword)
            {
                passwordInputTextBox.BackColor = Color.Red;
                MessageBox.Show("Invalid password");
            }
            else
            {
                Account account = _accountsDB.GetFoundAccount(loginInputTextBox.Text);
                if (account is null)
                {
                    loginInputTextBox.BackColor = Color.Red;
                    MessageBox.Show("Incorrect login!");
                }
                else
                {
                    if (_accountsDB.IsAccountPasswordCorrect(account, passwordInputTextBox.Text))
                    {
                        var successForm= new SuccessRegistrationForm();
                        successForm.ShowDialog();
                       
                    }
                    else
                    {
                        passwordInputTextBox.BackColor = Color.Red;
                        MessageBox.Show("Incorrect password!");
                    }
                }
            }
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _validator = new FieldValidator();
            _accountsDB = AccountsDB.Instance();

        }



        private void passwordInputTextBox_TextChanged(object sender, EventArgs e)
        {
            _isValidPassword = _validator.IsValidPassword(passwordInputTextBox.Text);
            if (passwordInputTextBox.BackColor == Color.Red)
                passwordInputTextBox.BackColor = Color.White;
        }
        private void loginInputTextBox_TextChanged(object sender, EventArgs e)
        {
            _isValidLogin = _validator.IsValidLogin(loginInputTextBox.Text);
            if(loginInputTextBox.BackColor == Color.Red) loginInputTextBox.BackColor = Color.White;
        }
    }
}