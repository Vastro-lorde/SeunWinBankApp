using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeunWinBankAppCore
{
    public interface IValidation
    {
        bool CheckPasswordInput(string password);
        bool VerifyPassword(string password, User account);
        bool EqualPassword(string password, User account);
        bool VerifyEmail(string email);
        bool VerifyAmountInputType(string amount);
        bool VerifyNumberInputType(string choice);
    }
}
