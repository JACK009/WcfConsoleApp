using ConsoleApp.AuthorServiceReference;
using System;

namespace ConsoleApp.Helpers
{
    public class TextHelper
    {
        public void AuthorLine(Author author)
        {
            Console.WriteLine($"{author.Id} | {author.LastName} {author.FirstName} | {author.Email} | {author.Gender} | {author.Ip}");
        }

        public void BreakSection()
        {
            Console.WriteLine("\n---------------------");
        }

        public void Continue()
        {
            BreakSection();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        public void InvalidInput()
        {
            BreakSection();
            Console.WriteLine("Input is invalid.");
            BreakSection();
        }
    }
}
