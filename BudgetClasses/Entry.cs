using System;
using System.Collections.Generic;
using System.Linq;


namespace BudgetClasses
{
    // A zero-sum list of withdrawals or deposits to various accounts, 
    // and the associated import data.
    class Transaction
    {
        DateTime Time;

        Entry[]  Entries;

        string Description;
        string[] Tags;

        string ImportData;
    }

    // Entry
    class Entry
    {
        Money Value;
        string Account;
        string Allocation;
    }

    // A sum of money and currency
    class Money
    {
        long         Cents;
        CurrencyType Currency;

    }

}
