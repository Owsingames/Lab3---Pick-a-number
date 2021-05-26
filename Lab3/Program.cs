using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Grand Circus - Lab 3
            //Pick a number / Number Analyzer            

            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Clear();

            bool goAgain = true;
            while (goAgain == true)
            {
                Console.WriteLine("Hello {0}, please pick a lucky number between 1 an 100", userName);
                int userNum = int.Parse(Console.ReadLine());

                if (userNum == 1)
                {
                    Console.WriteLine("1, is the loneliest number...");
                    goAgain = OnContinue();
                }
                else if (userNum >= 2 && userNum <= 25)
                {
                    if(userNum % 2 == 0)
                    {
                        Console.WriteLine("Thats a prety low number " + userName);
                        Console.WriteLine("your number is EVEN and less then 25 \n");
                        goAgain = OnContinue();
                    }
                    else
                    {
                        Console.WriteLine("{0}, the number is {1} and Odd \n", userName, userNum);
                        goAgain = OnContinue();
                    }
                }
                else if (userNum >= 26 && userNum <= 60)
                {
                    if(userNum % 2 == 0)
                    {
                        Console.WriteLine("Even!!");
                        Console.WriteLine("Lucky number: " + userNum);
                        goAgain = OnContinue();
                    }
                    else
                    {
                        Console.WriteLine("Odd...");
                        Console.WriteLine("Lucky number: " + userNum);
                        goAgain = OnContinue();
                    }
                }
                else if(userNum >= 61 && userNum <= 100)
                {
                    if(userNum % 2 == 0)
                    {
                        Console.WriteLine("Now {0}, Thats a big number...", userName);
                        Console.WriteLine("the number is: {0}, it is even", userNum);
                        goAgain = OnContinue();
                    }
                    else
                    {
                        Console.WriteLine("{0}, the number is: {1}, it is odd", userName, userNum);
                        goAgain = OnContinue();
                    }
                }
                //validate user data, must be between 1 an 100
                else if(userNum <= 0 || userNum > 101)
                {
                    Console.Clear();
                    Console.WriteLine("That number is not between 1 and 100...");
                    Console.WriteLine("{0}, please enter a number between 1 and 100 \n", userName);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid number between 1 an 100 \n");
                }
            }
        }

        //ask user to continue picking a number
        public static bool OnContinue()
        {
            Console.WriteLine("Would you like to pick another number?");
            string answer = Console.ReadLine().ToLower();

            if(answer == "y" || answer == "yes")
            {
                Console.Clear();
                return true;
            }
            else if(answer == "n" || answer == "no")
            {
                Console.WriteLine("Goodbye.");
                return false;
            }
            else
            {
                Console.WriteLine("Please enter yes or no");
                return OnContinue();
            }
        }
    }
}
