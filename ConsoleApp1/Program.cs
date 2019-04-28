using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Random rng = new Random();
            int d1 = rng.Next(1, 7);
            int d2 = rng.Next(1, 7);
            int d3 = rng.Next(1, 7);
            int d4 = rng.Next(1, 7);
            int d5 = rng.Next(1, 7);

            string ans1;
            int ans2;

            int i = 0;

            List<int> KeepD = new List<int>();

            //Beginning
            Console.WriteLine("Welcome To A Game Of Yahtzee!!");
            Console.WriteLine("Press the <ANY> key to begin");
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            // RULES 
            Console.WriteLine("----------- Rules -----------");
            Console.WriteLine("1. Start rolling all 5 dice ");
            Console.WriteLine("2. Keep the dice that want ");
            Console.WriteLine("3. Re-roll up to 3 times");
            Console.WriteLine("4. Score the dice based on category");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Press the <ANY> key to roll dice");
            Console.WriteLine(" ");
            Console.WriteLine("         " + "d1 " + "d2 " +"d3 " + "d4 " + "d5 ");
            Console.WriteLine("         " + d1 + "  " + d2 + "  " + d3 + "  " + d4 + "  " + d5 + "  ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            // Man kan gemme op til 5 terninger
            while (i <= 5){
                Console.Write("Do you want to store any of the dice? (y/n)");
                ans1 = Console.ReadLine();

                if (ans1 == "n")
                {
                    i = 5;
                    Console.WriteLine("Turn is over");
                }

                else if (ans1 == "y")
                {
                    Console.Write("Which dice do you want? (1,2,3,4,5)");
                    ans1 = Console.ReadLine();
                    ans2 = Convert.ToInt32(ans1);


                    switch (ans2)
                    {
                        case 1:
                            Console.WriteLine("d" + ans2 + " was stored: " + d1);
                            KeepD.Add(d1);
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            break;
                        case 2:
                            Console.WriteLine("d" + ans2 + " was stored: " + d2);
                            KeepD.Add(d2);
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            break;
                        case 3:
                            Console.WriteLine("d" + ans2 + " was stored: " + d3);
                            KeepD.Add(d3);
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            break;
                        case 4:
                            Console.WriteLine("d" + ans2 + " was stored: " + d4);
                            KeepD.Add(d4);
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            break;
                        case 5:
                            Console.WriteLine("d" + ans2 + " was stored: " + d5);
                            KeepD.Add(d5);
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            break;
                    }

                    Console.Write("Do you want to store any more? (y/n)");
                    ans1 = Console.ReadLine();

                    if (ans1 == "n")
                        i = 5;
                }

                else
                {
                    Console.ReadKey();
                }

                i = 1 + i;
            }

            // SLUT på runden
            Console.WriteLine("----------- END OF TURN -----------");
            Console.WriteLine("You stored:");

            foreach (int prime in KeepD)
            {
                Console.WriteLine(prime);
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.ReadKey();
        }
    }
}
