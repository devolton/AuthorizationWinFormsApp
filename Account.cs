using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RegistrationApp
{
    public class Account
    {
        [JsonPropertyName("Login")]
        public string Login {  get; set; }
        [JsonPropertyName("FirstName")]
        public string FirstName {  get; set; }
        [JsonPropertyName("LastName")]
        public string LastName {  get; set; }
        [JsonPropertyName("MiddleName")]
        public string MiddleName {  get; set; }
        [JsonPropertyName("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonPropertyName("Email")]
        public string Email { get; set; }
        [JsonPropertyName("Password")]
        public string Password  { get; set; } 
       
    }
}
