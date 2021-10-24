using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BankAccount<int> bankAccount = new BankAccount<int>();
            bankAccount.Info(12, 50000, "FirstName");
            bankAccount.InfoOutput();
            BankAccount<string> bankAccount1 = new BankAccount<string>();
            bankAccount1.Info("13", 60000, "SecondName");
            bankAccount1.InfoOutput();
            Console.ReadKey();
        }
    }
    class BankAccount<T>
    {
        private T Number { get; set; }
        private int Balance { get; set; }
        private string Name { get; set; }
        public void Info(T number, int balance, string name)
        {
            Number = number;
            Balance = balance;
            Name = name;
        }
        public void InfoOutput()
        {
            Console.WriteLine($"Номер счета - {Number}. Баланс равен {Balance}. Принадлежит - {Name}.");
        }
    }
}
