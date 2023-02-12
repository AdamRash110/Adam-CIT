using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello everybody! I hope that this code brings you joy with scriptures and their memorization!");

        Reference scriptureReference = new Reference("Romans", "8", "38-39");
        Scripture scripture = new Scripture(scriptureReference, "For I am convinced that neither death nor life, neither angels nor demons, neither the present nor the future, nor any powers, neither height nor depth, nor anything else in all creation, will be able to seperate us from the love of God that is in Christ Jesus our Lord.");

        Memorizer scriptureMemorizer = new ScriptureMemorizer(scripture);
        string Input = "";
        while(Input != "quit");
        {
            Console.WriteLine();
            Console.WriteLine("Type quit if you would like to leave the Scripture Memorizer.");
            Input = Console.ReadLine();
            if(scriptureMemorizer.haswords() == true)
            {
                scriptureMemorizer.removewords();
            }
        }
    }
}