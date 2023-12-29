using System;

namespace Kiwi_Bandicoot_CSharp_Number_Game
{
    class Program
    {
       
        static void Main(string[] args)
        { 
            double currentScore=0;
            do
            {
                
                Random rand = new Random();
                double num1 = 0;
                double num2 = 0;
                double result = 0;
                double random = rand.Next(1, 99);
                //random generate a number for random


                Console.WriteLine("\n\nKia Ora!");

                if (currentScore < 1)
                {
                    Console.WriteLine($"Current Score: {currentScore}");
                }
                else if (currentScore > 0){
                    Console.WriteLine($"Current Score: {currentScore}");
                }

                Console.WriteLine($"Create the Number {random} Using your calculator!");

                Console.Write("\nEnter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEnter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option -> (+) (-) (*) (/) ? ");
                Console.Write("Enter option: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"\n\nYour result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"\n\nYour result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"\n\nYour result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"\n\nYour result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("\n\nThat was not a valid option mate");
                        break;
                }
                if(random==result)
                {
                    Console.WriteLine("Good Job! Have a Point!");
                    currentScore++;
                }else
                {
                    Console.WriteLine("Maybe not your day! Points Back to Zero :(");
                    currentScore = 0;
                }
                Console.Write("\nContinue? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("\nChur!\nThanks for Playing!");
            Console.ReadKey();
        }
    }
}