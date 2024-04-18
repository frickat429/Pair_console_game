using System;

namespace ConsoleApp
{
    class MadlibStory 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Madlib Story Generator!");

            Console.Write("Enter a protagonist's name: ");
            string protaganistName = Console.ReadLine(); 

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
            System.Console.WriteLine($"Title: 'The Mysterious Adventure of {protaganistName} and the {adjective1} {noun1}'");
            //System.Console.WriteLine($“Title: \“The Mysterious Adventure of {protagonistName} and the {adjective1} {noun1}\“”);
            System.Console.WriteLine();
            System.Console.WriteLine($"In a {adjective1} {location}, {protaganistName} stumbled upon a(n) {noun1} that seemed to {actionVerb} with an eerie glow. "+
                $"Curiosity getting the best of {protaganistName}, {protaganistName} decided to {actionVerb} it. Suddenly, {unexpected} happened, transporting {protaganistName} to a fantastical realm filled with {pluralNoun}. "+
                $"Now, {protaganistName} must navigate this strange land, facing {adjective2} challenges and encountering peculiar creatures, all in search of a way back home. "+
                $"But little does {protaganistName} know, there’s a {noun2} lurking in the shadows, watching {protaganistName} every move, with intentions that could change {protaganistName}’s fate forever."); 
  

            Console.ReadLine();
        }
    }
}