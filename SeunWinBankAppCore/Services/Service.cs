using System;
using System.Collections.Generic;
using BC = BCrypt.Net.BCrypt;

namespace SeunWinBankAppCore
{
    
    public class Service : IService
    {
        private static IValidation _validation;
        public static IValidation Validation
        {
            get => _validation ??= new Validations();
        }

        public static SAccount account;
        public static User User;
        public static UserStore UserStore;
        public static STransaction transaction;
        public User CreateUser(string fullName, string password, string email )
        {
            User.Fullname = fullName;
            User.Password = password;
            User.Email = email;
            return User;
        }

        public List<User> LoginUser(string email, string password)
        {
            
            UserStore.ListOfUsers.ForEach(account =>
            {
                if (account.Email == email && _validation.VerifyPassword(password, account))
                {
                    UserStore.ListOfUsers.Add(account);
                }
            });

                return UserStore.ListOfUsers;
        }

        public string CreateAccountNumber()
        {
            Random rnd = new();
            long number = rnd.Next(1334567812, 1999999999);
            return number.ToString();
        }

        public SAccount GetAccount(string accountNumber)
        {
            SAccount result = null;   
            User.ListOfBankAccounts.ForEach(account =>
            {
                if (account.AccountNumber == accountNumber)
                {
                    result = account;
                }
            });
            return result;
        }
        public bool NewTransaction(decimal amount, string description, SAccount account)
        {
            if (account.AccountBalance <= 1000 && account.AccountType == "Saving" && amount < 0) return false;
            
            if (account.AccountBalance == 0 && amount < 0) return false;

            
            transaction.TransactionAmount = amount;
            transaction.TransactionDescription = description;
            transaction.TransactionDate = DateTime.Now.ToString();

            account.ListOfTransactions.Add(transaction);
            return true;
        }
    }
}
