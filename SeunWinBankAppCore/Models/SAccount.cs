using System;
using System.Collections.Generic;


namespace SeunWinBankAppCore
{
    public class SAccount
    {
        
        public string AccountType { get; set; }
        public string AccountNumber;
        public decimal AccountBalance {
            get
            {
                decimal Balance = 0;
                foreach (var transaction in ListOfTransactions)
                {
                    Balance += transaction.TransactionAmount;
                }
                return Balance;
            } 
        }

        public List<STransaction> ListOfTransactions;
        
    }
    
}
