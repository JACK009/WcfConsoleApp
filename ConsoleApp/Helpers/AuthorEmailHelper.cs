using ConsoleApp.AuthorServiceReference;
using System;

namespace ConsoleApp.Helpers
{
    public class AuthorEmailHelper
    {
        private readonly TextHelper _textHelper;
        private readonly string _defaultEmail;

        public AuthorEmailHelper()
        {
            _textHelper = new TextHelper();
            _defaultEmail = "cstegell0@live.com";
        }
        public void GetAuthorByEmail()
        {
            Console.WriteLine($"Insert the email to search: [{_defaultEmail}]");
            string email = Console.ReadLine();

            if (string.IsNullOrEmpty(email))
            {
                email = _defaultEmail;
            }

            AuthorServiceClient proxy = new AuthorServiceClient();
            Author author = proxy.GetAuthorByEmail(email);

            if (author != null)
            {
                _textHelper.AuthorLine(author);
                _textHelper.Continue();
            }
            else
            {
                Console.WriteLine($"No author found with email \"{email}\"");
                _textHelper.Continue();
            }

            proxy.Close();
        }
    }
}
