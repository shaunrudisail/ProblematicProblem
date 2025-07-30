using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem;

internal class Program
{
    private static Random rng;
    private static bool cont = true;

    private static readonly List<string> activities = new()
        { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Write(
                "Hello, welcome to the random activity generator! Would you like to generate a random activity? yes/no: ");
            var userInput1 = Console.ReadLine();
            var cont2 = true;

            while (true)
            {
                if (userInput1 == "Yes".ToLower()) { Console.WriteLine("Excellent!");}

                else if (userInput1 == "No".ToLower())
                {
                    Console.WriteLine("Okay! Goodbye!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Oops! Try again.");
                    Environment.Exit(0);
                }

                break;
            }
            

            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            var userName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("What is your age? ");
            var userAge = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? yes/no: ");
            var userInput2 = Console.ReadLine();

            while (true)
            {
                if (userInput2 == "Yes".ToLower())
                {
                    Console.WriteLine("Here is the list!");
                    Console.WriteLine();
                    foreach (var activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                    Console.WriteLine();
                }

                else if (userInput2 == "No".ToLower())
                {
                    Console.WriteLine("Okay!");
                }
                else
                {
                    Console.WriteLine("Oops! Try again.");
                    Environment.Exit(0);
                }

                break;
            }

            Console.WriteLine();
            Console.Write("Would you like to add any activities before we generate one? yes/no: ");
            var userInput3 = Console.ReadLine();
            Console.WriteLine();

            while (true)
            {
                if (userInput3 == "Yes".ToLower())
                {
                    Console.Write("What would you like to add? ");
                    var userAddition = Console.ReadLine();
                    activities.Add(userAddition);
                    Console.WriteLine();
                }

                else if (userInput3 == "No".ToLower())
                {
                    Console.WriteLine("Okay!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Oops! Try again.");
                    Environment.Exit(0);
                }

                break;
            }

            var addToList2 = true;

            foreach (var activity in activities)
            {
                Console.Write($"{activity} ");
                Thread.Sleep(250);
            }

            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Would you like to add more? yes/no: ");
            var userInput4 = Console.ReadLine();
            Console.WriteLine();

            while (true)
            {
                if (userInput4 == "Yes".ToLower())
                {
                    Console.Write("What would you like to add? ");
                    var userInputAns = Console.ReadLine();
                    activities.Add(userInputAns);
                }
                else if (userInput4 == "No".ToLower())
                {
                    Console.WriteLine("Okay!");
                }
                else
                {
                    Console.WriteLine("Oops! Try again.");
                    Environment.Exit(0);
                }

                break;
            }

            Console.WriteLine();

            while (cont2)
            {
                Console.Write("Connecting to the database");
                for (var i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                Console.Write("Choosing your random activity");
                for (var i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                int intAge = int.Parse(userAge);
                
                do
                {
                    Random rng = new Random();
                    var randNum = rng.Next(activities.Count);
                    var randAct = activities[randNum];
                    
                    if (intAge <= 21 && randAct == "Wine Tasting")
                    {
                        Console.WriteLine($"Oh no! Looks like you are too young to do {randAct}!");
                        Console.WriteLine("Pick something else!");
                        activities.Remove(randAct);
                        var randomNumber = rng.Next(activities.Count);
                        randAct = activities[randomNumber];
                    }


                    Console.Write(
                        $"Ah got it! {userName}, your random activity is: {randAct}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                    Console.WriteLine();
                    var userInput = Console.ReadLine();

                    if (userInput == "Keep" || userInput == "keep")
                    {
                        Console.WriteLine("Very well then! See you next time!");
                        Environment.Exit(0);
                    }

                    else if (userInput == "Redo" || userInput == "redo")
                    {
                        Console.WriteLine("Okay!");
                    }
                    else
                    {
                        Console.WriteLine("Oops! Try again.");
                        Environment.Exit(0);
                    }
                } while (true);
            }
        }
    }
}