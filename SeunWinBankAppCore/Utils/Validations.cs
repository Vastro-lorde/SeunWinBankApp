using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using BC = BCrypt.Net.BCrypt;

namespace SeunWinBankAppCore.Utils
{
    public static class Validations
    {
            public static bool CheckPasswordInput(string password)
            {
                if (password == null) return false;
                /*This regex checks to make sure the password contains Minimum six characters, at least one uppercase letter, one lowercase letter, one number and one special character:*/
                Regex passwordKey = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$");
                return passwordKey.IsMatch(password)? true: false;
        }
            public static bool VerifyPassword(string password, User account)
            {
                if (account == null || password == null) return false;
                return BC.Verify(password, account.Password);
            }

            public static bool EqualPassword(string password, User account)
            {
                if (account == null || password == null) return false;
                return BC.Equals(password, account.Password);
            }

            public static bool VerifyEmail(string email)
            {
                if (email == null) return false;
                /*regular expression for Identifying email using RFC 5322 format if we omit IP addresses, domain-specific addresses.*/
                Regex emailFormat = new Regex(@"\A[a-zA-Z0-9]+(?:\.[a-z0-9!#$%&'*+/=?^_‘{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\z");

                if (emailFormat.IsMatch(email)) return true;

                return false;
            }

            public static bool VerifyAmountInputType(string amount)
            {
                bool success = decimal.TryParse(amount, out _);
                return success? true: false;

            }
            public static bool VerifyNumberInputType(string choice)
            {
                bool success = int.TryParse(choice, out _);
                return success ? true : false;
                }
        }
}
