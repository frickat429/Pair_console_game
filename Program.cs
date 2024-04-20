using System;

namespace ConsoleApp
{
    class MadlibStory 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Frick'n Sam Madlib Story Creator!");

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

            Console.Write("Enter something unexpected (leave blank for a random event): ");
            string unexpected = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(unexpected))
            {
                unexpected = UnexpectedEventGenerator.GenerateUnexpectedEvent();
            }

            Console.Write("Enter a plural noun: ");
            string pluralNoun = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            string adjective2 = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string noun2 = Console.ReadLine();
            
            Console.WriteLine();
            System.Console.WriteLine($"Title: 'The Mysterious Adventure of {protaganistName} and the {adjective1} {noun1}'");
            System.Console.WriteLine();
            System.Console.WriteLine($"In a {adjective1} {location}, {protaganistName} stumbled upon a(n) {noun1} that seemed to {actionVerb} with an eerie glow. "+
                $"Curiosity getting the best of {protaganistName}, {protaganistName} decided to {actionVerb} it. Suddenly, {unexpected} happened, transporting {protaganistName} to a fantastical realm filled with {pluralNoun}. "+
                $"Now, {protaganistName} must navigate this strange land, facing {adjective2} challenges and encountering peculiar creatures, all in search of a way back home. "+
                $"But little does {protaganistName} know, there’s a {noun2} lurking in the shadows, watching {protaganistName} every move, with intentions that could change {protaganistName}’s fate forever."); 
  
            Console.WriteLine() ;
            System.Console.WriteLine("Thank you for playing, press enter to exit");
            Console.ReadLine();
        }
    }

    static class UnexpectedEventGenerator
    {
        private static readonly string[] UnexpectedEvents = {
            "A sudden thunderstorm appeared out of nowhere.",
            "A mysterious figure appeared and offered a cryptic message.",
            "The ground trembled beneath their feet.",
            "A portal opened up, sucking them into another dimension.",
            "They stumbled upon an ancient artifact emitting a strange energy.",
            "A flock of birds flew overhead, forming peculiar shapes in the sky.",
            "A shooting star streaked across the sky, granting a wish upon seeing it.",
            "A loud roar echoed through the area, sending shivers down their spine."
        };

        public static string GenerateUnexpectedEvent()
        {
            Random rand = new Random();
            int index = rand.Next(UnexpectedEvents.Length);
            return UnexpectedEvents[index];
        }
    }
}