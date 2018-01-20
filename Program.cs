using System;
using System.Collections.Generic;


namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");

            //Create a list of value tuples that will hold individual transactions for a hardware business. Each tuple should store the product, total amount of transaction, and quantity of the product.

            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            transactions.Add(("Hammer", 10.00, 2));
            transactions.Add(("Nails", 5.00, 100));
            transactions.Add(("Carpet",100.00 ,1 ));
            transactions.Add(("Paint", 25.00, 1));
            transactions.Add(("Marble Tile", 1000.00, 60));

            //Iterate over the list of tuples and calculate how many total products you sold today, and what your total revenue was

            double sum = 0;
            int count = 0;

            foreach ((string product, double amount, int quantity) t in transactions){
              sum += t.Item2;
              count += t.Item3;
            }
            Console.WriteLine ("Items Sold Today:" + count);
            Console.WriteLine("Total Revenue:" + sum);

        }
    }
}
