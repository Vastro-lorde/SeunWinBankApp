using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeunWinBankAppCore
{
    public class User
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<SAccount> ListOfBankAccounts;
    }
}
