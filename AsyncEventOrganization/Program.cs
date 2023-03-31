namespace AsyncEventOrganization
{
    internal class Program
    {
        public static async Task<int> transportService()
        {
            await Task.Delay(2000);
            Console.WriteLine("Delivering food to the catering service");
            return 0;
        }

        public static async Task<int> stageDecoration()
        {
            await Task.Delay(1000);
            Console.WriteLine("Stage decoration");
            return 0;
        }
        public static async Task<int> cateringService()
        {
            await Task.WhenAll(transportService(),chiefGuest(), transportPrizes(), stageDecoration());
            
            Console.WriteLine("Starts preparing food");

            
            Console.WriteLine("Food is provided to all participants");
            Console.WriteLine("Prize distribution");
            return 0;
        }

        public static async Task<int> chiefGuestPA()
        {
            Console.WriteLine("Chief guest speech reviewed by PA");
            await Task.Delay(1000);
            return 0;
        }

        public static async Task<int> chiefGuest()
        {
            Console.WriteLine("Chief guest picked from Airport");
            await Task.Delay(3000);
            await chiefGuestPA();
            Console.WriteLine("Security check");
            await Task.Delay(2000);
            Console.WriteLine("Chief guest speech");
            await Task.Delay(1000);
            return 0;
        }

        public static async Task<int> transportPrizes()
        {
            await Task.Delay(2000);
            Console.WriteLine("Prizes are transported to the venue");
            return 0;
        }

        public static async Task<int> eventOrganistaion (){
            cateringService();

          
            return 0;
            
        }


        static  void Main(string[] args)
        {
             eventOrganistaion();
            
            Console.ReadLine();
            
        }
    }
}