namespace OverTimePay
{
    public class Program
    {
        public static double OverTime(double[] arr)
        {
            double startTime = arr[0];
            double endTime = arr[1];
            double hourlyRate = arr[2];
            double overTimeMultiplier = arr[3];
            double totalAmount = 0;

            if (endTime > 17)
            {
                //Overtime
                double overTime = endTime - 17;
                totalAmount = (overTime * hourlyRate * overTimeMultiplier) + ((17 - startTime) * hourlyRate);


            }
            else
            {
                //Normal time
                totalAmount =  ((endTime - startTime) * hourlyRate);
            }

            return totalAmount;
        }
        public static void Main(string[] args)
        {
            double[] arr = { 13.25, 15, 30, 1.5 };
            Console.WriteLine(Math.Round(OverTime(arr),2));
            
        }
    }
}