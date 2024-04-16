using System;

class MadlibStory {
    static void Main(string[] args) {
        Console.WriteLine("Welcome to Madlib Story Generator!");

        Console.Write("Enter a protagonist's name: ");
        string protaganistsName = Console.ReadLine(); 

        Console.Write("Enter an adjective: ");
        string adjective1 = Console.ReadLine(); 

        Console.Write("Enter a location: ");
        string location = Console.ReadLine();

        Console.Write("Enter a noun: ");
        string noun1 = Console.ReadLine(); 

        Console.Write("Enter a verb: ");
        string actionVerb = Console.ReadLine();

        Console.Write("Enter something unexpected: ");
        string unexpected = Console.ReadLine();

        Console.Write("Enter a plural noun: ");
        string pluralNoun = Console.ReadLine();

        Console.Write("Enter an adjective: ");
        string adjective2 = Console.ReadLine();

        Console.Write("Enter a noun: ");
        string noun2 = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($“Title: \“The Mysterious Adventure of {protagonistName} and the {adjective1} {noun1}\“”);
        Console.WriteLine();
        Console.WriteLine($“In a {adjective1} {location}, {protagonistName} stumbled upon a(n) {noun1} that seemed to {verb} with an eerie glow. 
        Curiosity getting the best of {protagonistName}, {protagonistName} decided to {actionVerb} it. Suddenly, {unexpected} happened, transporting {protagonistName} to a fantastical realm filled with {pluralNoun}.
         Now, {protagonistName} must navigate this strange land, facing {adjective2} challenges and encountering peculiar creatures, all in search of a way back home. But little does {protagonistName} know, there’s a {noun2} lurking in the shadows, watching {protagonistName} every move, with intentions that could change {protagonistName}’s fate forever.“);

        Console.ReadLine();

    }
}