namespace ConsoleApp4
{
    internal class Program
    {

        public static string swapFirstAndLastCharacters(string input)
        {
            return input[input.Length-1]+input.Substring(1, input.Length - 2)+ input[0];
        }

        public static string addlastCharToFirstAndEnd(string input)
        {
            char lastChar = input[input.Length - 1];
            return   lastChar +  input + lastChar  ;
        }

        public static string stringWithoutOk(string input)
        {
            
            string ans = "";
           
            for (int i = 0; i<input.Length-1; i++)
            {
                if (input[i] == 'o' && input[i+1] == 'k' )
                {
                    i++;
                    continue;

                }
                ans += input[i];

            }
            char lastChar = input[input.Length - 1];

            //Check if the last two letters are "ok"
            if (input[input.Length - 2] == 'o' && lastChar  == 'k')
            {
                return ans;
            }


            return ans + lastChar;
            
            //return input.Replace("ok", "");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to swap the first and last letters");
            string input = Console.ReadLine();
            
            Console.WriteLine(Program.swapFirstAndLastCharacters(input));
            Console.WriteLine(Program.addlastCharToFirstAndEnd(input));
            Console.WriteLine(Program.stringWithoutOk(input));
        }
    }
}