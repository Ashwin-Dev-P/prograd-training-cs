namespace ConsoleApp8
{
    internal class Program
    {

        public static void PrintAns( int[,] a)
        {
            //m is row, n is column
            int m = 3, n = 3;

            int i, k = 0, l = 0;
            while (k < m && l < n)
            {

                //Print the top row
                for (i = l; i < n; ++i)
                {
                    Console.Write(a[k, i] + " ");
                }

                //Print the right column
                k++;
                for (i = k; i < m; ++i)
                {
                    Console.Write(a[i, n - 1] + " ");
                }

                //Print the below 
                n--;
                if (k < m)
                {
                    for (i = n - 1; i >= l; --i)
                    {
                        Console.Write(a[m - 1, i] + " ");
                    }
                    m--;
                }

                //Print the left
                if (l < n)
                {
                    for (i = m - 1; i >= k; --i)
                    {
                        Console.Write(a[i, l] + " ");
                    }
                    l++;
                }
            }
        }
        static void Main(string[] args)
        {

            int[,] matrix = { { 1, 2, 3 },
            { 7, 8, 9 },
            { 13, 14, 15 } };

            PrintAns(matrix);
            

            /*
            Console.WriteLine("Enter the value of n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n);
            

            
            int count = 1;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    //Console.Write(i + " " + j + "\n");
                    if (i == 0)
                    {
                        Console.Write(count + " ");
                    }
                    ++count;
                }
                Console.WriteLine();

            }
            */


        }
    }
}