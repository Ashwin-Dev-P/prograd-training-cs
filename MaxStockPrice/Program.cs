namespace MaxStockPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            int overall_max_profit = 0;

            for(int i = 0;i< prices.Length - 1; i++)
            {
                int max_profit_for_current_stock = 0;
                for(int j= i + 1; j < prices.Length; j++)
                {
                    int current_profit = prices[j] - prices[i];

                    if (current_profit > max_profit_for_current_stock)
                    {
                        max_profit_for_current_stock = current_profit;

                    }
                }

                if (max_profit_for_current_stock > overall_max_profit)
                {
                    overall_max_profit = max_profit_for_current_stock;
                }

            }
            Console.WriteLine(overall_max_profit);
        }
    }
}