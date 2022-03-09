using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeunWinBankAppCore
{
    public interface IService
    {
        User CreateUser(string fullName, string password, string email);
        List<User> LoginUser(string email, string password);
        string CreateAccountNumber();
        SAccount CreateAccount(string accountType);
        //SAccount GetAccount(string accountNumber);
        bool NewTransaction(decimal amount, string description, SAccount account);
    }
}