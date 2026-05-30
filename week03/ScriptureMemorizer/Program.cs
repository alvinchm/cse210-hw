using System;
using System.Collections.Generic;

// 1. I added a library of scriptures. The program randomly selects one scripture 
//    from a predefined list each time it is run, rather than using the same one.
// 2. I improved the random hiding logic so it only selects words that are not 
//    already hidden, preventing the program from inefficiently picking hidden words.

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Nephi", 1, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Scripture(new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble."),
            new Scripture(new Reference("Moroni", 10, 4, 5), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true.")
        };


        Random random = new Random();
        int index = random.Next(scriptureLibrary.Count);
        Scripture selectedScripture = scriptureLibrary[index];

        string userInput = "";

        while (userInput != "quit" && !selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            userInput = Console.ReadLine().ToLower();

            if (userInput != "quit")
            {

                selectedScripture.HideRandomWords(3);
            }
        }


        if (selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("You memorized it!");
        }
    }
}