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
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to swap the first and last letters");
            string input = Console.ReadLine();
            
            Console.WriteLine(Program.swapFirstAndLastCharacters(input));
            Console.WriteLine(Program.addlastCharToFirstAndEnd(input));
        }
    }
}