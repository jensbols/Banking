using System;
using System.Collections.Generic;

namespace Banking.Models.Domein
{
    public class BankAccount
    {

        private readonly IList<Transaction> _transactions;
        //private readonly string _accountNumber;
        //private decimal _balance; //decimal is 10 delig tal stelsel. Er gebeuren geen afrondingen.
        //public const decimal WithdrawCost = 0.25M; //Zonder M wordt ervanuit gegaan dat het om een dubbel te gaan. De M staat voor dubbel.

        #region Properties
        public decimal Balance { get; private set; } //meest efficiente manier. oproepen door "prop" dubbel tab.

        public string AccountNumber { get; }

        public int NumberOfTransactions { get { return _transactions.Count; } }
        #endregion

        /* public decimal Balance
         {
             get { return _balance; }
             set { _balance = value; }
         }*/

        #region Constructor
        public BankAccount(string accountNumber) //ctor shortcut
        {
            AccountNumber = accountNumber;
            _transactions = new List<Transaction>();
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount) //optionele parameter moet een default waarde meekrijgen. vb "string transactionName = "deposit"
        {
            Balance += amount;
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
        }

        public IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till) //? is nullable alle transactions tot bepaalde datum.
        {
            throw new NotImplementedException(); //opdracht: alle transacties weergeven tussen de parameters.
        }
        #endregion







    }
}
