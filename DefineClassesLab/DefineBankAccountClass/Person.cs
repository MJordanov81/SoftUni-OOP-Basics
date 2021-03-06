﻿using System.Collections.Generic;
using System.Linq;

    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public List<BankAccount> Accounts
        {
            get { return this.accounts; }
            set { this.accounts = value; }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = new List<BankAccount>();

        }

        public Person(string name, int age, List<BankAccount> accounts)
            : this(name, age)
        {

            this.Accounts = accounts;
        }

        public double GetBalance()
        {
            return this.accounts.Select(x => x.Balance).Sum();
        }
    }
