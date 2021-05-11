using System;
using System.Collections.Generic;
using System.Text;

namespace BankReconciliationSystem.Domain.Enumerations
{
    public class TransactionType
    {
        public string Name { get; private set; }
        public decimal Id { get; private set; }
        public TransactionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static TransactionType Unknow => new TransactionType(0, nameof(Unknow));
        public static TransactionType Deposit => new TransactionType(1, nameof(Deposit));
        public static TransactionType Withdraw => new TransactionType(2, nameof(Withdraw));
    }
}
