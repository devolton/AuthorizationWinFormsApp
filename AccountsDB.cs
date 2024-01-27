using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RegistrationApp
{
    public class AccountsDB
    {
        private readonly string _filePath = "accounts.json";
        private List<Account> _accounts;
        private static AccountsDB _instance;
        private AccountsDB()
        {
            _accounts = GetAccountFromFile() ?? new List<Account>();
        }

        public static AccountsDB Instance() => _instance ??= new AccountsDB();
        public void AddNewAccount(Account account)
        {
            _accounts.Add(account);
            LoadToFile();
        }
        public string EncryptPassword(string password)
        {
            using var _sha256 = SHA256.Create();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashPasswordBytes = _sha256.ComputeHash(passwordBytes);
            _sha256.Dispose();
            return BitConverter.ToString(hashPasswordBytes);
        }
        public Account? GetFoundAccount(string login)
        {
            if (_accounts.Any(oneAccount => oneAccount.Login == login))
            {
                return _accounts.First(oneAccoutn => oneAccoutn.Login == login);
            }
            return null;
        }
        public bool IsAccountPasswordCorrect(Account account,string password)
        {
            return account.Password == EncryptPassword(password);
        }

        private List<Account>? GetAccountFromFile()
        {
            List<Account> accounts = null;
            if (File.Exists(_filePath))
            {
                using var sr = new StreamReader(_filePath);
                string accountsJson = sr.ReadToEnd();
                accounts = JsonSerializer.Deserialize<List<Account>>(accountsJson);
            }
            return accounts;

        }
        private void LoadToFile()
        {
            using var sw = new StreamWriter(_filePath, false);
            var jsonAccount = JsonSerializer.Serialize(_accounts);
            sw.WriteLine(jsonAccount);
            sw.Close();
        }
        public bool IsUniqueLogin(string newLogin)  => !_accounts.Any(oneAccount=> oneAccount.Login == newLogin);
        
        public  bool IsUniqueEmail(string newEmail)=>!_accounts.Any(oneAccount=>oneAccount.Email == newEmail);
        public bool IsUniquePhoneNumber(string phoneNumber)=>!_accounts.Any(oneAccount=>oneAccount.PhoneNumber == phoneNumber);

    }
}
