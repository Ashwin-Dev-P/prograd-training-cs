namespace LicensePlate
{
    /*
     Time complexity: O(n)
     */
    internal class Program
    {
        //Method to convert dmvNumber to LicensePlate number
        private static string LicensePlate(string dmvNumber, int length)
        {
            string plateNumber = "";
            int plateNumberLength = 0;

            //iterate the dmvnumber in reverse since the license plate needs to be reversed
            for (int i=dmvNumber.Length-1;i>-1;i--)
            {
                if (dmvNumber[i] != '-')
                {
                    //Convert the character to upper case and add it to the license plate number
                    plateNumber = Char.ToUpper(dmvNumber[i]) + plateNumber;
                    ++plateNumberLength;

                    //To check and add '-' at necessary places i.e the 'length'
                    if (plateNumberLength % length == 0 && i != 0)
                    {
                        plateNumber = '-' + plateNumber;
                    }
                }
            }

            return plateNumber;
        }
       
        static void Main(string[] args)
        {
            //Function call
            Console.WriteLine(LicensePlate("nlj-206-fv", 3));
        }
    }
}