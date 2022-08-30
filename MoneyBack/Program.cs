using System;
using System.Collections.Generic;

namespace MoneyBack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> coins = BinarySearch.Program.SortArray(new() { 1000, 50, 100, 200, 500, 1000, 50, 50 });
            int returned = 750;

            int count = CountCoins(coins, returned);

            Console.WriteLine(String.Format("\nSe usaron {0} monedas para llegar a ${1}", count, returned));
            Console.ReadLine();
        }
        

        static int CountCoins(List<int> coins, int returned) {

            int residue = returned;
            int coinsCount = 0;

            foreach (int coin in coins)
            {
                if (coin <= residue) {
                    Console.WriteLine(String.Format("Moneda de ${0} utilizada", coin));
                    residue -= coin;
                    coinsCount++;
                
                }

                if (residue == 0) {
                    break;
                }

            }

            return coinsCount;
        
        }
    }
}
