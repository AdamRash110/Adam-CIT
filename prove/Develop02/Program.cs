using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        string choice = "0";
        Journal journal = new Journal();
        Promptgenerator promptgenerate = new Promptgenerator();
        Console.WriteLine("Welcome to your own choice of your journal! Please consider the next steps to insure true happiness with this program!");

        while (choice != "5") {
            Console.WriteLine("Please select a choice below to go to the next step\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat choice do you want?");
            choice = Console.ReadLine();
            if (choice == "1") {
                string prompt = promptgenerate.GetPrompt();
                Console.WriteLine(prompt);
                string WhatTheyEnter = Console.ReadLine();
                journal.CreateEntry(prompt, WhatTheyEnter);
            }

            else if (choice == "2") {
                journal.Display();
            }

            else if (choice == "3") {
                Console.WriteLine("What journal file do you want do pull open?");
                string openName = Console.ReadLine();
                journal.Load(openName);
            }

            else if (choice == "4") {
                Console.WriteLine("Where on your computer do you want this journal to be for the time being? ");
                string openName = Console.ReadLine();
            }

            else if (choice == "5") {
                break;
            }
        }
    }
}