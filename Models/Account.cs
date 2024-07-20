using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPOC.Models
{
    internal class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account()
        {
            Console.WriteLine("constructor default");
        }
        public Account(int id, string name, double balance)
        {
            Id = id; 
            Name = name; 
            Balance = balance;
        }

        public string ShowInfo()
        {
            return $"ID: {Id}" +
                $"Name: {Name}" +
                $"Balance: {Balance}";
        }
        public string CheckBalance(Account acc)
        {
            if (acc.Balance > 500)
                return "Has more than min balance \n";
            else
                return "Doesnt hve min balance";
        }
    }
}
