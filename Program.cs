using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("f");

            var sum = 0;
            var totalSum = 0;

            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            transactions.Add(("Bones", 90, 12));
            transactions.Add(("Drugs", 700, 9));
            transactions.Add(("Helmet", 80, 3));
            transactions.Add(("Sandals", 20, 1));
            transactions.Add(("Chips", 700, 4));

            foreach ((string product, double amount, int quantity) t in transactions){
                // Logic goes here to look up quantity and amount in each transaction
                sum += t.quantity;
                totalSum += (int) t.amount * (int) t.quantity;
            }

            Console.WriteLine($"Items sold today {sum}");
            Console.WriteLine($"Total Revenue: {totalSum}");
            
        }
    }
}
