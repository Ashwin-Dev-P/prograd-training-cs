namespace ConsoleApp3
{
    internal class Program
    {
        static int total_bullets = 100;
        static int hero_bullets = 0;
        static int villian_bullets = 0;

        static void Main(string[] args)
        {

            int round = 1;
            while (Program.total_bullets > 0 )
            {
                Program.hero_bullets++;
                Program.villian_bullets += 3;

                Console.WriteLine("Round " + round);
                Console.WriteLine("---------");
                Console.WriteLine("Total bullets left: " + total_bullets);
                Console.WriteLine("------------------------");
                Console.WriteLine("Hero: "+Program.hero_bullets+ "  || Villian: " + Program.villian_bullets);

                Program.total_bullets -= 4;
                ++round;
                Console.WriteLine("=================================");
            }
            Console.WriteLine("No more bullets left");
           
        }
    }
}