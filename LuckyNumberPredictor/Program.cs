namespace LuckyNumberPredictor
{

    // Abstract class
    public abstract class NumberPredictor
    {
        

        public abstract int getLuckyNumber(int date, int month, int year);
        

        public abstract int getUnluckyNumber(int date, int month, int year);
        
    }

     class NumberPredictorImplemetationClass: NumberPredictor
    {
        public static int date;
        public static int month;
        public static int year;
        public static int nearestFibonacci(int num)
        {

            // Base Case
            if (num == 0)
            {

                return 0;
            }

            // Initialize the first & second
            // terms of the Fibonacci series
            int first = 0, second = 1;

            // Store the third term
            int third = first + second;

            // Iterate until the third term
            // is less than or equal to num
            while (third <= num)
            {

                // Update the first
                first = second;

                // Update the second
                second = third;

                // Update the third
                third = first + second;
            }

            // Store the Fibonacci number
            // having smaller difference with N
            int ans = (Math.Abs(third - num) >=
                      Math.Abs(second - num)) ?
                               second : third;

            return ans;
        }


        public override int getLuckyNumber(int date, int month, int year)
        {
            return nearestFibonacci(date);
        }

        public override int getUnluckyNumber(int date, int month, int year)
        {
            NumberPredictorImplemetationClass.date = date;
            NumberPredictorImplemetationClass.month = month;
            NumberPredictorImplemetationClass.year = year;
            return 0;
        }
    }

    internal class Program: NumberPredictorImplemetationClass


    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to lucky number predictor. \n\nEnter your date of birth to calculate the lucky number");

            Console.WriteLine("Enter your date:");
            int date  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your month:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your year:");
            int year = Convert.ToInt32(Console.ReadLine());


            Program p = new Program();
            Console.WriteLine($"\nYour lucky number is {p.getLuckyNumber(date, month, year)}");
            p.getUnluckyNumber(date, month, year);

        }
    }
}