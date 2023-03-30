namespace SpecialCalculator
{
    internal class Program
    {
        private static int Addition(int a, int b)
        {
            return a + b;
        }

        private static int Addition(int a, int b, int c)
        {
            return a + b + c;
        }



        private static int Subtraction(int a , int b)
        {
            return a - b;
        }

        private static int Subtraction(int a, int b, int c)
        {
            return a - b - c;
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Select the role of calculator you want:");
            Console.WriteLine("1)Normal\n2)Opposite");
            int role = Convert.ToInt32(Console.ReadLine());
           
            

            
            while (true)
            {
                Console.WriteLine("\nSelect the operation");
                Console.WriteLine("1)Addition\n2)Subtraction");
                int operation = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nSelect the number of inputs: \n1) 2 \n2) 3");
                int noOfParamaters = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter the value of a:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter the value of b:");
                int b = Convert.ToInt32(Console.ReadLine());

                int c = 0;
                if (noOfParamaters == 3)
                {
                    Console.WriteLine("\nEnter the value of c:");
                    c = Convert.ToInt32(Console.ReadLine());

                }

                //Normal
                if (role == 1)
                {
                    //addition
                    if (operation == 1)
                    {

                        if (noOfParamaters == 3)
                        {
                            Console.WriteLine(Addition(a,b,c));

                        }
                        else
                        {
                            Console.WriteLine(Addition(a, b));
                        }

                    }
                    else
                    {
                        //subtraction
                        if (noOfParamaters == 3)
                        {
                            Console.WriteLine(Subtraction(a, b, c));

                        }
                        else
                        {
                            Console.WriteLine(Subtraction(a, b));
                        }
                    }

                }
                else
                {
                    //subtraction
                    if (operation == 2)
                    {

                        if (noOfParamaters == 3)
                        {
                            Console.WriteLine(Addition(a, b, c));

                        }
                        else
                        {
                            Console.WriteLine(Addition(a, b));
                        }

                    }
                    else
                    {
                        //addition
                        if (noOfParamaters == 3)
                        {
                            Console.WriteLine(Subtraction(a, b, c));

                        }
                        else
                        {
                            Console.WriteLine(Subtraction(a, b));
                        }
                    }
                }
            }
            

        }
    }
}